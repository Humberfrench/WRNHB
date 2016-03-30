using NHibernate;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmUsuario : Form
    {
        private bool alte = false;
        private Usuario usuario = new Usuario();
        private ISession session;

        public frmUsuario()
        {
            InitializeComponent();
            dtgUsuario.AutoGenerateColumns = false;
        }

        #region EVENTOS
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            atualizaGrade(false);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
            DialogResult = DialogResult.No;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos(true);
            btnEditar.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos(false);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (validarCampoCodigo())
                return;            
                    
            usuario = validarCamposObrigatorios();
            if (usuario == null)
                return;

            //DEFINE SALVA OU ALTERA
            if (txtCodigo.Text == "NOVO")
            {                              
                try
                {                                       
                    int retorno = usuario.Adiciona(session);
                    MessageBox.Show("Inserido com sucesso:\nCodigo: (" + retorno.ToString() + ") Nome: " + usuario.Nome + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel inserir.\nDetalhes: " + ex.InnerException.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (alte)
            {
                try
                {
                    usuario.Atualizar(session);
                    MessageBox.Show("Alterado com sucesso:\nCodigo: (" + usuario.Id + ") Nome: " + usuario.Nome + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel alterar.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Realizar uma consulta antes de alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            session.Close();
            atualizaGrade(false);
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            /*
            if (dtgUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Usuario selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Selecionado = (dtgUsuario.SelectedRows[0].DataBoundItem as Usuario);
            DialogResult resultado = MessageBox.Show("Deseja deletar o Usuario - " + Selecionado.nome + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            string retorno = udao.excluir(Selecionado);
            try
            {
                int idUsuario = Convert.ToInt32(retorno);
                MessageBox.Show("Exclido com sucesso", "Pergunta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaGrade(false);
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes :" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pesquisar();
        }
        private void dtgUsuario_DoubleClick_1(object sender, EventArgs e)
        {
            /*
            if (dtgUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Usuario selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            limparCampos(false);

            var Selecionado = (dtgUsuario.SelectedRows[0].DataBoundItem as Usuario);
            txtCodigo.Text = Convert.ToString(Selecionado.idUsuario);
            txtLogin.Text = Selecionado.login;
            txtSenha.Text = Selecionado.senha;
            txtNome.Text = Selecionado.nome;
            if (Selecionado.grava == true)
                cboGrava.SelectedIndex = 1;
            else
                cboGrava.SelectedIndex = 2;

            if (Selecionado.altera == true)
                cboAltera.SelectedIndex = 1;
            else
                cboAltera.SelectedIndex = 2;

            if (Selecionado.deleta == true)
                cboDeleta.SelectedIndex = 1;
            else
                cboDeleta.SelectedIndex = 2;
            alte = true;

            tbcCliente.SelectedIndex = 0;
            txtLogin.Focus();
            */
        }
        private void tbcCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcCliente.SelectedIndex == 0)
            {
                btnDeletar.Enabled = false;
            }
            else
            {
                btnDeletar.Enabled = true;
            }
        }
        #endregion

        #region METODOS
        private void setParametrosUsuario(Usuario u)
        {
            // RECEBE UM USUARIO E COLOCA AS PROPRIEDADES DELE NO FORME
            txtLogin.Text = u.Login;
            txtSenha.Text = u.Senha;
            txtNome.Text = u.Nome;
            if (u.Gravar == true)
                rbGravarSim.Checked = true;
            else
                rbGravarNao.Checked = true;

            if (u.Alterar == true)
                rbAlteraSim.Checked = true;
            else
                rbAlteraNao.Checked = true;

            if (u.Deletar == true)
                rbDeletaSim.Checked = true;
            else
                rbDeletaNao.Checked = true;

            alte = true;  
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
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            rbGravarNao.Checked = true;
            rbAlteraNao.Checked = true;
            rbDeletaNao.Checked = true;            
            txtPesquisar.Text = "";

            alte = false;
            if (novo == true)
            {
                txtLogin.Focus();
            }
        }
        private void atualizaGrade(bool a)
        {
            session = NHibernateHelper.AbreSession();
            try
            {
                IList<Usuario> listaUsuario = null;
                if (a == true)
                {
                    usuario.Nome = txtPesquisar.Text;
                    listaUsuario = usuario.BuscaPorNomeDeUsuario(session);
                }                    
                else
                   listaUsuario = usuario.List(session);

                dtgUsuario.DataSource = null;

                if (listaUsuario.Count > 0)
                    dtgUsuario.DataSource = listaUsuario;

                dtgUsuario.Update();
                dtgUsuario.Refresh();
                limparCampos(false);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            session.Close();           
        }
        private Usuario validarCamposObrigatorios()
        {
            Usuario u = new Usuario {
                Id = (txtCodigo.Text != "NOVO") ? Convert.ToInt32(txtCodigo.Text) : 0,
                Login = txtLogin.Text.ToUpper(),
                Senha = txtSenha.Text,
                Nome = txtNome.Text,
                Gravar = (rbGravarSim.Checked) ? true : false,
                Alterar = (rbAlteraSim.Checked) ? true : false,
                Deletar = (rbDeletaSim.Checked) ? true : false
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
                        case "Login":
                            txtLogin.Focus();
                            break;
                        case "Senha":
                            txtSenha.Focus();
                            break;
                        case "Nome":
                            txtNome.Focus();
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
        private void pesquisar()
        {
            session = NHibernateHelper.AbreSession();
            try
            {
                if (validarCampoCodigo())
                    return;
                Convert.ToInt32(txtCodigo.Text);
                usuario.Id = Convert.ToInt32(txtCodigo.Text);
                var Selecionado = usuario.BuscaPorId(session);
                if (Selecionado == null)
                {
                    MessageBox.Show("Nenhum cadastro de usuario com esse codigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    setParametrosUsuario(Selecionado);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Não pode realizar consulta com o codigo 'NOVO' ou vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            session.Close();
        }
        #endregion
    }
}
