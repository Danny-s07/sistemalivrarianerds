
namespace livrarianerds
{
    partial class formRelVendaCompleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelVendaCompleto));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classRelVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbPeriodoVenda = new System.Windows.Forms.GroupBox();
            this.dtpDateAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.btGerarRel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.rptVendaCompleta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.classRelVendaBindingSource)).BeginInit();
            this.gbPeriodoVenda.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // classRelVendaBindingSource
            // 
            this.classRelVendaBindingSource.DataSource = typeof(livrarianerds.classRelVenda);
            // 
            // gbPeriodoVenda
            // 
            this.gbPeriodoVenda.Controls.Add(this.dtpDateAte);
            this.gbPeriodoVenda.Controls.Add(this.dtpDateDe);
            this.gbPeriodoVenda.Controls.Add(this.label2);
            this.gbPeriodoVenda.Controls.Add(this.label1);
            this.gbPeriodoVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriodoVenda.Location = new System.Drawing.Point(12, 95);
            this.gbPeriodoVenda.Name = "gbPeriodoVenda";
            this.gbPeriodoVenda.Size = new System.Drawing.Size(238, 158);
            this.gbPeriodoVenda.TabIndex = 0;
            this.gbPeriodoVenda.TabStop = false;
            this.gbPeriodoVenda.Text = "Periodo de Venda";
            // 
            // dtpDateAte
            // 
            this.dtpDateAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAte.Location = new System.Drawing.Point(63, 101);
            this.dtpDateAte.Name = "dtpDateAte";
            this.dtpDateAte.Size = new System.Drawing.Size(159, 26);
            this.dtpDateAte.TabIndex = 3;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(64, 35);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(159, 26);
            this.dtpDateDe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionario.Location = new System.Drawing.Point(286, 82);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(286, 81);
            this.gbFuncionario.TabIndex = 1;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionario";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(17, 39);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(239, 27);
            this.cbFuncionario.TabIndex = 0;
            // 
            // btGerarRel
            // 
            this.btGerarRel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRel.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRel.Image")));
            this.btGerarRel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRel.Location = new System.Drawing.Point(529, 18);
            this.btGerarRel.Name = "btGerarRel";
            this.btGerarRel.Size = new System.Drawing.Size(197, 43);
            this.btGerarRel.TabIndex = 2;
            this.btGerarRel.Text = "     Gerar Relatorio";
            this.btGerarRel.UseVisualStyleBackColor = true;
            this.btGerarRel.Click += new System.EventHandler(this.btGerarRel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selecione um Tipo de Relatorio";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(265, 27);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(241, 27);
            this.cbTipoRel.TabIndex = 4;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // rptVendaCompleta
            // 
            reportDataSource1.Name = "dsRelVendaCompleto";
            reportDataSource1.Value = this.classRelVendaBindingSource;
            this.rptVendaCompleta.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVendaCompleta.LocalReport.ReportEmbeddedResource = "livrarianerds.rptVendaCompleto.rdlc";
            this.rptVendaCompleta.Location = new System.Drawing.Point(12, 270);
            this.rptVendaCompleta.Name = "rptVendaCompleta";
            this.rptVendaCompleta.ServerReport.BearerToken = null;
            this.rptVendaCompleta.Size = new System.Drawing.Size(706, 372);
            this.rptVendaCompleta.TabIndex = 5;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cbCliente);
            this.gbCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(286, 183);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(286, 81);
            this.gbCliente.TabIndex = 6;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(17, 34);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(239, 27);
            this.cbCliente.TabIndex = 1;
            // 
            // formRelVendaCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 654);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.rptVendaCompleta);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGerarRel);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.gbPeriodoVenda);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelVendaCompleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Venda Completo";
            this.Load += new System.EventHandler(this.formRelVendaCompleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classRelVendaBindingSource)).EndInit();
            this.gbPeriodoVenda.ResumeLayout(false);
            this.gbPeriodoVenda.PerformLayout();
            this.gbFuncionario.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPeriodoVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Button btGerarRel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private Microsoft.Reporting.WinForms.ReportViewer rptVendaCompleta;
        private System.Windows.Forms.BindingSource classRelVendaBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.DateTimePicker dtpDateAte;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbCliente;
    }
}