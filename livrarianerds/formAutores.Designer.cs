namespace livrarianerds
{
    partial class formAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAutores));
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.mskcelular = new System.Windows.Forms.MaskedTextBox();
            this.msktelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckStatus = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(11, 450);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(137, 58);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "    Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizar.Location = new System.Drawing.Point(159, 452);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(134, 55);
            this.btAtualizar.TabIndex = 1;
            this.btAtualizar.Text = "    Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(306, 452);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(131, 55);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "  Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(445, 452);
            this.btSair.Margin = new System.Windows.Forms.Padding(4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(129, 58);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(231, 33);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(165, 19);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "Cadastro de Autores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rbf);
            this.groupBox1.Controls.Add(this.rbm);
            this.groupBox1.Controls.Add(this.mskcelular);
            this.groupBox1.Controls.Add(this.msktelefone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(565, 299);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sexo:";
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Checked = true;
            this.rbf.Location = new System.Drawing.Point(311, 146);
            this.rbf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(98, 23);
            this.rbf.TabIndex = 4;
            this.rbf.TabStop = true;
            this.rbf.Text = "Feminino";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(425, 146);
            this.rbm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(105, 23);
            this.rbm.TabIndex = 5;
            this.rbm.Text = "Masculino";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // mskcelular
            // 
            this.mskcelular.Location = new System.Drawing.Point(386, 88);
            this.mskcelular.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskcelular.Mask = "(00) 00000-0000";
            this.mskcelular.Name = "mskcelular";
            this.mskcelular.Size = new System.Drawing.Size(127, 26);
            this.mskcelular.TabIndex = 2;
            // 
            // msktelefone
            // 
            this.msktelefone.Location = new System.Drawing.Point(95, 141);
            this.msktelefone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.msktelefone.Mask = "(00) 0000-0000";
            this.msktelefone.Name = "msktelefone";
            this.msktelefone.Size = new System.Drawing.Size(116, 26);
            this.msktelefone.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "*Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "*Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-mail:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(69, 84);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(227, 26);
            this.txtemail.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(81, 38);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnome.MaxLength = 50;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(408, 26);
            this.txtnome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "* Nome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbdata);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 219);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 62);
            this.panel1.TabIndex = 0;
            // 
            // ckStatus
            // 
            this.ckStatus.AutoSize = true;
            this.ckStatus.Enabled = false;
            this.ckStatus.Location = new System.Drawing.Point(481, 22);
            this.ckStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckStatus.Name = "ckStatus";
            this.ckStatus.Size = new System.Drawing.Size(67, 23);
            this.ckStatus.TabIndex = 5;
            this.ckStatus.Text = "Ativo";
            this.ckStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(411, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "*Status:";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Enabled = false;
            this.lbdata.Location = new System.Drawing.Point(324, 21);
            this.lbdata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(44, 19);
            this.lbdata.TabIndex = 3;
            this.lbdata.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(201, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Data Cadastro :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(126, 19);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(58, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "* Codigo Autor :";
            // 
            // formAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.formAutores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.CheckBox ckStatus;
        public System.Windows.Forms.Label lbdata;
        public System.Windows.Forms.MaskedTextBox mskcelular;
        public System.Windows.Forms.MaskedTextBox msktelefone;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.RadioButton rbf;
        public System.Windows.Forms.RadioButton rbm;
    }
}