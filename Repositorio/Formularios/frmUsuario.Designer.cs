namespace Formularios
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.side1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.side2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeletar = new System.Windows.Forms.ToolStripButton();
            this.side3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGravarNao = new System.Windows.Forms.RadioButton();
            this.rbGravarSim = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpRelacao = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grava = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.altera = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAlteraNao = new System.Windows.Forms.RadioButton();
            this.rbAlteraSim = new System.Windows.Forms.RadioButton();
            this.Label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbDeletaNao = new System.Windows.Forms.RadioButton();
            this.rbDeletaSim = new System.Windows.Forms.RadioButton();
            this.Label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tbcCliente.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpRelacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // btnNovo
            // 
            this.btnNovo.Image = global::Formularios.Properties.Resources.novoregistro;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(64, 28);
            this.btnNovo.Text = "&Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // side1
            // 
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(6, 31);
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
            // side2
            // 
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(6, 31);
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
            // side3
            // 
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(6, 31);
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
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
            // tbcCliente
            // 
            this.tbcCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcCliente.Controls.Add(this.tabPage3);
            this.tbcCliente.Controls.Add(this.tpRelacao);
            this.tbcCliente.Location = new System.Drawing.Point(12, 107);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(701, 273);
            this.tbcCliente.TabIndex = 0;
            this.tbcCliente.SelectedIndexChanged += new System.EventHandler(this.tbcCliente_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(693, 247);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Informações dos Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Label10);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.btnProcurar);
            this.groupBox2.Controls.Add(this.txtSenha);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.txtLogin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(680, 233);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(308, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 170);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões";
            // 
            // rbGravarNao
            // 
            this.rbGravarNao.AutoSize = true;
            this.rbGravarNao.Location = new System.Drawing.Point(56, 22);
            this.rbGravarNao.Name = "rbGravarNao";
            this.rbGravarNao.Size = new System.Drawing.Size(45, 17);
            this.rbGravarNao.TabIndex = 8;
            this.rbGravarNao.TabStop = true;
            this.rbGravarNao.Text = "Não";
            this.rbGravarNao.UseVisualStyleBackColor = true;
            // 
            // rbGravarSim
            // 
            this.rbGravarSim.AutoSize = true;
            this.rbGravarSim.Location = new System.Drawing.Point(8, 22);
            this.rbGravarSim.Name = "rbGravarSim";
            this.rbGravarSim.Size = new System.Drawing.Size(42, 17);
            this.rbGravarSim.TabIndex = 7;
            this.rbGravarSim.TabStop = true;
            this.rbGravarSim.Text = "Sim";
            this.rbGravarSim.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 150);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nome: *";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(17, 17);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(105, 13);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Código Usuario *";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(21, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 20);
            this.txtCodigo.TabIndex = 1;
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
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Carregar...";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(21, 110);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(272, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(20, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Senha: *";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(21, 71);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(272, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Login: *";
            // 
            // tpRelacao
            // 
            this.tpRelacao.BackColor = System.Drawing.SystemColors.Control;
            this.tpRelacao.Controls.Add(this.label12);
            this.tpRelacao.Controls.Add(this.txtPesquisar);
            this.tpRelacao.Controls.Add(this.dtgUsuario);
            this.tpRelacao.ImageIndex = 1;
            this.tpRelacao.Location = new System.Drawing.Point(4, 22);
            this.tpRelacao.Name = "tpRelacao";
            this.tpRelacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelacao.Size = new System.Drawing.Size(693, 247);
            this.tpRelacao.TabIndex = 1;
            this.tpRelacao.Text = "Lista Completa dos Usuarios";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(62, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(628, 20);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dtgUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgUsuario.ColumnHeadersHeight = 21;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.Login,
            this.Senha,
            this.nome,
            this.grava,
            this.altera,
            this.deleta});
            this.dtgUsuario.Location = new System.Drawing.Point(0, 25);
            this.dtgUsuario.MultiSelect = false;
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuario.Size = new System.Drawing.Size(693, 219);
            this.dtgUsuario.TabIndex = 4;
            this.dtgUsuario.DoubleClick += new System.EventHandler(this.dtgUsuario_DoubleClick_1);
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
            this.Label2.Size = new System.Drawing.Size(385, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "De maneira fácil e rápida você pode visualizar e verificar a relação dos usuarios" +
    ".";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(119, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(327, 13);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Cadastrar e Consultar Lista de Todos os Usuarios";
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
            this.Panel2.TabIndex = 40;
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
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.idUsuario.HeaderText = "Codigo";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUsuario.Width = 50;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Login.DefaultCellStyle = dataGridViewCellStyle3;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 75;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Senha.Width = 75;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome Do Usuario";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 150;
            // 
            // grava
            // 
            this.grava.DataPropertyName = "Gravar";
            this.grava.HeaderText = "Gravar";
            this.grava.Name = "grava";
            this.grava.ReadOnly = true;
            this.grava.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grava.Width = 50;
            // 
            // altera
            // 
            this.altera.DataPropertyName = "Alterar";
            this.altera.HeaderText = "Alterar";
            this.altera.Name = "altera";
            this.altera.ReadOnly = true;
            this.altera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.altera.Width = 50;
            // 
            // deleta
            // 
            this.deleta.DataPropertyName = "Deletar";
            this.deleta.HeaderText = "Deletar";
            this.deleta.Name = "deleta";
            this.deleta.ReadOnly = true;
            this.deleta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleta.Width = 50;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(5, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Grava: *";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.rbGravarSim);
            this.panel1.Controls.Add(this.rbGravarNao);
            this.panel1.Location = new System.Drawing.Point(11, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 44);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbAlteraNao);
            this.panel3.Controls.Add(this.rbAlteraSim);
            this.panel3.Controls.Add(this.Label9);
            this.panel3.Location = new System.Drawing.Point(11, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 46);
            this.panel3.TabIndex = 15;
            // 
            // rbAlteraNao
            // 
            this.rbAlteraNao.AutoSize = true;
            this.rbAlteraNao.Location = new System.Drawing.Point(55, 23);
            this.rbAlteraNao.Name = "rbAlteraNao";
            this.rbAlteraNao.Size = new System.Drawing.Size(45, 17);
            this.rbAlteraNao.TabIndex = 13;
            this.rbAlteraNao.TabStop = true;
            this.rbAlteraNao.Text = "Não";
            this.rbAlteraNao.UseVisualStyleBackColor = true;
            // 
            // rbAlteraSim
            // 
            this.rbAlteraSim.AutoSize = true;
            this.rbAlteraSim.Location = new System.Drawing.Point(7, 23);
            this.rbAlteraSim.Name = "rbAlteraSim";
            this.rbAlteraSim.Size = new System.Drawing.Size(42, 17);
            this.rbAlteraSim.TabIndex = 12;
            this.rbAlteraSim.TabStop = true;
            this.rbAlteraSim.Text = "Sim";
            this.rbAlteraSim.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(4, 7);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(57, 13);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "Altera: *";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbDeletaNao);
            this.panel4.Controls.Add(this.rbDeletaSim);
            this.panel4.Controls.Add(this.Label8);
            this.panel4.Location = new System.Drawing.Point(11, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 46);
            this.panel4.TabIndex = 16;
            // 
            // rbDeletaNao
            // 
            this.rbDeletaNao.AutoSize = true;
            this.rbDeletaNao.Location = new System.Drawing.Point(57, 22);
            this.rbDeletaNao.Name = "rbDeletaNao";
            this.rbDeletaNao.Size = new System.Drawing.Size(45, 17);
            this.rbDeletaNao.TabIndex = 15;
            this.rbDeletaNao.TabStop = true;
            this.rbDeletaNao.Text = "Não";
            this.rbDeletaNao.UseVisualStyleBackColor = true;
            // 
            // rbDeletaSim
            // 
            this.rbDeletaSim.AutoSize = true;
            this.rbDeletaSim.Location = new System.Drawing.Point(9, 22);
            this.rbDeletaSim.Name = "rbDeletaSim";
            this.rbDeletaSim.Size = new System.Drawing.Size(42, 17);
            this.rbDeletaSim.TabIndex = 14;
            this.rbDeletaSim.TabStop = true;
            this.rbDeletaSim.Text = "Sim";
            this.rbDeletaSim.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(6, 6);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 13);
            this.Label8.TabIndex = 13;
            this.Label8.Text = "Deleta: *";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 392);
            this.ControlBox = false;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.tbcCliente);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Cliente";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcCliente.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tpRelacao.ResumeLayout(false);
            this.tpRelacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TabPage tpRelacao;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.RadioButton rbGravarNao;
        private System.Windows.Forms.RadioButton rbGravarSim;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbDeletaNao;
        private System.Windows.Forms.RadioButton rbDeletaSim;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbAlteraNao;
        private System.Windows.Forms.RadioButton rbAlteraSim;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn grava;
        private System.Windows.Forms.DataGridViewCheckBoxColumn altera;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleta;
    }
}