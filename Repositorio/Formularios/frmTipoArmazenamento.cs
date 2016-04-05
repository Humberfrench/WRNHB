using NHibernate;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmTipoArmazenamento : Form
    {
        private TipoDeArmazenamento tipodearmazenamento = new TipoDeArmazenamento();
        private Usuario u = new Usuario();
        private bool alte = false;
        private ISession session;

        public frmTipoArmazenamento(Usuario u)
        {
            InitializeComponent();
            this.u = u;
            dtgTipoarmazenamento.AutoGenerateColumns = false;
        }
        #region EVENTOS
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
            DialogResult = DialogResult.No;
        }
        private void frmTipoarmazenamento_Load(object sender, EventArgs e)
        {
            atualizaGrade(false);
        }
        private void dtgTipoarmazenamento_DoubleClick(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgTipoarmazenamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Tipo de Armazenameto selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            limparCampos(false);

            var id = (int)dtgTipoarmazenamento.CurrentRow.Cells["id"].Value;
            tipodearmazenamento.Id = id;
            var Selecionado = tipodearmazenamento.Find(session);

            setParametrosForm(Selecionado);

            Permisao();
            tbcTipoarmazenamento.SelectedIndex = 0;
            txtDescricao.Focus();

            session.Close();           
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

            tipodearmazenamento = validarCamposObrigatorios();
            if (tipodearmazenamento == null)
                return;

            //DEFINE SALVA OU ALTERA
            if (txtCodigo.Text == "NOVO")
            {
                try
                {
                    int retorno = tipodearmazenamento.Save(session);
                    MessageBox.Show("Inserido com sucesso:\nCodigo: (" + retorno.ToString() + ") Descrição: " + tipodearmazenamento.Descricao + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    tipodearmazenamento.Update(session);
                    MessageBox.Show("Alterado com sucesso:\nCodigo: (" + tipodearmazenamento.Id + ") Descrição: " + tipodearmazenamento.Descricao + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (dtgTipoarmazenamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Tipo de Armazenamento selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = (int)dtgTipoarmazenamento.CurrentRow.Cells["id"].Value;
            tipodearmazenamento.Id = id;
            var Selecionado = tipodearmazenamento.Find(session);

            DialogResult resultado = MessageBox.Show("Deseja deletar o Tipo de Armazenamento: " + Selecionado.Descricao + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            try
            {
                if (Selecionado.Armazenamentos.Count < 0)
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
                    MessageBox.Show("Não foi possivel excluir. Tipo De Armazenamento Contem esses Armazenametos:\nQuantidade - " + Selecionado.Armazenamentos.Count, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void tbcTipoarmazenamento_SelectedIndexChanged(object sender, EventArgs e)
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

                IList<TipoDeArmazenamento> listaTipoDeArmazenamento = null;
                if (a == true)
                {
                    tipodearmazenamento.Descricao = txtPesquisar.Text;
                    listaTipoDeArmazenamento = tipodearmazenamento.BuscaPorNomeDeTipoDeServico(session);
                }
                else
                    listaTipoDeArmazenamento = tipodearmazenamento.List(session);

                dtgTipoarmazenamento.DataSource = null;

                if (listaTipoDeArmazenamento.Count > 0)
                    dtgTipoarmazenamento.DataSource = listaTipoDeArmazenamento;

                dtgTipoarmazenamento.Update();
                dtgTipoarmazenamento.Refresh();

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
        private TipoDeArmazenamento validarCamposObrigatorios()
        {
            TipoDeArmazenamento u = new TipoDeArmazenamento
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
                    " Click no botão Novo ou escolha um Tipo de Armazenamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void setParametrosForm(TipoDeArmazenamento tipodearmazenamento)
        {
            if (txtCodigo.Text != "NOVO")
            {
                txtCodigo.Text = Convert.ToString(tipodearmazenamento.Id);
            }
            txtDescricao.Text = tipodearmazenamento.Descricao.ToUpper();
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

            if ((!u.Deletar) || tbcTipoarmazenamento.SelectedIndex != 1)
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

                tipodearmazenamento.Id = Convert.ToInt32(txtCodigo.Text);
                var Selecionado = tipodearmazenamento.Find(session);
                if (Selecionado == null)
                {
                    MessageBox.Show("Nenhum cadastro de tipo de armazenamento com esse codigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
