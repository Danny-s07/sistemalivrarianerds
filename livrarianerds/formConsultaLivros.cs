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
    public partial class formConsultaLivros : Form
    {
        public formConsultaLivros()
        {
            InitializeComponent();
        }

        private void formConsultaLivro_Load(object sender, EventArgs e)
        {
            //Carregar combo com as opções de pesquisa de livro
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Fornecedor");
            cbOpcoes.Items.Add("Categoria");
            cbOpcoes.Items.Add("Preço");
            cbOpcoes.Items.Add("Status");

            //opção nome selecionada no campo
            cbOpcoes.SelectedItem = "Nome";
            //caregar combo fornecedores
            classFornecedor cFornecedor = new classFornecedor();
            //combo recebendo o select
            cbFornecedor.DataSource = cFornecedor.CarregarCbFornecedores();
            //exibir na combo para o usuario
            cbFornecedor.DisplayMember = "nome";
            //armazenar no bd o codigo (fk)
            cbFornecedor.ValueMember = "cod_forn";
            //nao deixar nenhum fornecedor selecionado
            cbFornecedor.SelectedIndex = -1;

            //carregar combo categoria
            classCategoria cCategoria = new classCategoria();
            //combo recebendo select
            cbCategoria.DataSource = cCategoria.CarregarCbCategoria();
            //exibir na combo para usuario
            cbCategoria.DisplayMember = "nome";
            //armazenar no bd o codigo (fk)
            cbCategoria.ValueMember = "cod_cat";
            //nao deixar nenhuma categoria selecionada
            cbCategoria.SelectedIndex = -1;
        }



        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair", " Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario
            if (cbOpcoes.SelectedIndex == 0)//nome
            {
                txtPesquisar.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbValor.Enabled = false;
                gbStatus.Enabled = false;
                gbFornecedor.Enabled = false;
                gbCategoria.Enabled = false;
                txtPesquisar.Focus();
                
            }

            if (cbOpcoes.SelectedIndex == 1)//Fornecedor
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbValor.Enabled = false;
                gbStatus.Enabled = false;
                gbFornecedor.Enabled = true;
                gbCategoria.Enabled = false;


            }

            if (cbOpcoes.SelectedIndex == 2)//Categoria
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbValor.Enabled = false;
                gbStatus.Enabled = false;
                gbFornecedor.Enabled = false;
                gbCategoria.Enabled = true;

            }

            if (cbOpcoes.SelectedIndex == 3)//Preço
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbValor.Enabled = true;
                gbStatus.Enabled = false;
                gbFornecedor.Enabled = false;
                gbCategoria.Enabled = false;

            }

            if (cbOpcoes.SelectedIndex == 4)//Status
            {
                txtPesquisar.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbValor.Enabled = false;
                gbStatus.Enabled = true;
                gbFornecedor.Enabled = false;
                gbCategoria.Enabled = false;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //Instanciar classe cliente para usar metodos 
            classLivros cLivro = new classLivros();

            //criar variavel para ler a opcao escolhida pelo usuario
            string consulta = cbOpcoes.SelectedItem.ToString();

            switch (consulta)
            {
                //opção nome
                case "Nome":
                    //validar se o usuario preencheu o nome
                    if (txtPesquisar.Text != "")
                    {
                        //verificar rb selecionado se for inicio ou contem 
                        if (rbInicio.Checked == true)
                        {
                            dgvLivro.DataSource = cLivro.ConsultaLivroNomeInicio(txtPesquisar.Text);
                        }
                        else
                        {
                            dgvLivro.DataSource = cLivro.ConsultaLivroNomeContem(txtPesquisar.Text);
                        }

                    }
                    else
                    {
                        MessageBox.Show(" Favor preencher um nome !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //opcao status
                case "Status":
                    // se o radiun button selecionado
                    if (rbAtivo.Checked == true)
                    {
                        dgvLivro.DataSource = cLivro.ConsultaLivroStatus(1);
                    }
                    else
                    {
                        dgvLivro.DataSource = cLivro.ConsultaLivroStatus(0);
                    }


                    break;

                //validar se o usuario selecionou o inicio o o fim do preço
                case "Preço":
                    //se o txt recebeu algum texto
                    if (txtprecoinicial.Text != "" && txtprecofinal.Text != "")
                    {
                        dgvLivro.DataSource = cLivro.ConsultaLivroPreco(Convert.ToDecimal(txtprecoinicial.Text) , Convert.ToDecimal(txtprecofinal.Text));
                    }
                    else
                    {
                        MessageBox.Show("Favor prencher os campos de preço !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                    break;

                //validar combo de fornecedor

                case "Fornecedor":

                    if (cbFornecedor.SelectedIndex != -1)
                    {
                        dgvLivro.DataSource = cLivro.ConsultaLivroFornecedor(Convert.ToInt32(cbFornecedor.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolher um Fornecedor !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;


                //validar combo de categoria
                case "Categoria":
                    if (cbCategoria.SelectedIndex != -1)
                    {
                        dgvLivro.DataSource = cLivro.ConsultaLivroCategoria(Convert.ToInt32(cbCategoria.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("Favor Escolher uma Categoria !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

            }
        }

        private void dgvLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //validar se o usuario deseja realizar edicao ou exclusao do livro selecionado
            if (MessageBox.Show("Deseja alterar/ excluir o Livro selecionado?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //instanciar classe livro
                //instanciar o formulario
                classLivros cLivros = new classLivros();
                formLivros fLivro = new formLivros();

                cLivros.ConsultarLivro(Convert.ToInt32(dgvLivro.SelectedRows[0].Cells[0].Value));

                //passar os dados do bd para os controles do form de livro
                fLivro.txtcodigo.Text = cLivros.cod_prod.ToString();
                fLivro.txtnome.Text = cLivros.nome.ToString();
                fLivro.txtqtestoque.Text = cLivros.qtd_estoque.ToString();
                fLivro.txtpreco.Text = cLivros.preco.ToString();
                fLivro.datacad = cLivros.dt_cad;
                fLivro.fornecedor = cLivros.cod_forn;
                fLivro.categoria = cLivros.cod_cat;
                fLivro.autor = cLivros.cod_aut;
                //status
                if (cLivros.status_liv == 1)
                {
                    fLivro.ckStatus.Checked = true;
                }
                else
                {
                    fLivro.ckStatus.Checked = false;
                }

                //mandar a informacao de update
                fLivro.tipo = "Atualização";
                //depos de atualizar fecha o form
                fLivro.ShowDialog();
                //chamar metodo pesquisar
                btPesquisar_Click(this, new EventArgs());


            }
        }

        private void txtprecofinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se a tecla digitada nao for numero, BACKSPACE(08), ENTER(13), eSPAÇO(32) E VIRGULA(44)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44)
            {
                //se o usuario pressionar tecla numerica e a de virgula no txtbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números e virgula !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtprecoinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se a tecla digitada nao for numero, BACKSPACE(08), ENTER(13), eSPAÇO(32) E VIRGULA(44)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44)
            {
                //se o usuario pressionar tecla numerica e a de virgula no txtbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números e virgula !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
