namespace livrarianerds
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuprincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadLivros = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCadFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioVendaCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolbData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerprincipal = new System.Windows.Forms.Timer(this.components);
            this.relatorioVendaSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuprincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuprincipal
            // 
            this.menuprincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuprincipal.Location = new System.Drawing.Point(0, 0);
            this.menuprincipal.Name = "menuprincipal";
            this.menuprincipal.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuprincipal.Size = new System.Drawing.Size(752, 42);
            this.menuprincipal.TabIndex = 0;
            this.menuprincipal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadCliente,
            this.menuCadCargos,
            this.menuCadFuncionarios,
            this.menuCadAutores,
            this.menuCadCategoria,
            this.menuCadLivros,
            this.toolCadFornecedores});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(123, 36);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // menuCadCliente
            // 
            this.menuCadCliente.Name = "menuCadCliente";
            this.menuCadCliente.Size = new System.Drawing.Size(185, 24);
            this.menuCadCliente.Text = "Cliente";
            this.menuCadCliente.Click += new System.EventHandler(this.menuCadCliente_Click);
            // 
            // menuCadCargos
            // 
            this.menuCadCargos.Name = "menuCadCargos";
            this.menuCadCargos.Size = new System.Drawing.Size(185, 24);
            this.menuCadCargos.Text = "Cargos";
            this.menuCadCargos.Click += new System.EventHandler(this.menuCadCargos_Click);
            // 
            // menuCadFuncionarios
            // 
            this.menuCadFuncionarios.Name = "menuCadFuncionarios";
            this.menuCadFuncionarios.Size = new System.Drawing.Size(185, 24);
            this.menuCadFuncionarios.Text = "Funcionarios";
            this.menuCadFuncionarios.Click += new System.EventHandler(this.menuCadFuncionarios_Click);
            // 
            // menuCadAutores
            // 
            this.menuCadAutores.Name = "menuCadAutores";
            this.menuCadAutores.Size = new System.Drawing.Size(185, 24);
            this.menuCadAutores.Text = "Autores";
            this.menuCadAutores.Click += new System.EventHandler(this.menuCadAutores_Click);
            // 
            // menuCadCategoria
            // 
            this.menuCadCategoria.Name = "menuCadCategoria";
            this.menuCadCategoria.Size = new System.Drawing.Size(185, 24);
            this.menuCadCategoria.Text = "Categoria";
            this.menuCadCategoria.Click += new System.EventHandler(this.menuCadCategoria_Click);
            // 
            // menuCadLivros
            // 
            this.menuCadLivros.Name = "menuCadLivros";
            this.menuCadLivros.Size = new System.Drawing.Size(185, 24);
            this.menuCadLivros.Text = "Livros";
            this.menuCadLivros.Click += new System.EventHandler(this.menuCadLivros_Click);
            // 
            // toolCadFornecedores
            // 
            this.toolCadFornecedores.Name = "toolCadFornecedores";
            this.toolCadFornecedores.Size = new System.Drawing.Size(185, 24);
            this.toolCadFornecedores.Text = "Fornecedores";
            this.toolCadFornecedores.Click += new System.EventHandler(this.toolCadFornecedores_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.livroToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.livroToolStripMenuItem.Text = "Livros";
            this.livroToolStripMenuItem.Click += new System.EventHandler(this.livroToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroVendaToolStripMenuItem,
            this.relatorioVendaCompletoToolStripMenuItem,
            this.relatorioVendaSimplesToolStripMenuItem});
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vendasToolStripMenuItem.Image")));
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // cadastroVendaToolStripMenuItem
            // 
            this.cadastroVendaToolStripMenuItem.Name = "cadastroVendaToolStripMenuItem";
            this.cadastroVendaToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.cadastroVendaToolStripMenuItem.Text = "Cadastro Venda";
            this.cadastroVendaToolStripMenuItem.Click += new System.EventHandler(this.cadastroVendaToolStripMenuItem_Click);
            // 
            // relatorioVendaCompletoToolStripMenuItem
            // 
            this.relatorioVendaCompletoToolStripMenuItem.Name = "relatorioVendaCompletoToolStripMenuItem";
            this.relatorioVendaCompletoToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.relatorioVendaCompletoToolStripMenuItem.Text = "Relatorio Venda Completo";
            this.relatorioVendaCompletoToolStripMenuItem.Click += new System.EventHandler(this.relatorioVendaCompletoToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.cargosToolStripMenuItem1,
            this.funcionariosToolStripMenuItem1,
            this.livrosToolStripMenuItem,
            this.categoriaToolStripMenuItem1,
            this.fornecedorToolStripMenuItem,
            this.autoresToolStripMenuItem1});
            this.relatorioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatorioToolStripMenuItem.Image")));
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // cargosToolStripMenuItem1
            // 
            this.cargosToolStripMenuItem1.Name = "cargosToolStripMenuItem1";
            this.cargosToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.cargosToolStripMenuItem1.Text = "Cargos";
            this.cargosToolStripMenuItem1.Click += new System.EventHandler(this.cargosToolStripMenuItem1_Click);
            // 
            // funcionariosToolStripMenuItem1
            // 
            this.funcionariosToolStripMenuItem1.Name = "funcionariosToolStripMenuItem1";
            this.funcionariosToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.funcionariosToolStripMenuItem1.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem1.Click += new System.EventHandler(this.funcionariosToolStripMenuItem1_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.fornecedorToolStripMenuItem.Text = "Fornecedores";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem1
            // 
            this.autoresToolStripMenuItem1.Name = "autoresToolStripMenuItem1";
            this.autoresToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.autoresToolStripMenuItem1.Text = "Autores";
            this.autoresToolStripMenuItem1.Click += new System.EventHandler(this.autoresToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbData,
            this.toolbHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(752, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolbData
            // 
            this.toolbData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbData.Name = "toolbData";
            this.toolbData.Size = new System.Drawing.Size(44, 19);
            this.toolbData.Text = "Data";
            // 
            // toolbHora
            // 
            this.toolbHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbHora.Name = "toolbHora";
            this.toolbHora.Size = new System.Drawing.Size(46, 19);
            this.toolbHora.Text = "Hora";
            // 
            // timerprincipal
            // 
            this.timerprincipal.Enabled = true;
            this.timerprincipal.Tick += new System.EventHandler(this.timerprincipal_Tick);
            // 
            // relatorioVendaSimplesToolStripMenuItem
            // 
            this.relatorioVendaSimplesToolStripMenuItem.Name = "relatorioVendaSimplesToolStripMenuItem";
            this.relatorioVendaSimplesToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.relatorioVendaSimplesToolStripMenuItem.Text = "Relatorio Venda Simples";
            this.relatorioVendaSimplesToolStripMenuItem.Click += new System.EventHandler(this.relatorioVendaSimplesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 485);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuprincipal);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuprincipal;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuprincipal.ResumeLayout(false);
            this.menuprincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuprincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadCargos;
        private System.Windows.Forms.ToolStripMenuItem menuCadFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuCadAutores;
        private System.Windows.Forms.ToolStripMenuItem menuCadCategoria;
        private System.Windows.Forms.ToolStripMenuItem menuCadLivros;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolbData;
        private System.Windows.Forms.ToolStripStatusLabel toolbHora;
        private System.Windows.Forms.Timer timerprincipal;
        private System.Windows.Forms.ToolStripMenuItem toolCadFornecedores;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioVendaCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioVendaSimplesToolStripMenuItem;
    }
}

