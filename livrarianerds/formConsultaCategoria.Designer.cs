
namespace livrarianerds
{
    partial class formConsultaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConsultaCategoria));
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.gbTipoPesquisa.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(279, 126);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(155, 59);
            this.btPesquisar.TabIndex = 22;
            this.btPesquisar.Text = "    Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(476, 126);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(151, 59);
            this.btSair.TabIndex = 21;
            this.btSair.Text = " Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(12, 237);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(696, 227);
            this.dgvCategoria.TabIndex = 20;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbContem);
            this.gbTipoPesquisa.Controls.Add(this.rbInicio);
            this.gbTipoPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPesquisa.Location = new System.Drawing.Point(432, 26);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(223, 66);
            this.gbTipoPesquisa.TabIndex = 17;
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
            this.txtPesquisa.Location = new System.Drawing.Point(168, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(224, 27);
            this.txtPesquisa.TabIndex = 16;
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(24, 41);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(121, 27);
            this.cbOpcoes.TabIndex = 15;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(24, 113);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(223, 88);
            this.gbStatus.TabIndex = 23;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbTipoPesquisa);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 476);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione  um Tipo de Consulta";
            // 
            // formConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 490);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cbOpcoes);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formConsultaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categoria";
            this.Load += new System.EventHandler(this.formConsultacategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}