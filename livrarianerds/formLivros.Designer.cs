namespace livrarianerds
{
    partial class formLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLivros));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbautor = new System.Windows.Forms.ComboBox();
            this.txtqtestoque = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckStatus = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(249, 22);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(154, 19);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Cadastro de Livros";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(13, 404);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(147, 58);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizar.Location = new System.Drawing.Point(168, 404);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(140, 58);
            this.btAtualizar.TabIndex = 9;
            this.btAtualizar.Text = "  Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(327, 404);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(142, 58);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(477, 404);
            this.btSair.Margin = new System.Windows.Forms.Padding(4);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(141, 58);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbautor);
            this.groupBox1.Controls.Add(this.txtqtestoque);
            this.groupBox1.Controls.Add(this.txtpreco);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbcategoria);
            this.groupBox1.Controls.Add(this.cbfornecedor);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(609, 289);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "*Autor :";
            // 
            // cbautor
            // 
            this.cbautor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbautor.FormattingEnabled = true;
            this.cbautor.Location = new System.Drawing.Point(384, 182);
            this.cbautor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbautor.Name = "cbautor";
            this.cbautor.Size = new System.Drawing.Size(98, 27);
            this.cbautor.TabIndex = 13;
            // 
            // txtqtestoque
            // 
            this.txtqtestoque.Location = new System.Drawing.Point(191, 108);
            this.txtqtestoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtqtestoque.MaxLength = 4;
            this.txtqtestoque.Name = "txtqtestoque";
            this.txtqtestoque.Size = new System.Drawing.Size(106, 26);
            this.txtqtestoque.TabIndex = 2;
            this.txtqtestoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtestoque_KeyPress);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(390, 108);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtpreco.MaxLength = 6;
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(96, 26);
            this.txtpreco.TabIndex = 3;
            this.txtpreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreco_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "*Preço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "* Quantidade Estoque :";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(119, 49);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnome.MaxLength = 35;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(263, 26);
            this.txtnome.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "* Nome Livro :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "*Categoria :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "*Fornecedor :";
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(498, 49);
            this.cbcategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(98, 27);
            this.cbcategoria.TabIndex = 1;
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(133, 182);
            this.cbfornecedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(98, 27);
            this.cbfornecedor.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbdata);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 234);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 40);
            this.panel1.TabIndex = 1;
            // 
            // ckStatus
            // 
            this.ckStatus.AutoSize = true;
            this.ckStatus.Enabled = false;
            this.ckStatus.Location = new System.Drawing.Point(528, 11);
            this.ckStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckStatus.Name = "ckStatus";
            this.ckStatus.Size = new System.Drawing.Size(67, 23);
            this.ckStatus.TabIndex = 7;
            this.ckStatus.Text = "Ativo";
            this.ckStatus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(460, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "*Status:";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Enabled = false;
            this.lbdata.Location = new System.Drawing.Point(367, 12);
            this.lbdata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(44, 19);
            this.lbdata.TabIndex = 5;
            this.lbdata.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(230, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Data Cadastro :";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(144, 6);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(58, 26);
            this.txtcodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "* Codigo Livro :";
            // 
            // formLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbTitulo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.formLivro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox ckStatus;
        public System.Windows.Forms.Label lbdata;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox txtpreco;
        public System.Windows.Forms.TextBox txtnome;
        public System.Windows.Forms.ComboBox cbcategoria;
        public System.Windows.Forms.ComboBox cbfornecedor;
        public System.Windows.Forms.TextBox txtqtestoque;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbautor;
    }
}