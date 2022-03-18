namespace livrarianerds
{
    partial class formRelFornecedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelFornecedores));
            this.classFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptFornecedor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btGerarRelat = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.classLivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classFornecedorBindingSource)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbCidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classLivrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classFornecedorBindingSource
            // 
            this.classFornecedorBindingSource.DataSource = typeof(livrarianerds.classFornecedor);
            // 
            // rptFornecedor
            // 
            reportDataSource1.Name = "dtFornecedores";
            reportDataSource1.Value = this.classFornecedorBindingSource;
            this.rptFornecedor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptFornecedor.LocalReport.ReportEmbeddedResource = "livrarianerds.rptFornecedores.rdlc";
            this.rptFornecedor.Location = new System.Drawing.Point(13, 213);
            this.rptFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.rptFornecedor.Name = "rptFornecedor";
            this.rptFornecedor.ServerReport.BearerToken = null;
            this.rptFornecedor.Size = new System.Drawing.Size(756, 519);
            this.rptFornecedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Tipo de Relatorio";
            // 
            // btGerarRelat
            // 
            this.btGerarRelat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelat.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelat.Image")));
            this.btGerarRelat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelat.Location = new System.Drawing.Point(527, 29);
            this.btGerarRelat.Name = "btGerarRelat";
            this.btGerarRelat.Size = new System.Drawing.Size(186, 42);
            this.btGerarRelat.TabIndex = 2;
            this.btGerarRelat.Text = "    Gerar Relatorio";
            this.btGerarRelat.UseVisualStyleBackColor = true;
            this.btGerarRelat.Click += new System.EventHandler(this.btGerarRelat_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.cbSexo);
            this.gbSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(22, 96);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(200, 100);
            this.gbSexo.TabIndex = 3;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(16, 43);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(167, 27);
            this.cbSexo.TabIndex = 8;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(251, 114);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 70);
            this.gbStatus.TabIndex = 4;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(108, 27);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(78, 23);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(16, 27);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(66, 23);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.cbCidade);
            this.gbCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCidade.Location = new System.Drawing.Point(498, 96);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(200, 100);
            this.gbCidade.TabIndex = 5;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "Cidade:";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(13, 43);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(167, 27);
            this.cbCidade.TabIndex = 7;
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(251, 31);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(234, 27);
            this.cbTipoRel.TabIndex = 6;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // classLivrosBindingSource
            // 
            this.classLivrosBindingSource.DataSource = typeof(livrarianerds.classLivros);
            // 
            // formRelFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 745);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.gbCidade);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.btGerarRelat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptFornecedor);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Fornecedores";
            this.Load += new System.EventHandler(this.formRelFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classFornecedorBindingSource)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbCidade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classLivrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFornecedor;
        private System.Windows.Forms.BindingSource classFornecedorBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGerarRelat;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.BindingSource classLivrosBindingSource;
    }
}