namespace livrarianerds
{
    partial class formRelFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelFuncionario));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classfuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btgerarRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.gbcidade = new System.Windows.Forms.GroupBox();
            this.cbcidade = new System.Windows.Forms.ComboBox();
            this.gbsexo = new System.Windows.Forms.GroupBox();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            this.rbinativo = new System.Windows.Forms.RadioButton();
            this.rbativo = new System.Windows.Forms.RadioButton();
            this.gbidade = new System.Windows.Forms.GroupBox();
            this.txtAte = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbaniversariantes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmes = new System.Windows.Forms.ComboBox();
            this.cbdia = new System.Windows.Forms.ComboBox();
            this.rptfuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classfuncionarioBindingSource)).BeginInit();
            this.gbcidade.SuspendLayout();
            this.gbsexo.SuspendLayout();
            this.gbstatus.SuspendLayout();
            this.gbidade.SuspendLayout();
            this.gbaniversariantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // classfuncionarioBindingSource
            // 
            this.classfuncionarioBindingSource.DataSource = typeof(livrarianerds.classFuncionario);
            // 
            // btgerarRelatorio
            // 
            this.btgerarRelatorio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btgerarRelatorio.Image")));
            this.btgerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btgerarRelatorio.Location = new System.Drawing.Point(626, 29);
            this.btgerarRelatorio.Name = "btgerarRelatorio";
            this.btgerarRelatorio.Size = new System.Drawing.Size(179, 42);
            this.btgerarRelatorio.TabIndex = 26;
            this.btgerarRelatorio.Text = "       Gerar   Relatorio\r\n";
            this.btgerarRelatorio.UseVisualStyleBackColor = true;
            this.btgerarRelatorio.Click += new System.EventHandler(this.btgerarRelatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Selecione o Tipo de Relatorio:";
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(261, 42);
            this.cbtipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(346, 27);
            this.cbtipo.TabIndex = 24;
            this.cbtipo.SelectedIndexChanged += new System.EventHandler(this.cbtipo_SelectedIndexChanged);
            // 
            // gbcidade
            // 
            this.gbcidade.Controls.Add(this.cbcidade);
            this.gbcidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcidade.Location = new System.Drawing.Point(557, 170);
            this.gbcidade.Margin = new System.Windows.Forms.Padding(4);
            this.gbcidade.Name = "gbcidade";
            this.gbcidade.Padding = new System.Windows.Forms.Padding(4);
            this.gbcidade.Size = new System.Drawing.Size(248, 69);
            this.gbcidade.TabIndex = 23;
            this.gbcidade.TabStop = false;
            this.gbcidade.Text = "Cidade";
            // 
            // cbcidade
            // 
            this.cbcidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcidade.FormattingEnabled = true;
            this.cbcidade.Location = new System.Drawing.Point(33, 28);
            this.cbcidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbcidade.Name = "cbcidade";
            this.cbcidade.Size = new System.Drawing.Size(181, 27);
            this.cbcidade.TabIndex = 13;
            // 
            // gbsexo
            // 
            this.gbsexo.Controls.Add(this.cbsexo);
            this.gbsexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsexo.Location = new System.Drawing.Point(557, 89);
            this.gbsexo.Margin = new System.Windows.Forms.Padding(4);
            this.gbsexo.Name = "gbsexo";
            this.gbsexo.Padding = new System.Windows.Forms.Padding(4);
            this.gbsexo.Size = new System.Drawing.Size(248, 73);
            this.gbsexo.TabIndex = 22;
            this.gbsexo.TabStop = false;
            this.gbsexo.Text = "Sexo";
            // 
            // cbsexo
            // 
            this.cbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Location = new System.Drawing.Point(33, 28);
            this.cbsexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(181, 27);
            this.cbsexo.TabIndex = 12;
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.rbinativo);
            this.gbstatus.Controls.Add(this.rbativo);
            this.gbstatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbstatus.Location = new System.Drawing.Point(414, 93);
            this.gbstatus.Margin = new System.Windows.Forms.Padding(4);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Padding = new System.Windows.Forms.Padding(4);
            this.gbstatus.Size = new System.Drawing.Size(115, 146);
            this.gbstatus.TabIndex = 21;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Status";
            // 
            // rbinativo
            // 
            this.rbinativo.AutoSize = true;
            this.rbinativo.Location = new System.Drawing.Point(17, 94);
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
            this.rbativo.Location = new System.Drawing.Point(17, 38);
            this.rbativo.Name = "rbativo";
            this.rbativo.Size = new System.Drawing.Size(66, 23);
            this.rbativo.TabIndex = 0;
            this.rbativo.TabStop = true;
            this.rbativo.Text = "Ativo";
            this.rbativo.UseVisualStyleBackColor = true;
            // 
            // gbidade
            // 
            this.gbidade.Controls.Add(this.txtAte);
            this.gbidade.Controls.Add(this.txtDe);
            this.gbidade.Controls.Add(this.label5);
            this.gbidade.Controls.Add(this.label4);
            this.gbidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbidade.Location = new System.Drawing.Point(280, 93);
            this.gbidade.Margin = new System.Windows.Forms.Padding(4);
            this.gbidade.Name = "gbidade";
            this.gbidade.Padding = new System.Windows.Forms.Padding(4);
            this.gbidade.Size = new System.Drawing.Size(115, 146);
            this.gbidade.TabIndex = 20;
            this.gbidade.TabStop = false;
            this.gbidade.Text = "Idade";
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(45, 87);
            this.txtAte.MaxLength = 3;
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(55, 26);
            this.txtAte.TabIndex = 3;
            this.txtAte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAte_KeyPress);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(45, 43);
            this.txtDe.MaxLength = 3;
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(55, 26);
            this.txtDe.TabIndex = 2;
            this.txtDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDe_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "De:";
            // 
            // gbaniversariantes
            // 
            this.gbaniversariantes.Controls.Add(this.label3);
            this.gbaniversariantes.Controls.Add(this.label2);
            this.gbaniversariantes.Controls.Add(this.cbmes);
            this.gbaniversariantes.Controls.Add(this.cbdia);
            this.gbaniversariantes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbaniversariantes.Location = new System.Drawing.Point(13, 93);
            this.gbaniversariantes.Margin = new System.Windows.Forms.Padding(4);
            this.gbaniversariantes.Name = "gbaniversariantes";
            this.gbaniversariantes.Padding = new System.Windows.Forms.Padding(4);
            this.gbaniversariantes.Size = new System.Drawing.Size(240, 146);
            this.gbaniversariantes.TabIndex = 19;
            this.gbaniversariantes.TabStop = false;
            this.gbaniversariantes.Text = "Aniversariantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mês :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dia :";
            // 
            // cbmes
            // 
            this.cbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmes.FormattingEnabled = true;
            this.cbmes.Location = new System.Drawing.Point(76, 90);
            this.cbmes.Margin = new System.Windows.Forms.Padding(4);
            this.cbmes.Name = "cbmes";
            this.cbmes.Size = new System.Drawing.Size(140, 27);
            this.cbmes.TabIndex = 10;
            // 
            // cbdia
            // 
            this.cbdia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdia.FormattingEnabled = true;
            this.cbdia.Location = new System.Drawing.Point(76, 42);
            this.cbdia.Margin = new System.Windows.Forms.Padding(4);
            this.cbdia.Name = "cbdia";
            this.cbdia.Size = new System.Drawing.Size(140, 27);
            this.cbdia.TabIndex = 9;
            // 
            // rptfuncionario
            // 
            reportDataSource1.Name = "rptvfuncionario";
            reportDataSource1.Value = this.classfuncionarioBindingSource;
            this.rptfuncionario.LocalReport.DataSources.Add(reportDataSource1);
            this.rptfuncionario.LocalReport.ReportEmbeddedResource = "livrarianerds.rptFuncionario.rdlc";
            this.rptfuncionario.Location = new System.Drawing.Point(26, 246);
            this.rptfuncionario.Name = "rptfuncionario";
            this.rptfuncionario.ServerReport.BearerToken = null;
            this.rptfuncionario.Size = new System.Drawing.Size(779, 431);
            this.rptfuncionario.TabIndex = 27;
            // 
            // formRelFuncionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(822, 689);
            this.Controls.Add(this.rptfuncionario);
            this.Controls.Add(this.btgerarRelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.gbcidade);
            this.Controls.Add(this.gbsexo);
            this.Controls.Add(this.gbstatus);
            this.Controls.Add(this.gbidade);
            this.Controls.Add(this.gbaniversariantes);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formRelFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Funcionario";
            this.Load += new System.EventHandler(this.RelFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classfuncionarioBindingSource)).EndInit();
            this.gbcidade.ResumeLayout(false);
            this.gbsexo.ResumeLayout(false);
            this.gbstatus.ResumeLayout(false);
            this.gbstatus.PerformLayout();
            this.gbidade.ResumeLayout(false);
            this.gbidade.PerformLayout();
            this.gbaniversariantes.ResumeLayout(false);
            this.gbaniversariantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btgerarRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.GroupBox gbcidade;
        private System.Windows.Forms.ComboBox cbcidade;
        private System.Windows.Forms.GroupBox gbsexo;
        private System.Windows.Forms.ComboBox cbsexo;
        private System.Windows.Forms.GroupBox gbstatus;
        private System.Windows.Forms.RadioButton rbinativo;
        private System.Windows.Forms.RadioButton rbativo;
        private System.Windows.Forms.GroupBox gbidade;
        private System.Windows.Forms.TextBox txtAte;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbaniversariantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmes;
        private System.Windows.Forms.ComboBox cbdia;
        private Microsoft.Reporting.WinForms.ReportViewer rptfuncionario;
        private System.Windows.Forms.BindingSource classfuncionarioBindingSource;
    }
}