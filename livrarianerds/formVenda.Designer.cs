
namespace livrarianerds
{
    partial class formVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVenda));
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbPesquisaCliente = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtPesqCliente = new System.Windows.Forms.TextBox();
            this.btBuscaCliente = new System.Windows.Forms.Button();
            this.btRemoveProduto = new System.Windows.Forms.Button();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtQtdeItens = new System.Windows.Forms.TextBox();
            this.txtQtdeEstoque = new System.Windows.Forms.TextBox();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.gbPesquisaLivros = new System.Windows.Forms.GroupBox();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.txtPesqLivros = new System.Windows.Forms.TextBox();
            this.btBuscaProduto = new System.Windows.Forms.Button();
            this.btFechaVenda = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.gbPesquisaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbPesquisaLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFormaPagamento.Location = new System.Drawing.Point(830, 456);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(211, 30);
            this.cbFormaPagamento.TabIndex = 224;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(848, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 19);
            this.label12.TabIndex = 223;
            this.label12.Text = "* Forma Pagamento:";
            // 
            // gbPesquisaCliente
            // 
            this.gbPesquisaCliente.Controls.Add(this.dgvCliente);
            this.gbPesquisaCliente.Controls.Add(this.txtPesqCliente);
            this.gbPesquisaCliente.Controls.Add(this.btBuscaCliente);
            this.gbPesquisaCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisaCliente.Location = new System.Drawing.Point(13, 76);
            this.gbPesquisaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbPesquisaCliente.Name = "gbPesquisaCliente";
            this.gbPesquisaCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbPesquisaCliente.Size = new System.Drawing.Size(468, 194);
            this.gbPesquisaCliente.TabIndex = 212;
            this.gbPesquisaCliente.TabStop = false;
            this.gbPesquisaCliente.Text = "* Pesquisa de Clientes:";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.Location = new System.Drawing.Point(7, 70);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(448, 117);
            this.dgvCliente.TabIndex = 4;
            // 
            // txtPesqCliente
            // 
            this.txtPesqCliente.Location = new System.Drawing.Point(7, 31);
            this.txtPesqCliente.Name = "txtPesqCliente";
            this.txtPesqCliente.Size = new System.Drawing.Size(399, 26);
            this.txtPesqCliente.TabIndex = 1;
            // 
            // btBuscaCliente
            // 
            this.btBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaCliente.Image")));
            this.btBuscaCliente.Location = new System.Drawing.Point(412, 23);
            this.btBuscaCliente.Name = "btBuscaCliente";
            this.btBuscaCliente.Size = new System.Drawing.Size(44, 42);
            this.btBuscaCliente.TabIndex = 3;
            this.btBuscaCliente.UseVisualStyleBackColor = true;
            this.btBuscaCliente.Click += new System.EventHandler(this.btBuscaCliente_Click);
            // 
            // btRemoveProduto
            // 
            this.btRemoveProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRemoveProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRemoveProduto.Image = ((System.Drawing.Image)(resources.GetObject("btRemoveProduto.Image")));
            this.btRemoveProduto.Location = new System.Drawing.Point(974, 85);
            this.btRemoveProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btRemoveProduto.Name = "btRemoveProduto";
            this.btRemoveProduto.Size = new System.Drawing.Size(45, 48);
            this.btRemoveProduto.TabIndex = 222;
            this.btRemoveProduto.UseVisualStyleBackColor = true;
            this.btRemoveProduto.Click += new System.EventHandler(this.btRemoveProduto_Click);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(503, 522);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(199, 30);
            this.txtTotalVenda.TabIndex = 220;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(503, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 19);
            this.label11.TabIndex = 219;
            this.label11.Text = "Total da Venda (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 218;
            this.label2.Text = "=";
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Enabled = false;
            this.txtTotalDesconto.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDesconto.Location = new System.Drawing.Point(736, 456);
            this.txtTotalDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.Size = new System.Drawing.Size(80, 30);
            this.txtTotalDesconto.TabIndex = 217;
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDesconto.Location = new System.Drawing.Point(669, 456);
            this.txtValorDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorDesconto.MaxLength = 2;
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(42, 30);
            this.txtValorDesconto.TabIndex = 216;
            this.txtValorDesconto.TextChanged += new System.EventHandler(this.txtValorDesconto_TextChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(503, 456);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(151, 30);
            this.txtValorTotal.TabIndex = 215;
            // 
            // txtQtdeItens
            // 
            this.txtQtdeItens.Enabled = false;
            this.txtQtdeItens.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItens.Location = new System.Drawing.Point(722, 522);
            this.txtQtdeItens.Name = "txtQtdeItens";
            this.txtQtdeItens.Size = new System.Drawing.Size(94, 30);
            this.txtQtdeItens.TabIndex = 214;
            // 
            // txtQtdeEstoque
            // 
            this.txtQtdeEstoque.Enabled = false;
            this.txtQtdeEstoque.Location = new System.Drawing.Point(914, 39);
            this.txtQtdeEstoque.Name = "txtQtdeEstoque";
            this.txtQtdeEstoque.Size = new System.Drawing.Size(99, 27);
            this.txtQtdeEstoque.TabIndex = 213;
            // 
            // txtLivro
            // 
            this.txtLivro.Enabled = false;
            this.txtLivro.Location = new System.Drawing.Point(504, 39);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(397, 27);
            this.txtLivro.TabIndex = 211;
            // 
            // gbPesquisaLivros
            // 
            this.gbPesquisaLivros.Controls.Add(this.dgvLivros);
            this.gbPesquisaLivros.Controls.Add(this.txtPesqLivros);
            this.gbPesquisaLivros.Controls.Add(this.btBuscaProduto);
            this.gbPesquisaLivros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisaLivros.Location = new System.Drawing.Point(13, 310);
            this.gbPesquisaLivros.Margin = new System.Windows.Forms.Padding(4);
            this.gbPesquisaLivros.Name = "gbPesquisaLivros";
            this.gbPesquisaLivros.Padding = new System.Windows.Forms.Padding(4);
            this.gbPesquisaLivros.Size = new System.Drawing.Size(468, 220);
            this.gbPesquisaLivros.TabIndex = 210;
            this.gbPesquisaLivros.TabStop = false;
            this.gbPesquisaLivros.Text = "* Pesquisa de Livros:";
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.AllowUserToResizeColumns = false;
            this.dgvLivros.AllowUserToResizeRows = false;
            this.dgvLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLivros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLivros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLivros.Location = new System.Drawing.Point(8, 71);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.RowHeadersWidth = 51;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(448, 142);
            this.dgvLivros.TabIndex = 0;
            this.dgvLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellClick);
            // 
            // txtPesqLivros
            // 
            this.txtPesqLivros.Location = new System.Drawing.Point(7, 31);
            this.txtPesqLivros.Name = "txtPesqLivros";
            this.txtPesqLivros.Size = new System.Drawing.Size(399, 26);
            this.txtPesqLivros.TabIndex = 1;
            // 
            // btBuscaProduto
            // 
            this.btBuscaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaProduto.Image")));
            this.btBuscaProduto.Location = new System.Drawing.Point(412, 23);
            this.btBuscaProduto.Name = "btBuscaProduto";
            this.btBuscaProduto.Size = new System.Drawing.Size(44, 42);
            this.btBuscaProduto.TabIndex = 3;
            this.btBuscaProduto.UseVisualStyleBackColor = true;
            this.btBuscaProduto.Click += new System.EventHandler(this.btBuscaProduto_Click);
            // 
            // btFechaVenda
            // 
            this.btFechaVenda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btFechaVenda.Image")));
            this.btFechaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechaVenda.Location = new System.Drawing.Point(836, 493);
            this.btFechaVenda.Name = "btFechaVenda";
            this.btFechaVenda.Size = new System.Drawing.Size(205, 59);
            this.btFechaVenda.TabIndex = 209;
            this.btFechaVenda.Text = "       Fechar Venda";
            this.btFechaVenda.UseVisualStyleBackColor = true;
            this.btFechaVenda.Click += new System.EventHandler(this.btFechaVenda_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(669, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 208;
            this.label13.Text = "Desconto (%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 207;
            this.label10.Text = "Valor Total (R$)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 206;
            this.label9.Text = "Qtde Itens:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItens);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(497, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 289);
            this.groupBox2.TabIndex = 205;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "* Itens da Venda:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.Location = new System.Drawing.Point(5, 26);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(533, 257);
            this.dgvItens.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(731, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 204;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(731, 101);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(105, 27);
            this.txtTotal.TabIndex = 203;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 202;
            this.label6.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(612, 101);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(105, 27);
            this.txtValor.TabIndex = 201;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 200;
            this.label5.Text = "Qtde";
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.Color.White;
            this.txtQtde.Location = new System.Drawing.Point(504, 101);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(95, 27);
            this.txtQtde.TabIndex = 199;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(914, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 198;
            this.label4.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 197;
            this.label3.Text = "Livro";
            // 
            // btAddProduto
            // 
            this.btAddProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAddProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAddProduto.Image = ((System.Drawing.Image)(resources.GetObject("btAddProduto.Image")));
            this.btAddProduto.Location = new System.Drawing.Point(914, 85);
            this.btAddProduto.Name = "btAddProduto";
            this.btAddProduto.Size = new System.Drawing.Size(45, 48);
            this.btAddProduto.TabIndex = 196;
            this.btAddProduto.UseVisualStyleBackColor = true;
            this.btAddProduto.Click += new System.EventHandler(this.btAddProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 195;
            this.label1.Text = "* Funcionário:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFuncionario.Location = new System.Drawing.Point(124, 14);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(347, 27);
            this.cbFuncionario.TabIndex = 194;
            // 
            // formVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 565);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gbPesquisaCliente);
            this.Controls.Add(this.btRemoveProduto);
            this.Controls.Add(this.txtTotalVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalDesconto);
            this.Controls.Add(this.txtValorDesconto);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtQtdeItens);
            this.Controls.Add(this.txtQtdeEstoque);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.gbPesquisaLivros);
            this.Controls.Add(this.btFechaVenda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAddProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFuncionario);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.formVenda_Load);
            this.gbPesquisaCliente.ResumeLayout(false);
            this.gbPesquisaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbPesquisaLivros.ResumeLayout(false);
            this.gbPesquisaLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbPesquisaCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtPesqCliente;
        private System.Windows.Forms.Button btBuscaCliente;
        private System.Windows.Forms.Button btRemoveProduto;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtQtdeItens;
        private System.Windows.Forms.TextBox txtQtdeEstoque;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.GroupBox gbPesquisaLivros;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.TextBox txtPesqLivros;
        private System.Windows.Forms.Button btBuscaProduto;
        private System.Windows.Forms.Button btFechaVenda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFuncionario;
    }
}