namespace livrarianerds
{
    partial class formConsultaLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConsultaLivros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbValor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprecofinal = new System.Windows.Forms.TextBox();
            this.txtprecoinicial = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbFornecedor.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.gbTipoPesquisa.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbValor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbFornecedor);
            this.groupBox1.Controls.Add(this.gbCategoria);
            this.groupBox1.Controls.Add(this.btSair);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.dgvLivro);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbOpcoes);
            this.groupBox1.Controls.Add(this.gbTipoPesquisa);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.gbValor);
            this.groupBox1.Location = new System.Drawing.Point(10, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 620);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Tipo de  Consulta";
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.cbFornecedor);
            this.gbFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFornecedor.Location = new System.Drawing.Point(15, 196);
            this.gbFornecedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbFornecedor.Size = new System.Drawing.Size(176, 59);
            this.gbFornecedor.TabIndex = 13;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(18, 25);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(142, 27);
            this.cbFornecedor.TabIndex = 9;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(14, 275);
            this.gbCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbCategoria.Size = new System.Drawing.Size(177, 59);
            this.gbCategoria.TabIndex = 12;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(18, 25);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(143, 27);
            this.cbCategoria.TabIndex = 9;
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(445, 254);
            this.btSair.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(146, 59);
            this.btSair.TabIndex = 11;
            this.btSair.Text = " Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(240, 254);
            this.btPesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(149, 59);
            this.btPesquisar.TabIndex = 10;
            this.btPesquisar.Text = "    Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dgvLivro
            // 
            this.dgvLivro.AllowUserToAddRows = false;
            this.dgvLivro.AllowUserToResizeRows = false;
            this.dgvLivro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Location = new System.Drawing.Point(14, 351);
            this.dgvLivro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvLivro.MultiSelect = false;
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.ReadOnly = true;
            this.dgvLivro.RowHeadersVisible = false;
            this.dgvLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivro.Size = new System.Drawing.Size(596, 250);
            this.dgvLivro.TabIndex = 5;
            this.dgvLivro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivro_CellClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(131, 41);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(184, 27);
            this.txtPesquisar.TabIndex = 4;
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(14, 41);
            this.cbOpcoes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(98, 27);
            this.cbOpcoes.TabIndex = 3;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbContem);
            this.gbTipoPesquisa.Controls.Add(this.rbInicio);
            this.gbTipoPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPesquisa.Location = new System.Drawing.Point(350, 26);
            this.gbTipoPesquisa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbTipoPesquisa.Size = new System.Drawing.Size(250, 88);
            this.gbTipoPesquisa.TabIndex = 2;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Location = new System.Drawing.Point(122, 39);
            this.rbContem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(87, 23);
            this.rbContem.TabIndex = 5;
            this.rbContem.TabStop = true;
            this.rbContem.Text = "Contem";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Checked = true;
            this.rbInicio.Location = new System.Drawing.Point(22, 39);
            this.rbInicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(68, 23);
            this.rbInicio.TabIndex = 4;
            this.rbInicio.TabStop = true;
            this.rbInicio.Text = "Inicio";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(341, 124);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbStatus.Size = new System.Drawing.Size(250, 88);
            this.gbStatus.TabIndex = 1;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(129, 41);
            this.rbInativo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(78, 23);
            this.rbInativo.TabIndex = 3;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(22, 41);
            this.rbAtivo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(66, 23);
            this.rbAtivo.TabIndex = 2;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbValor
            // 
            this.gbValor.Controls.Add(this.label2);
            this.gbValor.Controls.Add(this.label1);
            this.gbValor.Controls.Add(this.txtprecofinal);
            this.gbValor.Controls.Add(this.txtprecoinicial);
            this.gbValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValor.Location = new System.Drawing.Point(14, 87);
            this.gbValor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbValor.Name = "gbValor";
            this.gbValor.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbValor.Size = new System.Drawing.Size(250, 88);
            this.gbValor.TabIndex = 0;
            this.gbValor.TabStop = false;
            this.gbValor.Text = "Valores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "De:";
            // 
            // txtprecofinal
            // 
            this.txtprecofinal.Location = new System.Drawing.Point(165, 40);
            this.txtprecofinal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtprecofinal.MaxLength = 6;
            this.txtprecofinal.Name = "txtprecofinal";
            this.txtprecofinal.Size = new System.Drawing.Size(66, 26);
            this.txtprecofinal.TabIndex = 15;
            this.txtprecofinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecofinal_KeyPress);
            // 
            // txtprecoinicial
            // 
            this.txtprecoinicial.Location = new System.Drawing.Point(45, 40);
            this.txtprecoinicial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtprecoinicial.MaxLength = 6;
            this.txtprecoinicial.Name = "txtprecoinicial";
            this.txtprecoinicial.Size = new System.Drawing.Size(66, 26);
            this.txtprecoinicial.TabIndex = 14;
            this.txtprecoinicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecoinicial_KeyPress);
            // 
            // formConsultaLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 659);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formConsultaLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Livro";
            this.Load += new System.EventHandler(this.formConsultaLivro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFornecedor.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbValor.ResumeLayout(false);
            this.gbValor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbValor;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprecofinal;
        private System.Windows.Forms.TextBox txtprecoinicial;
    }
}