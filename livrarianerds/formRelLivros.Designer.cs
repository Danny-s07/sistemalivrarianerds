namespace livrarianerds
{
    partial class formRelLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelLivros));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classLivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.btGerarRelat = new System.Windows.Forms.Button();
            this.gbPreco = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAte = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rptLivros = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classLivrosBindingSource)).BeginInit();
            this.gbPreco.SuspendLayout();
            this.gbFornecedor.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // classLivrosBindingSource
            // 
            this.classLivrosBindingSource.DataSource = typeof(livrarianerds.classLivros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Tipo de Relatorio";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(250, 27);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(209, 27);
            this.cbTipoRel.TabIndex = 1;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // btGerarRelat
            // 
            this.btGerarRelat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelat.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelat.Image")));
            this.btGerarRelat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelat.Location = new System.Drawing.Point(512, 19);
            this.btGerarRelat.Name = "btGerarRelat";
            this.btGerarRelat.Size = new System.Drawing.Size(175, 40);
            this.btGerarRelat.TabIndex = 2;
            this.btGerarRelat.Text = "     Gerar Relatorio";
            this.btGerarRelat.UseVisualStyleBackColor = true;
            this.btGerarRelat.Click += new System.EventHandler(this.btGerarRelat_Click);
            // 
            // gbPreco
            // 
            this.gbPreco.Controls.Add(this.label3);
            this.gbPreco.Controls.Add(this.label2);
            this.gbPreco.Controls.Add(this.txtAte);
            this.gbPreco.Controls.Add(this.txtDe);
            this.gbPreco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreco.Location = new System.Drawing.Point(22, 81);
            this.gbPreco.Name = "gbPreco";
            this.gbPreco.Size = new System.Drawing.Size(153, 100);
            this.gbPreco.TabIndex = 3;
            this.gbPreco.TabStop = false;
            this.gbPreco.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Até :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "De :";
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(54, 59);
            this.txtAte.MaxLength = 6;
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(67, 26);
            this.txtAte.TabIndex = 1;
            this.txtAte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAte_KeyPress);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(54, 26);
            this.txtDe.MaxLength = 6;
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(67, 26);
            this.txtDe.TabIndex = 0;
            this.txtDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDe_KeyPress);
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.cbFornecedor);
            this.gbFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFornecedor.Location = new System.Drawing.Point(207, 81);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Size = new System.Drawing.Size(200, 59);
            this.gbFornecedor.TabIndex = 4;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(6, 23);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(175, 27);
            this.cbFornecedor.TabIndex = 8;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.Location = new System.Drawing.Point(201, 146);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(200, 64);
            this.gbCategoria.TabIndex = 5;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(6, 26);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(175, 27);
            this.cbCategoria.TabIndex = 9;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(474, 107);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 61);
            this.gbStatus.TabIndex = 6;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(102, 29);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(78, 23);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(6, 29);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(66, 23);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rptLivros
            // 
            reportDataSource1.Name = "dtLivros";
            reportDataSource1.Value = this.classLivrosBindingSource;
            this.rptLivros.LocalReport.DataSources.Add(reportDataSource1);
            this.rptLivros.LocalReport.ReportEmbeddedResource = "livrarianerds.rptLivros.rdlc";
            this.rptLivros.Location = new System.Drawing.Point(12, 230);
            this.rptLivros.Name = "rptLivros";
            this.rptLivros.ServerReport.BearerToken = null;
            this.rptLivros.Size = new System.Drawing.Size(718, 416);
            this.rptLivros.TabIndex = 7;
            // 
            // formRelLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 664);
            this.Controls.Add(this.rptLivros);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.gbFornecedor);
            this.Controls.Add(this.gbPreco);
            this.Controls.Add(this.btGerarRelat);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Livros";
            this.Load += new System.EventHandler(this.formRelLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classLivrosBindingSource)).EndInit();
            this.gbPreco.ResumeLayout(false);
            this.gbPreco.PerformLayout();
            this.gbFornecedor.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Button btGerarRelat;
        private System.Windows.Forms.GroupBox gbPreco;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.GroupBox gbStatus;
        private Microsoft.Reporting.WinForms.ReportViewer rptLivros;
        private System.Windows.Forms.BindingSource classLivrosBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAte;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
    }
}