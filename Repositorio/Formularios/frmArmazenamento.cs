using NHibernate;
using Repositorio.Annotation;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmArmazenamento : Form
    {
        private IList<TipoDeArmazenamento> listTipodearmazenamento;
        private Armazenamento armazenamento = new Armazenamento();
        private Usuario u = new Usuario();
        private ISession session;
        private bool alte = false;

        public frmArmazenamento(Usuario u)
        {
            InitializeComponent();
            this.u = u;
            resetCmbT();
            dtgArmazenamento.AutoGenerateColumns = false;
        }

        #region EVENTOS
        private void btnFechar_Click(object sender, EventArgs e)
        {
            fechaFrm();
        }
        private void frmArmazenamento_Load(object sender, EventArgs e)
        {
            atualizaGrade(false);
        }
        private void tbcCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Permisao();
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

            armazenamento = validarCamposObrigatorios();
            if (armazenamento == null)
                return;

            //DEFINE SALVA OU ALTERA
            if (txtCodigo.Text == "NOVO")
            {
                try
                {
                    int retorno = armazenamento.Save(session);
                    MessageBox.Show("Inserido com sucesso:\nCodigo: (" + retorno.ToString() + ") Descricão: " + armazenamento.Descricao + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    armazenamento.Update(session);
                    MessageBox.Show("Alterado com sucesso:\nCodigo: (" + armazenamento.Id + ") Descricão: " + armazenamento.Descricao + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel alterar. Detalhes :" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            session.Close();
            atualizaGrade(false);            
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgArmazenamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Armazenamento selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = (int)dtgArmazenamento.CurrentRow.Cells["id"].Value;
            armazenamento.Id = id;
            var Selecionado = armazenamento.Find(session);

            DialogResult resultado = MessageBox.Show("Deseja deletar o Armazenamento: " + Selecionado.Descricao + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            try
            {
                if (Selecionado.Pedidos.Count == 0)
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
                    MessageBox.Show("Não foi possivel excluir. Armazenamento Contem esses Pedidos:\nQuantidade - " + Selecionado.Pedidos.Count, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dtgCliente_DoubleClick(object sender, EventArgs e)
        {
            session = NHibernateHelper.AbreSession();

            if (dtgArmazenamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Armazenamento selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            limparCampos(false);

            var id = (int)dtgArmazenamento.CurrentRow.Cells["id"].Value;
            armazenamento.Id = id;
            var Selecionado = armazenamento.Find(session);

            setParametrosForm(Selecionado);

            Permisao();
            tbcCliente.SelectedIndex = 0;
            txtDescricao.Focus();

            session.Close();
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pesquisar();
        }
        #endregion

        #region METODOS
        private void setParametrosForm(Armazenamento armazenamento)
        {
            if (txtCodigo.Text != "NOVO")
            {
                txtCodigo.Text = Convert.ToString(armazenamento.Id);
            }
            txtDescricao.Text = armazenamento.Descricao.ToUpper();
            cmbTipoArm.SelectedIndex = cmbTipoArm.FindStringExact(armazenamento.TipodeArmazenamento.Descricao);
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
            cmbTipoArm.SelectedIndex = 0;
            if (novo == true)
            {
                txtDescricao.Focus();
            }
        }
        private void atualizaGrade(bool a)
        {
            try
            {
                session = NHibernateHelper.AbreSession();

                IList<Armazenamento> listaArmazenamento = null;
                if (a == true)
                {
                    armazenamento.Descricao = txtPesquisar.Text;
                    listaArmazenamento = armazenamento.BuscaPorNomeDeArmazenamento(session);
                }
                else
                    listaArmazenamento = armazenamento.List(session);

                dtgArmazenamento.DataSource = null;

                if (listaArmazenamento.Count > 0)
                    dtgArmazenamento.DataSource = listaArmazenamento;

                //var novalistaArmazenamento = listaArmazenamento.Select(Armazenamento => new {
                    //idArmazenamento = Armazenamento.idArmazenamento,
                    //descricao = Armazenamento.descricao,
                    //descricaoArmazenamento = Armazenamento.tipoArmazenameto.descricao,
                //}).ToList();
                //dtgArmazenamento.DataSource = null;
                //dtgArmazenamento.DataSource = novalistaArmazenamento;

                dtgArmazenamento.Update();
                dtgArmazenamento.Refresh();

                limparCampos(false);
                Permisao();

                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private Armazenamento validarCamposObrigatorios()
        {
            var tipoarmazenamento = from t in listTipodearmazenamento
                                    where t.Descricao == cmbTipoArm.Text
                                    select t;

            Armazenamento u = new Armazenamento
            {
                Id = (txtCodigo.Text != "NOVO") ? Convert.ToInt32(txtCodigo.Text) : 0,
                Descricao = txtDescricao.Text.ToUpper(),
                TipodeArmazenamento = (tipoarmazenamento.Any()) ? tipoarmazenamento.First() : new TipoDeArmazenamento
                {
                    Descricao = ""
                }
            };

            ValidationContext context = new ValidationContext(u, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(u, context, errors, true))
            {
                validar(errors);                
                return null;
            }
            else
                return u;
        }
        private void validar(IEnumerable<ValidationResult> results)
        {
            foreach (var erro in results)
            {
                if (erro is CompositeValidationResult)
                {
                    MessageBox.Show(erro.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbTipoArm.Focus();                    
                    break;
                    //para validar todos os campos do objeto(recursivo) - validar(((CompositeValidationResult)erro).Results);
                }
                else
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
            }
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
            try
            {
                session = NHibernateHelper.AbreSession();

                if (validarCampoCodigo())
                    return;

                armazenamento.Id = Convert.ToInt32(txtCodigo.Text);
                var Selecionado = armazenamento.Find(session);
                if (Selecionado == null)
                {
                    MessageBox.Show("Nenhum cadastro de Armazenamento com esse codigo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void resetCmbT()
        {
            TipoDeArmazenamento t = new TipoDeArmazenamento();
            try
            {
                session = NHibernateHelper.AbreSession();

                listTipodearmazenamento = t.List(session);
                cmbTipoArm.Items.Add("");
                foreach (var item in listTipodearmazenamento)
                {
                    cmbTipoArm.Items.Add(item.Descricao);
                }

                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fechaFrm();
            }
        }
        private void fechaFrm()
        {
            Dispose();
            DialogResult = DialogResult.No;
        }
        #endregion
    }
}
