namespace livrarianerds
{
    partial class formConsultaFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConsultaFornecedores));
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbTipoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(17, 33);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(121, 27);
            this.cbOpcoes.TabIndex = 0;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbContem);
            this.gbTipoPesquisa.Controls.Add(this.rbInicio);
            this.gbTipoPesquisa.Location = new System.Drawing.Point(487, 24);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(223, 66);
            this.gbTipoPesquisa.TabIndex = 1;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Location = new System.Drawing.Point(127, 30);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(87, 23);
            this.rbContem.TabIndex = 1;
            this.rbContem.Text = "Contem";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Checked = true;
            this.rbInicio.Location = new System.Drawing.Point(20, 30);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(68, 23);
            this.rbInicio.TabIndex = 0;
            this.rbInicio.TabStop = true;
            this.rbInicio.Text = "Inicio";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(194, 34);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(258, 26);
            this.txtPesquisa.TabIndex = 2;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToResizeRows = false;
            this.dgvFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 314);
            this.dgvFornecedor.MultiSelect = false;
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.RowHeadersVisible = false;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(705, 228);
            this.dgvFornecedor.TabIndex = 3;
            this.dgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellClick);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(13, 220);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(223, 88);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(127, 41);
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
            this.rbAtivo.Location = new System.Drawing.Point(28, 41);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(66, 23);
            this.rbAtivo.TabIndex = 2;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.cbCidade);
            this.gbCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCidade.Location = new System.Drawing.Point(13, 101);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(200, 100);
            this.gbCidade.TabIndex = 5;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "Cidade";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(6, 45);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(166, 27);
            this.cbCidade.TabIndex = 13;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbm);
            this.gbSexo.Controls.Add(this.rbf);
            this.gbSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(241, 113);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(219, 88);
            this.gbSexo.TabIndex = 6;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(108, 37);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(105, 23);
            this.rbm.TabIndex = 5;
            this.rbm.Text = "Masculino";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Checked = true;
            this.rbf.Location = new System.Drawing.Point(6, 37);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(98, 23);
            this.rbf.TabIndex = 4;
            this.rbf.TabStop = true;
            this.rbf.Text = "Feminino";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(520, 136);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(155, 59);
            this.btPesquisar.TabIndex = 11;
            this.btPesquisar.Text = "    Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(520, 225);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(151, 59);
            this.btSair.TabIndex = 12;
            this.btSair.Text = " Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbTipoPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.cbOpcoes);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 540);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Tipo de Consulta";
            // 
            // formConsultaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 554);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbCidade);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formConsultaFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Fornecedores";
            this.Load += new System.EventHandler(this.formConsultaFornecedores_Load);
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbCidade.ResumeLayout(false);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}