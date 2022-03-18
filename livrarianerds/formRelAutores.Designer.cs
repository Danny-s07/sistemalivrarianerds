namespace livrarianerds
{
    partial class formRelAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelAutores));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classAutoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.btGerarRelat = new System.Windows.Forms.Button();
            this.rptAutor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbDataCadastro = new System.Windows.Forms.GroupBox();
            this.mskAte = new System.Windows.Forms.MaskedTextBox();
            this.mskDe = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classAutoresBindingSource)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbDataCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // classAutoresBindingSource
            // 
            this.classAutoresBindingSource.DataSource = typeof(livrarianerds.classAutores);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o Tipo de Relatorio";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(252, 23);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(234, 27);
            this.cbTipoRel.TabIndex = 7;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // btGerarRelat
            // 
            this.btGerarRelat.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelat.Image")));
            this.btGerarRelat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelat.Location = new System.Drawing.Point(523, 19);
            this.btGerarRelat.Name = "btGerarRelat";
            this.btGerarRelat.Size = new System.Drawing.Size(179, 42);
            this.btGerarRelat.TabIndex = 8;
            this.btGerarRelat.Text = "  Gerar Relatorio";
            this.btGerarRelat.UseVisualStyleBackColor = true;
            this.btGerarRelat.Click += new System.EventHandler(this.btGerarRelat_Click);
            // 
            // rptAutor
            // 
            reportDataSource1.Name = "dtAutor";
            reportDataSource1.Value = this.classAutoresBindingSource;
            this.rptAutor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptAutor.LocalReport.ReportEmbeddedResource = "livrarianerds.rptAutor.rdlc";
            this.rptAutor.Location = new System.Drawing.Point(17, 200);
            this.rptAutor.Name = "rptAutor";
            this.rptAutor.ServerReport.BearerToken = null;
            this.rptAutor.Size = new System.Drawing.Size(685, 419);
            this.rptAutor.TabIndex = 9;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.cbSexo);
            this.gbSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(22, 80);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(200, 98);
            this.gbSexo.TabIndex = 10;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(20, 38);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(148, 27);
            this.cbSexo.TabIndex = 0;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(263, 80);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 98);
            this.gbStatus.TabIndex = 11;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(105, 47);
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
            this.rbAtivo.Location = new System.Drawing.Point(19, 47);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(66, 23);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbDataCadastro
            // 
            this.gbDataCadastro.Controls.Add(this.mskAte);
            this.gbDataCadastro.Controls.Add(this.mskDe);
            this.gbDataCadastro.Controls.Add(this.label3);
            this.gbDataCadastro.Controls.Add(this.label2);
            this.gbDataCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataCadastro.Location = new System.Drawing.Point(506, 80);
            this.gbDataCadastro.Name = "gbDataCadastro";
            this.gbDataCadastro.Size = new System.Drawing.Size(169, 100);
            this.gbDataCadastro.TabIndex = 12;
            this.gbDataCadastro.TabStop = false;
            this.gbDataCadastro.Text = "Data Cadastro";
            // 
            // mskAte
            // 
            this.mskAte.Location = new System.Drawing.Point(49, 64);
            this.mskAte.Mask = "00/00/0000";
            this.mskAte.Name = "mskAte";
            this.mskAte.Size = new System.Drawing.Size(88, 26);
            this.mskAte.TabIndex = 5;
            this.mskAte.ValidatingType = typeof(System.DateTime);
            // 
            // mskDe
            // 
            this.mskDe.Location = new System.Drawing.Point(49, 31);
            this.mskDe.Mask = "00/00/0000";
            this.mskDe.Name = "mskDe";
            this.mskDe.Size = new System.Drawing.Size(89, 26);
            this.mskDe.TabIndex = 4;
            this.mskDe.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Até:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "De:";
            // 
            // formRelAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 631);
            this.Controls.Add(this.gbDataCadastro);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.rptAutor);
            this.Controls.Add(this.btGerarRelat);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Autores";
            this.Load += new System.EventHandler(this.formRelAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classAutoresBindingSource)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbDataCadastro.ResumeLayout(false);
            this.gbDataCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Button btGerarRelat;
        private Microsoft.Reporting.WinForms.ReportViewer rptAutor;
        private System.Windows.Forms.BindingSource classAutoresBindingSource;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbDataCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskAte;
        private System.Windows.Forms.MaskedTextBox mskDe;
    }
}