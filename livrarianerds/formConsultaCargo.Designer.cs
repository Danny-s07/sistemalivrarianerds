namespace livrarianerds
{
    partial class formConsultaCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConsultaCargo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvcargos = new System.Windows.Forms.DataGridView();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gbtipopesquisa = new System.Windows.Forms.GroupBox();
            this.rbcontem = new System.Windows.Forms.RadioButton();
            this.rbinicio = new System.Windows.Forms.RadioButton();
            this.btsair = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.cbopcoes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargos)).BeginInit();
            this.gbstatus.SuspendLayout();
            this.gbtipopesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvcargos);
            this.groupBox1.Controls.Add(this.gbstatus);
            this.groupBox1.Controls.Add(this.gbtipopesquisa);
            this.groupBox1.Controls.Add(this.btsair);
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(this.txtpesquisar);
            this.groupBox1.Controls.Add(this.cbopcoes);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 544);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Tipo de Consulta";
            // 
            // dgvcargos
            // 
            this.dgvcargos.AllowUserToAddRows = false;
            this.dgvcargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvcargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcargos.Location = new System.Drawing.Point(12, 216);
            this.dgvcargos.Margin = new System.Windows.Forms.Padding(5);
            this.dgvcargos.MultiSelect = false;
            this.dgvcargos.Name = "dgvcargos";
            this.dgvcargos.ReadOnly = true;
            this.dgvcargos.RowHeadersVisible = false;
            this.dgvcargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcargos.Size = new System.Drawing.Size(629, 328);
            this.dgvcargos.TabIndex = 11;
            this.dgvcargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcargos_CellClick);
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.rbinativo);
            this.gbstatus.Controls.Add(this.rbativo);
            this.gbstatus.Enabled = false;
            this.gbstatus.Location = new System.Drawing.Point(240, 117);
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
            this.btsair.Location = new System.Drawing.Point(487, 165);
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
            this.btpesquisar.Location = new System.Drawing.Point(487, 99);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(144, 43);
            this.btpesquisar.TabIndex = 3;
            this.btpesquisar.Text = "     Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(240, 54);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(258, 26);
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
            // formConsultaCargo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(665, 577);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formConsultaCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cargo";
            this.Load += new System.EventHandler(this.formConsultaCargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargos)).EndInit();
            this.gbstatus.ResumeLayout(false);
            this.gbstatus.PerformLayout();
            this.gbtipopesquisa.ResumeLayout(false);
            this.gbtipopesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvcargos;
        private System.Windows.Forms.GroupBox gbstatus;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.GroupBox gbtipopesquisa;
        private System.Windows.Forms.RadioButton rbcontem;
        private System.Windows.Forms.RadioButton rbinicio;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.ComboBox cbopcoes;
    }
}