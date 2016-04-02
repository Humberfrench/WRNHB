namespace Formularios
{
    partial class frmMenu
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
            this.cmbSituacao = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtimeMaior = new System.Windows.Forms.DateTimePicker();
            this.dtimeMenor = new System.Windows.Forms.DateTimePicker();
            this.txtPesquisaCod = new System.Windows.Forms.TextBox();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.cmbSit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.btnConsultaCompleta = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusInformacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgPedido = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeServicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeArmazenamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDePagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.origemDosPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armazenametosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbSituacao.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.Controls.Add(this.btLimpar);
            this.cmbSituacao.Controls.Add(this.label4);
            this.cmbSituacao.Controls.Add(this.dtimeMaior);
            this.cmbSituacao.Controls.Add(this.dtimeMenor);
            this.cmbSituacao.Controls.Add(this.txtPesquisaCod);
            this.cmbSituacao.Controls.Add(this.btnFinalizarPedido);
            this.cmbSituacao.Controls.Add(this.cmbSit);
            this.cmbSituacao.Controls.Add(this.label3);
            this.cmbSituacao.Controls.Add(this.btnNovoPedido);
            this.cmbSituacao.Controls.Add(this.btnConsultaCompleta);
            this.cmbSituacao.Controls.Add(this.btPesquisar);
            this.cmbSituacao.Controls.Add(this.label2);
            this.cmbSituacao.Controls.Add(this.txtPesquisa);
            this.cmbSituacao.Controls.Add(this.label1);
            this.cmbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSituacao.Location = new System.Drawing.Point(12, 27);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(984, 109);
            this.cmbSituacao.TabIndex = 1;
            this.cmbSituacao.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLimpar.Location = new System.Drawing.Point(801, 59);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(125, 25);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Até";
            // 
            // dtimeMaior
            // 
            this.dtimeMaior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeMaior.Location = new System.Drawing.Point(347, 77);
            this.dtimeMaior.Name = "dtimeMaior";
            this.dtimeMaior.Size = new System.Drawing.Size(108, 24);
            this.dtimeMaior.TabIndex = 6;
            // 
            // dtimeMenor
            // 
            this.dtimeMenor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeMenor.Location = new System.Drawing.Point(347, 31);
            this.dtimeMenor.Name = "dtimeMenor";
            this.dtimeMenor.Size = new System.Drawing.Size(108, 24);
            this.dtimeMenor.TabIndex = 4;
            // 
            // txtPesquisaCod
            // 
            this.txtPesquisaCod.Location = new System.Drawing.Point(13, 56);
            this.txtPesquisaCod.Name = "txtPesquisaCod";
            this.txtPesquisaCod.Size = new System.Drawing.Size(54, 24);
            this.txtPesquisaCod.TabIndex = 1;
            this.txtPesquisaCod.DoubleClick += new System.EventHandler(this.txtPesquisaCod_DoubleClick);
            this.txtPesquisaCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaCod_KeyDown);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(801, 30);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(125, 25);
            this.btnFinalizarPedido.TabIndex = 12;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            // 
            // cmbSit
            // 
            this.cmbSit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSit.FormattingEnabled = true;
            this.cmbSit.Items.AddRange(new object[] {
            "Selecionar",
            "Aberto",
            "Fechado"});
            this.cmbSit.Location = new System.Drawing.Point(479, 59);
            this.cmbSit.Name = "cmbSit";
            this.cmbSit.Size = new System.Drawing.Size(106, 26);
            this.cmbSit.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Situação";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovoPedido.Location = new System.Drawing.Point(670, 30);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(125, 25);
            this.btnNovoPedido.TabIndex = 10;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // btnConsultaCompleta
            // 
            this.btnConsultaCompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCompleta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultaCompleta.Location = new System.Drawing.Point(670, 59);
            this.btnConsultaCompleta.Name = "btnConsultaCompleta";
            this.btnConsultaCompleta.Size = new System.Drawing.Size(125, 25);
            this.btnConsultaCompleta.TabIndex = 11;
            this.btnConsultaCompleta.Text = "Consulta Completa";
            this.btnConsultaCompleta.UseVisualStyleBackColor = false;
            // 
            // btPesquisar
            // 
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.btPesquisar.Image = global::Formularios.Properties.Resources.search;
            this.btPesquisar.Location = new System.Drawing.Point(608, 43);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(41, 38);
            this.btPesquisar.TabIndex = 9;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(73, 56);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.ReadOnly = true;
            this.txtPesquisa.Size = new System.Drawing.Size(255, 24);
            this.txtPesquisa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Cliente:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusVersao,
            this.statusInformacao,
            this.statusUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusVersao
            // 
            this.statusVersao.Name = "statusVersao";
            this.statusVersao.Size = new System.Drawing.Size(60, 17);
            this.statusVersao.Text = "Versao 1.0";
            // 
            // statusInformacao
            // 
            this.statusInformacao.Name = "statusInformacao";
            this.statusInformacao.Size = new System.Drawing.Size(68, 17);
            this.statusInformacao.Text = "Informacao";
            // 
            // statusUsuario
            // 
            this.statusUsuario.Name = "statusUsuario";
            this.statusUsuario.Size = new System.Drawing.Size(53, 17);
            this.statusUsuario.Text = "Usuario: ";
            // 
            // dtgPedido
            // 
            this.dtgPedido.BackgroundColor = System.Drawing.Color.White;
            this.dtgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedido.Location = new System.Drawing.Point(12, 142);
            this.dtgPedido.Name = "dtgPedido";
            this.dtgPedido.Size = new System.Drawing.Size(984, 552);
            this.dtgPedido.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.configuracaoToolStripMenuItem,
            this.mnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.tiposDeServicoToolStripMenuItem,
            this.tiposDeArmazenamentosToolStripMenuItem,
            this.tiposDePagamentosToolStripMenuItem,
            this.origemDosPedidosToolStripMenuItem,
            this.armazenametosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = global::Formularios.Properties.Resources.lista_dados;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario/Usuario";
            this.funcionarioToolStripMenuItem.Visible = false;
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // tiposDeServicoToolStripMenuItem
            // 
            this.tiposDeServicoToolStripMenuItem.Name = "tiposDeServicoToolStripMenuItem";
            this.tiposDeServicoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.tiposDeServicoToolStripMenuItem.Text = "Tipos de Serviços";
            this.tiposDeServicoToolStripMenuItem.Click += new System.EventHandler(this.tiposDeServicoToolStripMenuItem_Click);
            // 
            // tiposDeArmazenamentosToolStripMenuItem
            // 
            this.tiposDeArmazenamentosToolStripMenuItem.Name = "tiposDeArmazenamentosToolStripMenuItem";
            this.tiposDeArmazenamentosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.tiposDeArmazenamentosToolStripMenuItem.Text = "Tipos de Armazenamentos";
            this.tiposDeArmazenamentosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeArmazenamentosToolStripMenuItem_Click);
            // 
            // tiposDePagamentosToolStripMenuItem
            // 
            this.tiposDePagamentosToolStripMenuItem.Name = "tiposDePagamentosToolStripMenuItem";
            this.tiposDePagamentosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.tiposDePagamentosToolStripMenuItem.Text = "Tipos de Pagamentos";
            this.tiposDePagamentosToolStripMenuItem.Click += new System.EventHandler(this.tiposDePagamentosToolStripMenuItem_Click);
            // 
            // origemDosPedidosToolStripMenuItem
            // 
            this.origemDosPedidosToolStripMenuItem.Name = "origemDosPedidosToolStripMenuItem";
            this.origemDosPedidosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.origemDosPedidosToolStripMenuItem.Text = "Origem dos Pedidos";
            this.origemDosPedidosToolStripMenuItem.Click += new System.EventHandler(this.origemDosPedidosToolStripMenuItem_Click);
            // 
            // armazenametosToolStripMenuItem
            // 
            this.armazenametosToolStripMenuItem.Name = "armazenametosToolStripMenuItem";
            this.armazenametosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.armazenametosToolStripMenuItem.Text = "Armazenametos";
            this.armazenametosToolStripMenuItem.Click += new System.EventHandler(this.armazenametosToolStripMenuItem_Click);
            // 
            // configuracaoToolStripMenuItem
            // 
            this.configuracaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem});
            this.configuracaoToolStripMenuItem.Image = global::Formularios.Properties.Resources.statistics;
            this.configuracaoToolStripMenuItem.Name = "configuracaoToolStripMenuItem";
            this.configuracaoToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.configuracaoToolStripMenuItem.Text = "Configuração";
            this.configuracaoToolStripMenuItem.Visible = false;
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // mnSair
            // 
            this.mnSair.Image = global::Formularios.Properties.Resources.cancel;
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(54, 20);
            this.mnSair.Text = "Sair";
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.dtgPedido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbSituacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Pedidos WR";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.cmbSituacao.ResumeLayout(false);
            this.cmbSituacao.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cmbSituacao;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusVersao;
        private System.Windows.Forms.ToolStripStatusLabel statusInformacao;
        private System.Windows.Forms.DataGridView dtgPedido;
        private System.Windows.Forms.Button btnConsultaCompleta;
        private System.Windows.Forms.ComboBox cmbSit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem origemDosPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armazenametosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeServicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiposDeArmazenamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusUsuario;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPesquisaCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtimeMaior;
        private System.Windows.Forms.DateTimePicker dtimeMenor;
        private System.Windows.Forms.Button btLimpar;
    }
}