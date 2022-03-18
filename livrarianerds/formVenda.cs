using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livrarianerds
{
    public partial class formVenda : Form
    {
        public formVenda()
        {
            InitializeComponent();
        }
        //lista itens venda
        private List<classItensVendidos> ListaIntensVendidos = new List<classItensVendidos>();

        //variavel para calcular o valor total da venda
        private decimal VendaTotal = 0;

        //variavel para contar quantas linhas foram adicionadas na lista 
        private int ItensVenda = 0;






        private void formVenda_Load(object sender, EventArgs e)
        {
            //carregar a combo da forma de pagamento
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Cartão de Credito");
            cbFormaPagamento.Items.Add("Cartão de Debito");
            cbFormaPagamento.Items.Add("Pix");



            //caregar combo fornecedores
            classFuncionario cFuncionario = new classFuncionario();
            //combo recebendo o select
            cbFuncionario.DataSource = cFuncionario.CarregarCbFuncionario();
            //exibir na combo para o usuario
            cbFuncionario.DisplayMember = "nome";
            //armazenar no bd o codigo (fk)
            cbFuncionario.ValueMember = "cod_func";
            //nao deixar nenhum fornecedor selecionado
            cbFuncionario.SelectedIndex = -1;
        }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            //Instanciar classe cliente para usar metodos 
            classCliente cCliente = new classCliente();

            if (txtPesqCliente.Text != "")
            {
                dgvCliente.DataSource = cCliente.PesquisaClienteVendas(txtPesqCliente.Text);
            }
            else
            {
                MessageBox.Show(" Favor digitar uma letra !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            //Instanciar classe livros para usar metodos 
            classLivros cLivro = new classLivros();

            if (txtPesqLivros.Text != "")
            {
                dgvLivros.DataSource = cLivro.PesquisaLivrosVenda(txtPesqLivros.Text);
            }
            else
            {
                MessageBox.Show(" Favor digitar uma letra !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //programando a txt de inserir a quantidade para ver se esta com numero digitado ou nao
        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (txtQtde.Text == "")
            {
                MessageBox.Show("Favor informar uma quantidade !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
                txtQtde.SelectAll();
            }

            //criando as variaveis  para chamar no metodo de venda com estoque
            int qtdevendida = Convert.ToInt32(txtQtde.Text);
            int qtdestoque = Convert.ToInt32(txtQtdeEstoque.Text);

            //verificar se a quantidade vendida é maior que a quantidade em estoque
            if(qtdevendida > qtdestoque)
            {
                MessageBox.Show(" A quantidade disponivel no estoque é :  "  + qtdestoque +   " unidades!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
                txtQtde.SelectAll();
            }
            else
            {
                qtdevendida = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtTotal.Text = (qtdevendida * valor).ToString();
            }



        }


        //selecionar o produto escolhido na grid e carregar as informacoes no form de venda
        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classLivros cLivro = new classLivros();

            bool resp = cLivro.ConsultarLivro(Convert.ToInt32(dgvLivros.SelectedRows[0].Cells[0].Value));

            if(resp == true)
            {
                txtLivro.Text = cLivro.nome;
                txtQtdeEstoque.Text = cLivro.qtd_estoque.ToString();
                txtValor.Text = cLivro.preco.ToString("n2");
                txtQtde.Text = "01";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();
            }

        }

        private void txtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            if(txtValorDesconto.Text == "")
            {
                decimal valor = Convert.ToDecimal(txtValorTotal.Text);
                txtTotalVenda.Text = valor.ToString("n2");
                txtTotalDesconto.Text = "0,00";
            }
            else
            {
                 decimal valtotal = Convert.ToDecimal(txtValorTotal.Text);
                decimal valdesc = Convert.ToDecimal(txtValorDesconto.Text);
                 decimal novopreco = 0;
                decimal valfinal = 0;

                novopreco = (valtotal * (valdesc / 100 )) ;
               txtTotalDesconto.Text = novopreco.ToString("n2");
                valfinal = valtotal - novopreco;
                txtTotalVenda.Text = valfinal.ToString("n2");

            }
        }


        //criando metodo de atualizacao de grid de exibição de produtos no formulario de vendas
        private void AtualizaGrid()
        {
            //adiciona na grid a partir da lista
            classLivros cLivro = new classLivros();
            DataTable dt = new DataTable();

            //criar as colunas da grid
            dt.Columns.Add(new DataColumn("Codigo"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Preço"));

            //adicionar as linhas da grid
            foreach (classItensVendidos item in ListaIntensVendidos)
            {
                dt.Rows.Add(item.cod_prod, cLivro.BuscaNomeLivro(item.cod_prod), item.qtde, item.preco);
                dt.AcceptChanges();
            }

            dgvItens.DataSource = dt;


        }

        //botao de quando clicar no mais ele vai adicionar o produto na venda e fazer a conta
        private void btAddProduto_Click(object sender, EventArgs e)
        {
            classItensVendidos cItensVendido = new classItensVendidos();

            //somar valor do item ao total da venda
            decimal vTotal = 0;

            //verificar se algum produto foi selecionado
            if(txtTotal.Text == "")
            {
                MessageBox.Show("Não há produto para ser inserido", "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                //somar valor do item selecionado ao total da venda
                vTotal = Convert.ToDecimal(txtTotal.Text);
                VendaTotal = VendaTotal + vTotal;
                txtValorTotal.Text = VendaTotal.ToString("n2");

                //contar itens da venda(qtde da linhas grid)
                ItensVenda++;

                //informacoes dos produtos vendidos
                cItensVendido.cod_prod = Convert.ToInt32(dgvLivros.SelectedRows[0].Cells[0].Value);
                cItensVendido.qtde = Convert.ToInt32(txtQtde.Text);
                cItensVendido.preco = Convert.ToDecimal(txtTotal.Text);


                //adicionar na lista
                ListaIntensVendidos.Add(cItensVendido);

                //pegar da lista a quantidade de itens
                txtQtdeItens.Text = ItensVenda.ToString();
                txtQtdeItens.Text = ListaIntensVendidos.Count.ToString();

                //chamar metodo que cria a grid de produtos vendidos
                AtualizaGrid();

                //Limpar os campos de produto apos adicionar
                txtLivro.Clear();
                txtQtde.Text = "01";
                txtValor.Clear();
                txtTotal.Clear();
                txtQtdeEstoque.Clear();
                txtValorDesconto.Text = "0";
                txtValorDesconto_TextChanged(this, new EventArgs());
                txtValorDesconto.Select();

            }
        
        
        }

        //metodo limpar - chamado quando venda finalizada
        private void Limpar()
        {
            cbFuncionario.SelectedIndex = -1;
            txtPesqCliente.Clear();
            dgvCliente.DataSource = null;
            txtPesqLivros.Clear();
            dgvLivros.DataSource = null;

            ListaIntensVendidos.Clear();
            AtualizaGrid();
            dgvItens.Refresh();

            txtValorTotal.Text = "0";
            txtTotalVenda.Text = "0";
            txtValorDesconto.Text = "0";
            txtTotalDesconto.Text = "0";

            txtQtdeItens.Clear();
            cbFormaPagamento.SelectedIndex = -1;
            VendaTotal = 0;
        }

        //metodo atualizar estoque (fazer conta para excluir do estoque)
        private void AtualizaEstoque(int qtde, int cod)
        {
            classLivros cLivro = new classLivros();
            cLivro.ConsultarLivro(cod);
            int estoque = cLivro.qtd_estoque;
            cLivro.AtualizarQtde(estoque - qtde, cod);
        }

        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            //verificar campos obrigatorios
            if(cbFuncionario.SelectedIndex != -1 && dgvCliente.DataSource != null && dgvItens.DataSource != null && cbFormaPagamento.SelectedIndex != -1)
            {
                classPedido cPedido = new classPedido();

                //mandar informacoes da tabela venda
                cPedido.valor_total = Convert.ToDecimal(txtTotalVenda.Text);
                cPedido.formapagt = cbFormaPagamento.SelectedItem.ToString();
                cPedido.desconto = Convert.ToDecimal(txtTotalDesconto.Text);
                cPedido.cod_cli = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
                cPedido.cod_func = Convert.ToInt32(cbFuncionario.SelectedValue);

                //chamar metodo cadastrar venda
                bool resp = cPedido.CadastrarPedido();

                if(resp == true)
                {
                    foreach(classItensVendidos item in ListaIntensVendidos)
                    {
                        item.cod_ped = cPedido.cod_ped;
                        resp = item.CadastrarItensVendidos();
                        //baixa estoque
                        AtualizaEstoque(item.qtde, item.cod_prod);
                    }
                    if(resp == true){
                        MessageBox.Show("Venda realizada com Sucesso!", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpar();
                    }
                                                                                          }
                else
                {
                    MessageBox.Show("Erro ao Realizar a Venda!", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos!", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btRemoveProduto_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja Remover o Livro selecionado?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Recalcular total da venda
                    //pegar o valor do item selecionado pelo usuario
                    decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[3].Value);
                    VendaTotal = VendaTotal - valor;
                    txtTotalVenda.Text = VendaTotal.ToString();
                    txtValorTotal.Text = VendaTotal.ToString();

                    //remover o item selecionado da lista e atualiza grid
                    ListaIntensVendidos.RemoveAt(dgvItens.CurrentRow.Index);
                    AtualizaGrid();

                    //recontar a lista de produtos vendidos
                    txtQtdeItens.Text = ListaIntensVendidos.Count.ToString();
                    txtValorDesconto_TextChanged(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Não há produto para ser removido", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
