using NHibernate;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmTiposervico : Form
    {

        private TipoDeServico tipodeservico = new TipoDeServico();
        private Usuario u = new Usuario();
        private ISession session;
        private bool alte = false;

        public frmTiposervico(Usuario u)
        {
            InitializeComponent();
            this.u = u;
            dtgTipoServico.AutoGenerateColumns = false;
        }
        #region EVENTOS
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
            DialogResult = DialogResult.No;
        }
        private void frmTiposervico_Load(object sender, EventArgs e)
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

            tipodeservico = validarCamposObrigatorios();
            if (tipodeservico == null)
                return;

            //DEFINE SALVA OU ALTERA
            if (txtCodigo.Text == "NOVO")
            {
                try
                {
                    int retorno = tipodeservico.Save(session);
                    MessageBox.Show("Inserido com sucesso:\nCodigo: (" + retorno.ToString() + ") Nome: " + tipodeservico.Descricao + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaGrade(false);
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
                    tipodeservico.Update(session);
                    MessageBox.Show("Alterado com sucesso:\nCodigo: (" + tipodeservico.Id + ") Nome: " + tipodeservico.Descricao + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaGrade(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel alterar. Detalhes :" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgTipoServico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Tipo de Servico selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = (int)dtgTipoServico.CurrentRow.Cells["id"].Value;
            tipodeservico.Id = id;
            var Selecionado = tipodeservico.Find(session);

            DialogResult resultado = MessageBox.Show("Deseja deletar o Tipo de Servico: " + Selecionado.Descricao + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    MessageBox.Show("Não foi possivel excluir. Tipo De Servicos Contem esses Pedidos:\nQuantidade - " + Selecionado.Pedidos.Count, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes :" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            session.Close();
            atualizaGrade(false);
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
        private void dtgTipoServico_DoubleClick(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgTipoServico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Tipo de Serviço selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            limparCampos(false);

            var id = (int)dtgTipoServico.CurrentRow.Cells["id"].Value;
            tipodeservico.Id = id;
            var Selecionado = tipodeservico.Find(session);

            setParametrosForm(Selecionado);

            Permisao();
            tbcServico.SelectedIndex = 0;
            txtDescricao.Focus();

            session.Close();
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pesquisar();
        }
        private void tbcServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Permisao();
        }
        #endregion

        #region METODOS
        private void atualizaGrade(bool a)
        {
            session = NHibernateHelper.AbreSession();
            try
            {
                IList<TipoDeServico> listaTipoDeServico = null;
                if (a == true)
                {
                    tipodeservico.Descricao = txtPesquisar.Text;
                    listaTipoDeServico = tipodeservico.BuscaPorNomeDeTipoDeServico(session);
                }
                else
                    listaTipoDeServico = tipodeservico.List(session);

                dtgTipoServico.DataSource = null;

                if (listaTipoDeServico.Count > 0)
                    dtgTipoServico.DataSource = listaTipoDeServico;

                dtgTipoServico.Update();
                dtgTipoServico.Refresh();

                limparCampos(false);
                Permisao();
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
        private TipoDeServico validarCamposObrigatorios()
        {
            TipoDeServico u = new TipoDeServico
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
                    " Click no botão Novo ou realize uma pesquisa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void setParametrosForm(TipoDeServico tipodeservico)
        {
            if (txtCodigo.Text != "NOVO")
            {
                txtCodigo.Text = Convert.ToString(tipodeservico.Id);
            }
            txtDescricao.Text = tipodeservico.Descricao.ToUpper();            
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
            if ((!u.Deletar) || tbcServico.SelectedIndex != 1)
                btnDeletar.Enabled = false;
            else
                btnDeletar.Enabled = true;
        }
        private void pesquisar()
        {
            session = NHibernateHelper.AbreSession();
            try
            {
                if (validarCampoCodigo())
                    return;
                //Convert.ToInt32(txtCodigo.Text);
                tipodeservico.Id = Convert.ToInt32(txtCodigo.Text);
                var Selecionado = tipodeservico.Find(session);
                if (Selecionado == null)
                {
                    MessageBox.Show("Nenhum cadastro de tipo de servico com esse codigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    setParametrosForm(Selecionado);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Não pode realizar consulta com o codigo 'NOVO' ou vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
