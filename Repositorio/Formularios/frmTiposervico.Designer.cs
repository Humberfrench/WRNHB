﻿namespace Formularios
{
    partial class frmTipoServico
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.side1 = new System.Windows.Forms.ToolStripSeparator();
            this.side2 = new System.Windows.Forms.ToolStripSeparator();
            this.side3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tbcServico = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpRelacao = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgTipoServico = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tbcServico.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpRelacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoServico)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(593, 31);
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
            // tbcServico
            // 
            this.tbcServico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcServico.Controls.Add(this.tabPage3);
            this.tbcServico.Controls.Add(this.tpRelacao);
            this.tbcServico.Location = new System.Drawing.Point(12, 107);
            this.tbcServico.Name = "tbcServico";
            this.tbcServico.SelectedIndex = 0;
            this.tbcServico.Size = new System.Drawing.Size(569, 195);
            this.tbcServico.TabIndex = 39;
            this.tbcServico.SelectedIndexChanged += new System.EventHandler(this.tbcServico_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(561, 169);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Informações dos Tipos de Serviços";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.Label10);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.btnProcurar);
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(558, 166);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(17, 17);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(163, 13);
            this.Label10.TabIndex = 54;
            this.Label10.Text = "Código Tipos de Serviços *";
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
            this.btnProcurar.Location = new System.Drawing.Point(161, 31);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(105, 25);
            this.btnProcurar.TabIndex = 30;
            this.btnProcurar.Text = "Carregar...";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(21, 71);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(402, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descrição: *";
            // 
            // tpRelacao
            // 
            this.tpRelacao.BackColor = System.Drawing.SystemColors.Control;
            this.tpRelacao.Controls.Add(this.label12);
            this.tpRelacao.Controls.Add(this.dtgTipoServico);
            this.tpRelacao.Controls.Add(this.txtPesquisar);
            this.tpRelacao.ImageIndex = 1;
            this.tpRelacao.Location = new System.Drawing.Point(4, 22);
            this.tpRelacao.Name = "tpRelacao";
            this.tpRelacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelacao.Size = new System.Drawing.Size(561, 169);
            this.tpRelacao.TabIndex = 1;
            this.tpRelacao.Text = "Lista Completa dos Tipos de Serviços";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Pesquisar:";
            // 
            // dtgTipoServico
            // 
            this.dtgTipoServico.AllowUserToAddRows = false;
            this.dtgTipoServico.AllowUserToDeleteRows = false;
            this.dtgTipoServico.BackgroundColor = System.Drawing.Color.White;
            this.dtgTipoServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgTipoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao});
            this.dtgTipoServico.Location = new System.Drawing.Point(0, 26);
            this.dtgTipoServico.Name = "dtgTipoServico";
            this.dtgTipoServico.ReadOnly = true;
            this.dtgTipoServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTipoServico.Size = new System.Drawing.Size(561, 141);
            this.dtgTipoServico.TabIndex = 43;
            this.dtgTipoServico.DoubleClick += new System.EventHandler(this.dtgTipoServico_DoubleClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(62, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(493, 20);
            this.txtPesquisar.TabIndex = 44;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
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
            this.Label2.Size = new System.Drawing.Size(425, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "De maneira fácil e rápida você pode visualizar e verificar a relação dos tipos de" +
    " serviços.";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(119, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(385, 13);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Cadastrar e Consultar Lista de Todos os Tipos de Serviços";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.PictureBox2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 31);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(593, 67);
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
            // id
            // 
            this.id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 75;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descricao.Width = 150;
            // 
            // frmTiposervico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 319);
            this.ControlBox = false;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.tbcServico);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTiposervico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Tipos de Serviços";
            this.Load += new System.EventHandler(this.frmTiposervico_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcServico.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpRelacao.ResumeLayout(false);
            this.tpRelacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoServico)).EndInit();
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
        internal System.Windows.Forms.TabControl tbcServico;
        internal System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TabPage tpRelacao;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.DataGridView dtgTipoServico;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}