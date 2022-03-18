
namespace livrarianerds
{
    partial class formRelVendaSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelVendaSimples));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btGerarRel = new System.Windows.Forms.Button();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.gbPeriodoVenda = new System.Windows.Forms.GroupBox();
            this.dtpDateAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.rptVendaSimples = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classPedidoBindingSource)).BeginInit();
            this.gbFuncionario.SuspendLayout();
            this.gbPeriodoVenda.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // classPedidoBindingSource
            // 
            this.classPedidoBindingSource.DataSource = typeof(livrarianerds.classPedido);
            // 
            // btGerarRel
            // 
            this.btGerarRel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRel.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRel.Image")));
            this.btGerarRel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRel.Location = new System.Drawing.Point(549, 23);
            this.btGerarRel.Name = "btGerarRel";
            this.btGerarRel.Size = new System.Drawing.Size(197, 43);
            this.btGerarRel.TabIndex = 3;
            this.btGerarRel.Text = "     Gerar Relatorio";
            this.btGerarRel.UseVisualStyleBackColor = true;
            this.btGerarRel.Click += new System.EventHandler(this.btGerarRel_Click);
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(273, 32);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(241, 27);
            this.cbTipoRel.TabIndex = 5;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione um Tipo de Relatorio";
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionario.Location = new System.Drawing.Point(405, 191);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(286, 81);
            this.gbFuncionario.TabIndex = 7;
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
            // gbPeriodoVenda
            // 
            this.gbPeriodoVenda.Controls.Add(this.dtpDateAte);
            this.gbPeriodoVenda.Controls.Add(this.dtpDateDe);
            this.gbPeriodoVenda.Controls.Add(this.label2);
            this.gbPeriodoVenda.Controls.Add(this.label1);
            this.gbPeriodoVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriodoVenda.Location = new System.Drawing.Point(36, 112);
            this.gbPeriodoVenda.Name = "gbPeriodoVenda";
            this.gbPeriodoVenda.Size = new System.Drawing.Size(242, 145);
            this.gbPeriodoVenda.TabIndex = 8;
            this.gbPeriodoVenda.TabStop = false;
            this.gbPeriodoVenda.Text = "Periodo de Venda";
            // 
            // dtpDateAte
            // 
            this.dtpDateAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAte.Location = new System.Drawing.Point(64, 93);
            this.dtpDateAte.Name = "dtpDateAte";
            this.dtpDateAte.Size = new System.Drawing.Size(134, 26);
            this.dtpDateAte.TabIndex = 3;
            // 
            // dtpDateDe
            // 
            this.dtpDateDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDe.Location = new System.Drawing.Point(64, 35);
            this.dtpDateDe.Name = "dtpDateDe";
            this.dtpDateDe.Size = new System.Drawing.Size(134, 26);
            this.dtpDateDe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
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
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cbCliente);
            this.gbCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(405, 91);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(286, 81);
            this.gbCliente.TabIndex = 8;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(17, 39);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(239, 27);
            this.cbCliente.TabIndex = 0;
            // 
            // rptVendaSimples
            // 
            reportDataSource2.Name = "dtVendaSimples";
            reportDataSource2.Value = this.classPedidoBindingSource;
            this.rptVendaSimples.LocalReport.DataSources.Add(reportDataSource2);
            this.rptVendaSimples.LocalReport.ReportEmbeddedResource = "livrarianerds.rptVendaSimples.rdlc";
            this.rptVendaSimples.Location = new System.Drawing.Point(12, 296);
            this.rptVendaSimples.Name = "rptVendaSimples";
            this.rptVendaSimples.ServerReport.BearerToken = null;
            this.rptVendaSimples.Size = new System.Drawing.Size(747, 364);
            this.rptVendaSimples.TabIndex = 9;
            // 
            // formRelVendaSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 672);
            this.Controls.Add(this.rptVendaSimples);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.gbPeriodoVenda);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.btGerarRel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelVendaSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Venda Simples";
            this.Load += new System.EventHandler(this.formRelVendaSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classPedidoBindingSource)).EndInit();
            this.gbFuncionario.ResumeLayout(false);
            this.gbPeriodoVenda.ResumeLayout(false);
            this.gbPeriodoVenda.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGerarRel;
        private System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.GroupBox gbPeriodoVenda;
        private System.Windows.Forms.DateTimePicker dtpDateAte;
        private System.Windows.Forms.DateTimePicker dtpDateDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private Microsoft.Reporting.WinForms.ReportViewer rptVendaSimples;
        private System.Windows.Forms.BindingSource classPedidoBindingSource;
    }
}