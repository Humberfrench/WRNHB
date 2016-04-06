using NHibernate;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmOrigemDoPedido : Form
    {

        private OrigemDoPedido origemdopedido = new OrigemDoPedido();
        private Usuario u = new Usuario();
        private ISession session;
        private bool alte = false;

        public frmOrigemDoPedido(Usuario u)
        {
            InitializeComponent();
            this.u = u;
            dtgTipoOrigemPedido.AutoGenerateColumns = false;
        }
        #region EVENTOS
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
            DialogResult = DialogResult.No;
        }
        private void frmOrigempedido_Load(object sender, EventArgs e)
        {
            atualizaGrade(false);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos(true);
            btnNovo.Enabled = false;
            btnEditar.Enabled = true;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (validarCampoCodigo())
                return;

            origemdopedido = validarCamposObrigatorios();
            if (origemdopedido == null)
                return;

            //DEFINE SALVA OU ALTERA
            if (txtCodigo.Text == "NOVO")
            {
                try
                {
                    int retorno = origemdopedido.Save(session);
                    MessageBox.Show("Inserido com sucesso:\nCodigo: (" + retorno.ToString() + ") Nome: " + origemdopedido.Descricao + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel inserir. Detalhes :" + ex.InnerException.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (alte)
            {
                try
                {
                    origemdopedido.Update(session);
                    MessageBox.Show("Alterado com sucesso:\nCodigo: (" + origemdopedido.Id + ") Nome: " + origemdopedido.Descricao + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel alterar. Detalhes :" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            atualizaGrade(false);

            session.Close();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgTipoOrigemPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Origem do Pedido selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = (int)dtgTipoOrigemPedido.CurrentRow.Cells["id"].Value;
            origemdopedido.Id = id;
            var Selecionado = origemdopedido.Find(session);

            DialogResult resultado = MessageBox.Show("Deseja deletar o Origem do Pedido: " + Selecionado.Descricao + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            try
            {
                if (Selecionado.Pedidos.Count < 0)
                {
                    Selecionado.Delete(session);
                    MessageBox.Show("Exclido com sucesso", "Pergunta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    /*string pedidos = null;
                    foreach (var pedido in Selecionado.Pedidos)
                    {
                        pedidos += Convert.ToString(pedido.Id) + " Data: " + pedido.DataPedido.ToShortDateString() + " Cliente: " + pedido.Cliente.Nome + "\n";
                    }*/
                    MessageBox.Show("Não foi possivel excluir. Origem do Pedido Contem esses Pedidos:\nQuantidade - " + Selecionado.Pedidos.Count, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes :" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            atualizaGrade(false);

            session.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos(false);
            Permisao();
        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            atualizaGrade(true);
        }
        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                atualizaGrade(true);
        }
        private void dtgTipoOrigemPedido_DoubleClick(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgTipoOrigemPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Origem de Pedido selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            limparCampos(false);

            var id = (int)dtgTipoOrigemPedido.CurrentRow.Cells["id"].Value;
            origemdopedido.Id = id;
            var Selecionado = origemdopedido.Find(session);

            setParametrosForm(Selecionado);

            Permisao();
            tbcOrigemPedido.SelectedIndex = 0;
            txtDescricao.Focus();

            session.Close();
        }
        private void tbcOrigemPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            Permisao();
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pesquisar();
        }
        #endregion

        #region METODOS
        private void atualizaGrade(bool a)
        {
            try
            {
                session = NHibernateHelper.AbreSession();

                IList<OrigemDoPedido> listaOrigemdoPedido = null;
                if (a == true)
                {
                    origemdopedido.Descricao = txtPesquisar.Text;
                    listaOrigemdoPedido = origemdopedido.BuscaPorNomeDeOrigemDePedido(session);
                }
                else
                    listaOrigemdoPedido = origemdopedido.List(session);

                dtgTipoOrigemPedido.DataSource = null;

                if (listaOrigemdoPedido.Count > 0)
                    dtgTipoOrigemPedido.DataSource = listaOrigemdoPedido;

                dtgTipoOrigemPedido.Update();
                dtgTipoOrigemPedido.Refresh();

                limparCampos(false);
                Permisao();

                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limparCampos(bool novo)
        {
            if (novo == true)
            {
                txtCodigo.Text = "NOVO";
            }
            else
            {
                txtCodigo.Text = "";
            }
            txtDescricao.Text = "";
            if (novo == true)
            {
                txtDescricao.Focus();
            }
        }
        private OrigemDoPedido validarCamposObrigatorios()
        {
            OrigemDoPedido u = new OrigemDoPedido
            {
                Id = (txtCodigo.Text != "NOVO") ? Convert.ToInt32(txtCodigo.Text) : 0,
                Descricao = txtDescricao.Text.ToUpper(),
            };

            ValidationContext context = new ValidationContext(u, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(u, context, errors, true))
            {
                foreach (var erro in errors)
                {
                    MessageBox.Show(erro.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    var a = erro.MemberNames.GetEnumerator();
                    a.MoveNext();

                    switch (a.Current)
                    {
                        case "Descricao":
                            txtDescricao.Focus();
                            break;
                        default:
                            break;
                    }
                    break;
                }
                return null;
            }
            else
                return u;
        }
        private bool validarCampoCodigo()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Campo Codigo não pode ser vazio," +
                    " Click no botão Novo ou realize uma consulta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void setParametrosForm(OrigemDoPedido origemdopedido)
        {
            if (txtCodigo.Text != "NOVO")
            {
                txtCodigo.Text = Convert.ToString(origemdopedido.Id);
            }
            txtDescricao.Text = origemdopedido.Descricao.ToUpper();
        }
        private void Permisao()
        {
            if (!u.Gravar)
                btnNovo.Enabled = false;
            else
                btnNovo.Enabled = true;
            if (!u.Alterar)
            {
                btnEditar.Enabled = false;
                alte = false;
            }
            else
            {
                btnEditar.Enabled = true;
                alte = true;
            }

            if ((!u.Deletar) || tbcOrigemPedido.SelectedIndex != 1)
                btnDeletar.Enabled = false;
            else
                btnDeletar.Enabled = true;
        }
        private void pesquisar()
        {
            try
            {
                session = NHibernateHelper.AbreSession();

                if (validarCampoCodigo())
                    return;

                origemdopedido.Id = Convert.ToInt32(txtCodigo.Text);
                var Selecionado = origemdopedido.Find(session);
                if (Selecionado == null)
                {
                    MessageBox.Show("Nenhum cadastro de origem de pedido com esse codigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    setParametrosForm(Selecionado);
                }

                session.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Não pode realizar consulta com o codigo 'NOVO' ou vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
