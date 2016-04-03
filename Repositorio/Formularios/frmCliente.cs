using NHibernate;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmCliente : Form
    {

        private Cliente cliente = new Cliente();
        private Usuario u = new Usuario();
        private ISession session;
        private bool alte = false;

        public frmCliente(Usuario u)
        {
            InitializeComponent();
            this.u = u;
            dtgCliente.AutoGenerateColumns = false;
        }

        #region EVENTOS
        private void frmCliente_Load(object sender, EventArgs e)
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
            btnNovo.Enabled = false;
            btnEditar.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos(false);
            Permisao();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (validarCampoCodigo())
                return;

            cliente = validarCamposObrigatorios();
            if (cliente == null)
                return;
           
            //DEFINE SALVA OU ALTERA
            if (txtCodigo.Text == "NOVO")
            {
                try
                {
                    int retorno = cliente.Save(session);
                    MessageBox.Show("Inserido com sucesso:\nCodigo: (" + retorno.ToString() + ") Nome: " + cliente.Nome + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaGrade(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel inserir.\nDetalhes :" + ex.InnerException.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (alte)
            {
                try
                {
                    cliente.Update(session);
                    MessageBox.Show("Alterado com sucesso:\nCodigo: (" + cliente.Id + ") Nome: " + cliente.Nome + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaGrade(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel alterar.\nDetalhes :" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = (int)dtgCliente.CurrentRow.Cells["id"].Value;
            cliente.Id = id;
            var Selecionado = cliente.Find(session);

            DialogResult resultado = MessageBox.Show("Deseja deletar o Cliente: " + Selecionado.Nome + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    MessageBox.Show("Não foi possivel excluir. Usuario Contem esses Pedidos:\nQuantidade - " + Selecionado.Pedidos.Count, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes :" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            session.Close();
            atualizaGrade(false);
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
        private void dtgCliente_DoubleClick(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            limparCampos(false);

            var id = (int)dtgCliente.CurrentRow.Cells["id"].Value;
            cliente.Id = id;
            var Selecionado = cliente.Find(session);

            setParametrosForm(Selecionado);

            
            tbcCliente.SelectedIndex = 0;
            Permisao();
            txtNome.Focus();

            session.Close();
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pesquisar();
        }
        private void tbcCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Permisao();
        }
        #endregion

        #region METODOS
        private void setParametrosForm(Cliente cliente)
        {
            if (txtCodigo.Text != "NOVO")
            {
                txtCodigo.Text = Convert.ToString(cliente.Id);
            }
            txtNome.Text = cliente.Nome.ToUpper();
            txtEndereco.Text = cliente.Endereco.ToUpper();
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            txtTelefone.Text = cliente.Telefone;
            txtCelular.Text = cliente.Celular;
            txtResponsavel.Text = cliente.NomeDoResponsavel.ToUpper();
            txtDocumento.Text = cliente.Documento;
            /*if (cliente.ToString() == "CPF")
            {
                ClienteCPF cpf = (ClienteCPF)cliente;
                txtCpfCnpj.Text = cpf.CPF;
            }
            ClienteCNPJ cnpj = (ClienteCNPJ)cliente;
            txtCpfCnpj.Text = cnpj.CNPJ;
            */
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
            txtNome.Text = "";
            txtDocumento.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtResponsavel.Text = "";
            if (novo == true)
            {
                txtNome.Focus();
            }
        }
        private void atualizaGrade(bool a)
        {
            session = NHibernateHelper.AbreSession();
            try
            {
                IList<Cliente> listaCliente = null;
                if (a == true)
                {
                    cliente.Nome = txtPesquisar.Text;
                    listaCliente = cliente.BuscaPorNomeDeCliente(session);
                }
                else
                    listaCliente = cliente.List(session);

                dtgCliente.DataSource = null;

                if (listaCliente.Count > 0)
                    dtgCliente.DataSource = listaCliente;

                dtgCliente.Update();
                dtgCliente.Refresh();
                limparCampos(false);
                Permisao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Cliente validarCamposObrigatorios()
        {
            Cliente u = new Cliente
            {
                Id = (txtCodigo.Text != "NOVO") ? Convert.ToInt32(txtCodigo.Text) : 0,
                Nome = txtNome.Text.ToUpper(),
                Documento = txtDocumento.Text,
                Endereco = txtEndereco.Text.ToUpper(),
                Bairro = txtBairro.Text.ToUpper(),
                Cidade = txtCidade.Text.ToUpper(),
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                NomeDoResponsavel = txtResponsavel.Text.ToUpper(),
                DataCadastro = DateTime.Now
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
                        case "Nome":
                            txtNome.Focus();
                            break;
                        case "Documento":
                            txtDocumento.Focus();
                            break;
                        case "Endereco":
                            txtEndereco.Focus();
                            break;
                        case "Bairro":
                            txtBairro.Focus();
                            break;
                        case "Cidade":
                            txtCidade.Focus();
                            break;
                        case "Telefone":
                            txtTelefone.Focus();
                            break;
                        case "Celular":
                            txtCelular.Focus();
                            break;
                        case "NomeDoResponsavel":
                            txtResponsavel.Focus();
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
        private bool validarCamposNaoObrigatorios()
        {
            int valor;
            if (!Int32.TryParse(txtTelefone.Text, out valor))
            {
                MessageBox.Show("Campo telefone precisa ser numerico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Focus();
                return true;
            }
            if (!Int32.TryParse(txtCelular.Text, out valor))
            {
                MessageBox.Show("Campo celular precisa ser numerico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
                return true;
            }
            return false;
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

            if ((!u.Deletar) || tbcCliente.SelectedIndex != 1)
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
                cliente.Id = Convert.ToInt32(txtCodigo.Text);
                var Selecionado = cliente.Find(session);
                if (Selecionado == null)
                {
                    MessageBox.Show("Nenhum cadastro de cliente com esse codigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
