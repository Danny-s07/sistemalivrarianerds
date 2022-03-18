
namespace livrarianerds
{
    partial class formCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCargo));
            this.btsaircargo = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcodigocargo = new System.Windows.Forms.TextBox();
            this.dt_cargo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ckstatus = new System.Windows.Forms.CheckBox();
            this.lbdata = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btsaircargo
            // 
            this.btsaircargo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsaircargo.Image = ((System.Drawing.Image)(resources.GetObject("btsaircargo.Image")));
            this.btsaircargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsaircargo.Location = new System.Drawing.Point(489, 368);
            this.btsaircargo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btsaircargo.Name = "btsaircargo";
            this.btsaircargo.Size = new System.Drawing.Size(134, 58);
            this.btsaircargo.TabIndex = 2;
            this.btsaircargo.Text = "Sair";
            this.btsaircargo.UseVisualStyleBackColor = true;
            this.btsaircargo.Click += new System.EventHandler(this.btsaircargo_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btexcluir.Image")));
            this.btexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexcluir.Location = new System.Drawing.Point(339, 368);
            this.btexcluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(129, 58);
            this.btexcluir.TabIndex = 104;
            this.btexcluir.Text = "   Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btatualizar.Image = ((System.Drawing.Image)(resources.GetObject("btatualizar.Image")));
            this.btatualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btatualizar.Location = new System.Drawing.Point(174, 368);
            this.btatualizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(137, 58);
            this.btatualizar.TabIndex = 103;
            this.btatualizar.Text = "     Atualizar";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btcadastrar.Image")));
            this.btcadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcadastrar.Location = new System.Drawing.Point(11, 368);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(146, 58);
            this.btcadastrar.TabIndex = 1;
            this.btcadastrar.Text = "    Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(233, 24);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(162, 19);
            this.lbTitulo.TabIndex = 107;
            this.lbTitulo.Text = "Cadastro de Cargos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "*Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(82, 38);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtnome.MaxLength = 50;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(369, 26);
            this.txtnome.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(18, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "*Código do Cargo:";
            // 
            // txtcodigocargo
            // 
            this.txtcodigocargo.Enabled = false;
            this.txtcodigocargo.Location = new System.Drawing.Point(189, 104);
            this.txtcodigocargo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtcodigocargo.Name = "txtcodigocargo";
            this.txtcodigocargo.Size = new System.Drawing.Size(62, 26);
            this.txtcodigocargo.TabIndex = 1;
            // 
            // dt_cargo
            // 
            this.dt_cargo.AutoSize = true;
            this.dt_cargo.Enabled = false;
            this.dt_cargo.Location = new System.Drawing.Point(18, 202);
            this.dt_cargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dt_cargo.Name = "dt_cargo";
            this.dt_cargo.Size = new System.Drawing.Size(130, 19);
            this.dt_cargo.TabIndex = 2;
            this.dt_cargo.Text = "*Data Cadastro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(273, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "*Status:";
            // 
            // ckstatus
            // 
            this.ckstatus.AutoSize = true;
            this.ckstatus.Enabled = false;
            this.ckstatus.Location = new System.Drawing.Point(358, 202);
            this.ckstatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckstatus.Name = "ckstatus";
            this.ckstatus.Size = new System.Drawing.Size(67, 23);
            this.ckstatus.TabIndex = 4;
            this.ckstatus.Text = "Ativo";
            this.ckstatus.UseVisualStyleBackColor = true;
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Enabled = false;
            this.lbdata.Location = new System.Drawing.Point(164, 202);
            this.lbdata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(44, 19);
            this.lbdata.TabIndex = 106;
            this.lbdata.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckstatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbdata);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtcodigocargo);
            this.groupBox1.Controls.Add(this.dt_cargo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 267);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados :";
            // 
            // formCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btsaircargo);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargo";
            this.Load += new System.EventHandler(this.formCargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btsaircargo;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtcodigocargo;
        private System.Windows.Forms.Label dt_cargo;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.CheckBox ckstatus;
        public System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}