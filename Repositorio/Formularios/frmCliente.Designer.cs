namespace Formularios
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.side1 = new System.Windows.Forms.ToolStripSeparator();
            this.side2 = new System.Windows.Forms.ToolStripSeparator();
            this.side3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpRelacao = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpjCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnDeletar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.tbcCliente.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpRelacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.side1,
            this.btnEditar,
            this.side2,
            this.btnDeletar,
            this.side3,
            this.btnCancelar,
            this.toolStripSeparator7,
            this.btnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 31);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // side1
            // 
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(6, 31);
            // 
            // side2
            // 
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(6, 31);
            // 
            // side3
            // 
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // tbcCliente
            // 
            this.tbcCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcCliente.Controls.Add(this.tabPage3);
            this.tbcCliente.Controls.Add(this.tpRelacao);
            this.tbcCliente.Location = new System.Drawing.Point(12, 107);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(701, 272);
            this.tbcCliente.TabIndex = 39;
            this.tbcCliente.SelectedIndexChanged += new System.EventHandler(this.tbcCliente_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(693, 246);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Informações dos Clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.txtResponsavel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Label10);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.Label9);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.Label8);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.btnProcurar);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtDocumento);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(-2, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(695, 245);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(325, 194);
            this.txtResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(259, 20);
            this.txtResponsavel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Responsavel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Telefone:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(17, 17);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(102, 13);
            this.Label10.TabIndex = 54;
            this.Label10.Text = "Código Cliente *";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(324, 153);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(259, 20);
            this.txtCidade.TabIndex = 6;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(320, 136);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(52, 13);
            this.Label9.TabIndex = 52;
            this.Label9.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(324, 112);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(259, 20);
            this.txtBairro.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(320, 98);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(47, 13);
            this.Label8.TabIndex = 50;
            this.Label8.Text = "Bairro:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(21, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 20);
            this.txtCodigo.TabIndex = 49;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcurar.Location = new System.Drawing.Point(143, 31);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(105, 25);
            this.btnProcurar.TabIndex = 30;
            this.btnProcurar.Text = "Carregar...";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(324, 74);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(259, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(320, 57);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Endereço:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(21, 110);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(272, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(20, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Documento: *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 71);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome: *";
            // 
            // tpRelacao
            // 
            this.tpRelacao.BackColor = System.Drawing.SystemColors.Control;
            this.tpRelacao.Controls.Add(this.label12);
            this.tpRelacao.Controls.Add(this.txtPesquisar);
            this.tpRelacao.Controls.Add(this.dtgCliente);
            this.tpRelacao.ImageIndex = 1;
            this.tpRelacao.Location = new System.Drawing.Point(4, 22);
            this.tpRelacao.Name = "tpRelacao";
            this.tpRelacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelacao.Size = new System.Drawing.Size(693, 246);
            this.tpRelacao.TabIndex = 1;
            this.tpRelacao.Text = "Lista Completa dos Clientes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(62, 3);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(628, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.BackgroundColor = System.Drawing.Color.White;
            this.dtgCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCliente.ColumnHeadersHeight = 21;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nome,
            this.cpjCnpj,
            this.endereco,
            this.bairro,
            this.cidade,
            this.telefone,
            this.telefoneCelular,
            this.responsavel,
            this.dataCadastro});
            this.dtgCliente.Location = new System.Drawing.Point(0, 26);
            this.dtgCliente.MultiSelect = false;
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(693, 219);
            this.dtgCliente.TabIndex = 1;
            this.dtgCliente.DoubleClick += new System.EventHandler(this.dtgCliente_DoubleClick);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.idCliente.HeaderText = "Codigo";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 150;
            // 
            // cpjCnpj
            // 
            this.cpjCnpj.DataPropertyName = "cpfCnpj";
            this.cpjCnpj.HeaderText = "Cpf/Cnpj";
            this.cpjCnpj.Name = "cpjCnpj";
            this.cpjCnpj.ReadOnly = true;
            this.cpjCnpj.Width = 80;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 150;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 75;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 80;
            // 
            // telefoneCelular
            // 
            this.telefoneCelular.DataPropertyName = "telefoneCelular";
            this.telefoneCelular.HeaderText = "Celular";
            this.telefoneCelular.Name = "telefoneCelular";
            this.telefoneCelular.ReadOnly = true;
            this.telefoneCelular.Width = 80;
            // 
            // responsavel
            // 
            this.responsavel.DataPropertyName = "responsavel";
            this.responsavel.HeaderText = "Responsavel";
            this.responsavel.Name = "responsavel";
            this.responsavel.ReadOnly = true;
            this.responsavel.Width = 150;
            // 
            // dataCadastro
            // 
            this.dataCadastro.DataPropertyName = "datacadastro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.dataCadastro.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataCadastro.HeaderText = "Data de Cadastro";
            this.dataCadastro.Name = "dataCadastro";
            this.dataCadastro.ReadOnly = true;
            this.dataCadastro.Width = 90;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(122, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(382, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "De maneira fácil e rápida você pode visualizar e verificar a relação dos clientes" +
    ".";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(119, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(322, 13);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Cadastrar e Consultar Lista de Todos os Clientes";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.PictureBox2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 31);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(725, 67);
            this.Panel2.TabIndex = 0;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox2.ErrorImage = null;
            this.PictureBox2.Image = global::Formularios.Properties.Resources.cadastroalunos;
            this.PictureBox2.InitialImage = null;
            this.PictureBox2.Location = new System.Drawing.Point(31, 1);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(80, 66);
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Formularios.Properties.Resources.novoregistro;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(64, 28);
            this.btnNovo.Text = "&Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Formularios.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 28);
            this.btnEditar.Text = "&Salvar/Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::Formularios.Properties.Resources.excluir;
            this.btnDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(72, 28);
            this.btnDeletar.Text = "&Deletar";
            this.btnDeletar.ToolTipText = "Delete";
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Formularios.Properties.Resources.cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 28);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Formularios.Properties.Resources.fechar;
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(70, 28);
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(23, 153);
            this.txtTelefone.Mask = "(99)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(143, 20);
            this.txtTelefone.TabIndex = 58;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(23, 194);
            this.txtCelular.Mask = "(99)00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(143, 20);
            this.txtCelular.TabIndex = 59;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 391);
            this.ControlBox = false;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.tbcCliente);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcCliente.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpRelacao.ResumeLayout(false);
            this.tpRelacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripSeparator side1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator side2;
        private System.Windows.Forms.ToolStripButton btnDeletar;
        private System.Windows.Forms.ToolStripSeparator side3;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnFechar;
        internal System.Windows.Forms.TabControl tbcCliente;
        internal System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TabPage tpRelacao;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpjCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastro;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
    }
}