using NHibernate;
using Repositorio.DAO;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmLogin : Form
    {

        public Usuario usuario = new Usuario();
        //public UsuarioDAO udao;
        private ISession session;

        public frmLogin()
        {
            InitializeComponent();
            
        }

        public Usuario getUsuario()
        {
            return usuario;
        }
        protected void Entrar()
        {
            session = NHibernateHelper.AbreSession();
            try
            {
                usuario = ValidarCampos();
                if (usuario == null)
                    return;

                //udao = new UsuarioDAO(session);
                //usuario = udao.Valido(usuario);
                usuario = usuario.Valido(session);

                if (usuario != null)
                {
                    //u = udao.consultarPorLogin(txtLogin.Text);
                    Dispose();
                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Usuario e/ou senha incorreta ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limparCampos();
                    txtLogin.Focus();
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            session.Close();
        }
        protected Usuario ValidarCampos()
        {
            /*if (txtLogin.Text == "")
            {
                MessageBox.Show("Campo Login nao pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo Senha não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;*/
            //string erros = null;
            Usuario u = new Usuario { Login = txtLogin.Text.ToUpper(), Senha = txtSenha.Text, Nome = "a", Gravar = false, Alterar = false, Deletar = false };

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
                        default:
                            break;
                    }
                    break;
                    //erros += erro.ErrorMessage + "\n";
                }
                //MessageBox.Show(erros, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
                return u;
        }
        protected void limparCampos()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            usuario = null;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            Dispose();
            DialogResult = DialogResult.No;
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtLogin.Text = txtLogin.Text.ToUpper();
        }
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entrar();
            }
        }
        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }
    }
}
