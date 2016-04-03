using Repositorio.Entidades;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmMenu : Form
    {
        private Usuario u = new Usuario();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Hide();
            frmLogin frmlogin = new frmLogin();
            DialogResult dialog2 = frmlogin.ShowDialog();
            if (dialog2 == DialogResult.Yes)
            {
                u = frmlogin.getUsuario();
                statusUsuario.Text = "Usuario: " + u.Nome;
                if (u.Login == "ADM")
                {
                    funcionarioToolStripMenuItem.Visible = true;
                    configuracaoToolStripMenuItem.Visible = true;
                }
                cmbSit.SelectedIndex = 0;
                Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem cereteza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmUsuario frmusuario = new frmUsuario();
            DialogResult dialog = frmusuario.ShowDialog();
            if (dialog == DialogResult.Yes || dialog == DialogResult.No)
            {
                Show();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmCliente frmcliente = new frmCliente(u);
            DialogResult dialog = frmcliente.ShowDialog();
            if (dialog == DialogResult.Yes || dialog == DialogResult.No)
            {
                Show();
            }
        }

        private void origemDosPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Hide();
            frmOrigempedido frmorigempedido = new frmOrigempedido(u);
            DialogResult dialog = frmorigempedido.ShowDialog();
            if (dialog == DialogResult.Yes || dialog == DialogResult.No)
            {
                Show();
            }*/
        }

        private void armazenametosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Hide();
            frmArmazenamento frmarmazenamento = new frmArmazenamento(u);
            DialogResult dialog = frmarmazenamento.ShowDialog();
            if (dialog == DialogResult.Yes || dialog == DialogResult.No)
            {
                Show();
            }*/
        }

        private void tiposDeArmazenamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Hide();
            frmTipoarmazenamento frmtipoarmazenamento = new frmTipoarmazenamento(u);
            DialogResult dialog = frmtipoarmazenamento.ShowDialog();
            if (dialog == DialogResult.Yes || dialog == DialogResult.No)
            {
                Show();
            }*/
        }

        private void tiposDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Hide();
            frmTipopagamento frmtipopagamento = new frmTipopagamento(u);
            DialogResult dialog = frmtipopagamento.ShowDialog();
            if (dialog == DialogResult.Yes || dialog == DialogResult.No)
            {
                Show();
            }*/
        }

        private void tiposDeServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Hide();
             frmTiposervico frmtiposervico = new frmTiposervico(u);
             DialogResult dialog = frmtiposervico.ShowDialog();
             if (dialog == DialogResult.Yes || dialog == DialogResult.No)
             {
                 Show();
             }
        }
        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* string senha = InputBox("Digite a nova senha para o ADMINISTRADOR", "ADMINISTRADOR", "");
             if (senha == "")
             {
                 MessageBox.Show("Nova senha nao pode ser vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             UsuarioDAO udao = new UsuarioDAO();
             var resultato = udao.alterarSenhaADM(senha);

             try
             {
                 var result = Convert.ToInt32(resultato);
                 MessageBox.Show("Alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             catch (Exception a)
             {
                 MessageBox.Show("Error: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }
        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            if (s == string.Empty)
                return "";
            else
                return s;
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            /*Hide();
            frmPedido frmpedido = new frmPedido(u);
            DialogResult dialog = frmpedido.ShowDialog();
            if (dialog == DialogResult.Yes || dialog == DialogResult.No)
            {
                Show();
            }*/
        }

        private void txtPesquisaCod_DoubleClick(object sender, EventArgs e)
        {
            /*Hide();
            frmPesquisa frmpesquisa = new frmPesquisa(1);
            DialogResult dialog = frmpesquisa.ShowDialog();
            if (dialog == DialogResult.Yes)
            {
                cliente = frmpesquisa.getCliente();
                txtPesquisaCod.Text = Convert.ToString(cliente.idCliente);
                txtPesquisa.Text = cliente.nome;
            }
            else
            {
                cliente = null;
                txtPesquisa.Text = "";
                txtPesquisaCod.Text = "";
            }
            Show();*/
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            /*pesquisarPedidos();*/
        }
        public bool validaCampo()
        {
            if (cmbSit.Text == "Selecionar")
            {
                MessageBox.Show("Porfavor escolher uma situacao para o pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        public void pesquisarPedidos()
        {
            /* try
             {
                 if (validaCampo())
                     return;

                 bool situacao = (cmbSit.Text == "Sim") ? true : false;
                 pedidoLista = pdao.consultarPorParamentros(txtPesquisaCod.Text, dtimeMenor.Value, dtimeMaior.Value, situacao);
                 if (pedidoLista.Count > 0)
                 {
                     var novalistaPedido = pedidoLista.Select(Pedido => new {
                         idPedido = Pedido.idPedido,
                         dataPedido = Pedido.dataPedido,
                         idCliente = Pedido.cliente.idCliente,
                         nome = Pedido.cliente.nome,
                         telefone = Pedido.cliente.telefone,
                         celular = Pedido.cliente.telefoneCelular,
                         descricao = Pedido.descricao,
                         dataLayout = Pedido.dataPrevisaolayout,
                         dataEntrega = Pedido.dataPrevisaoentrega,
                         horaEntrega = Pedido.horaPrevisaoentrega,
                         obs = Pedido.observacao,
                         situacao = Pedido.situacao,
                     }).ToList();
                     dtgPedido.DataSource = null;
                     dtgPedido.DataSource = novalistaPedido;
                 }
                 dtgPedido.Update();
                 dtgPedido.Refresh();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }

        private void txtPesquisaCod_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Convert.ToInt32(txtPesquisaCod.Text);
                    cliente = cdao.consultarPorId(txtPesquisaCod.Text);
                    txtPesquisa.Text = cliente.nome;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Campo Codigo de Cliente precisa ser numerico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cliente = null;
                    txtPesquisa.Text = "";
                    txtPesquisaCod.Text = "";
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: " + a.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cliente = null;
                    txtPesquisa.Text = "";
                    txtPesquisaCod.Text = "";
                }
            }*/
        }

    }
}
