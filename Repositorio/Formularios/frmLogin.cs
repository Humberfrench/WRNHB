using NHibernate;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmLogin : Form
    {
        public Usuario u = new Usuario();
        ISession session;
        public frmLogin()
        {
            InitializeComponent();
            
        }

        public Usuario getUsuario()
        {
            return u;
        }
        protected void Entrar()
        {
            session = NHibernateHelper.AbreSession();
            try
            {
                if (ValidarCampos())
                    return;

                u.Login = txtLogin.Text.ToUpper();
                u.Senha = txtSenha.Text;
                u = u.Valido(session);
                if (u != null)
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
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                session.Close();
            }
        }
        protected bool ValidarCampos()
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Campo Login nao pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo Senha não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        protected void limparCampos()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            u = null;
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
