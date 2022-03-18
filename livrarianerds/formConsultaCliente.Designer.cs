namespace livrarianerds
{
    partial class formConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConsultaCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.gbtipopesquisa = new System.Windows.Forms.GroupBox();
            this.rbcontem = new System.Windows.Forms.RadioButton();
            this.rbinicio = new System.Windows.Forms.RadioButton();
            this.btsair = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.cbopcoes = new System.Windows.Forms.ComboBox();
            this.gbcpf = new System.Windows.Forms.GroupBox();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.gbstatus.SuspendLayout();
            this.gbsexo.SuspendLayout();
            this.gbtipopesquisa.SuspendLayout();
            this.gbcpf.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvcliente);
            this.groupBox1.Controls.Add(this.gbstatus);
            this.groupBox1.Controls.Add(this.gbsexo);
            this.groupBox1.Controls.Add(this.gbtipopesquisa);
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(this.txtpesquisar);
            this.groupBox1.Controls.Add(this.cbopcoes);
            this.groupBox1.Controls.Add(this.gbcpf);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 567);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Tipo de Consulta";
            // 
            // dgvcliente
            // 
            this.dgvcliente.AllowUserToAddRows = false;
            this.dgvcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(12, 229);
            this.dgvcliente.Margin = new System.Windows.Forms.Padding(5);
            this.dgvcliente.MultiSelect = false;
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.ReadOnly = true;
            this.dgvcliente.RowHeadersVisible = false;
            this.dgvcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcliente.Size = new System.Drawing.Size(842, 319);
            this.dgvcliente.TabIndex = 11;
            this.dgvcliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcliente_CellClick);
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.rbinativo);
            this.gbstatus.Controls.Add(this.rbativo);
            this.gbstatus.Enabled = false;
            this.gbstatus.Location = new System.Drawing.Point(459, 117);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Size = new System.Drawing.Size(202, 61);
            this.gbstatus.TabIndex = 7;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Status:";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(110, 30);
            this.rbinativo.Name = "rbinativo";
            this.rbinativo.Size = new System.Drawing.Size(78, 23);
            this.rbinativo.TabIndex = 1;
            this.rbinativo.Text = "Inativo";
            this.rbinativo.UseVisualStyleBackColor = true;
            // 
            // rbativo
            // 
            this.rbativo.AutoSize = true;
            this.rbativo.Checked = true;
            this.rbativo.Location = new System.Drawing.Point(6, 30);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(66, 23);
            this.rbativo.TabIndex = 0;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // gbsexo
            // 
            this.gbsexo.Controls.Add(this.rbm);
            this.gbsexo.Controls.Add(this.rbf);
            this.gbsexo.Enabled = false;
            this.gbsexo.Location = new System.Drawing.Point(226, 117);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Size = new System.Drawing.Size(227, 61);
            this.gbsexo.TabIndex = 6;
            this.gbsexo.TabStop = false;
            this.gbsexo.Text = "Sexo:";
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(110, 30);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(105, 23);
            this.rbm.TabIndex = 1;
            this.rbm.Text = "Masculino";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Checked = true;
            this.rbf.Location = new System.Drawing.Point(6, 30);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(98, 23);
            this.rbf.TabIndex = 0;
            this.rbf.TabStop = true;
            this.rbf.Text = "Feminino";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // gbtipopesquisa
            // 
            this.gbtipopesquisa.Controls.Add(this.rbcontem);
            this.gbtipopesquisa.Controls.Add(this.rbinicio);
            this.gbtipopesquisa.Location = new System.Drawing.Point(6, 108);
            this.gbtipopesquisa.Name = "gbtipopesquisa";
            this.gbtipopesquisa.Size = new System.Drawing.Size(200, 71);
            this.gbtipopesquisa.TabIndex = 5;
            this.gbtipopesquisa.TabStop = false;
            this.gbtipopesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rbcontem
            // 
            this.rbcontem.AutoSize = true;
            this.rbcontem.Location = new System.Drawing.Point(98, 30);
            this.rbcontem.Name = "rbcontem";
            this.rbcontem.Size = new System.Drawing.Size(87, 23);
            this.rbcontem.TabIndex = 1;
            this.rbcontem.Text = "Contem";
            this.rbcontem.UseVisualStyleBackColor = true;
            // 
            // rbinicio
            // 
            this.rbinicio.AutoSize = true;
            this.rbinicio.Checked = true;
            this.rbinicio.Location = new System.Drawing.Point(6, 30);
            this.rbinicio.Name = "rbinicio";
            this.rbinicio.Size = new System.Drawing.Size(68, 23);
            this.rbinicio.TabIndex = 0;
            this.rbinicio.TabStop = true;
            this.rbinicio.Text = "Inicio";
            this.rbinicio.UseVisualStyleBackColor = true;
            // 
            // btsair
            // 
            this.btsair.Image = ((System.Drawing.Image)(resources.GetObject("btsair.Image")));
            this.btsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsair.Location = new System.Drawing.Point(689, 182);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(144, 43);
            this.btsair.TabIndex = 4;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btpesquisar.Image")));
            this.btpesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btpesquisar.Location = new System.Drawing.Point(689, 117);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(144, 43);
            this.btpesquisar.TabIndex = 3;
            this.btpesquisar.Text = "    Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(240, 54);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(390, 26);
            this.txtpesquisar.TabIndex = 1;
            // 
            // cbopcoes
            // 
            this.cbopcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopcoes.FormattingEnabled = true;
            this.cbopcoes.Location = new System.Drawing.Point(6, 53);
            this.cbopcoes.Name = "cbopcoes";
            this.cbopcoes.Size = new System.Drawing.Size(195, 27);
            this.cbopcoes.TabIndex = 0;
            this.cbopcoes.SelectedIndexChanged += new System.EventHandler(this.cbopcoes_SelectedIndexChanged);
            // 
            // gbcpf
            // 
            this.gbcpf.Controls.Add(this.mskcpf);
            this.gbcpf.Location = new System.Drawing.Point(668, 16);
            this.gbcpf.Name = "gbcpf";
            this.gbcpf.Size = new System.Drawing.Size(179, 79);
            this.gbcpf.TabIndex = 12;
            this.gbcpf.TabStop = false;
            this.gbcpf.Text = "CPF";
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(13, 37);
            this.mskcpf.Mask = "000,000,000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(152, 26);
            this.mskcpf.TabIndex = 2;
            // 
            // formConsultaCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(876, 591);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.formConsultaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.gbstatus.ResumeLayout(false);
            this.gbstatus.PerformLayout();
            this.gbsexo.ResumeLayout(false);
            this.gbsexo.PerformLayout();
            this.gbtipopesquisa.ResumeLayout(false);
            this.gbtipopesquisa.PerformLayout();
            this.gbcpf.ResumeLayout(false);
            this.gbcpf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.GroupBox gbstatus;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.GroupBox gbsexo;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.GroupBox gbtipopesquisa;
        private System.Windows.Forms.RadioButton rbcontem;
        private System.Windows.Forms.RadioButton rbinicio;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.ComboBox cbopcoes;
        private System.Windows.Forms.GroupBox gbcpf;
    }
}