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
    public partial class formLivros : Form
    {
        public formLivros()
        {
            InitializeComponent();
        }
        //variavel tipo: guardar como o formulario deve ser aberto se para cadastro ou atualizar/excluir
        //variavel estado: informação é mostrada em uma combo 
        public string tipo;
        public int fornecedor, categoria, autor;
        //variavel datacad: mostra informação guardada no bd e nao a data atual como programado no load do form
        public DateTime datacad;

        private void formLivro_Load(object sender, EventArgs e)
        {

            //caregar combo fornecedores
            classAutores cAutor = new classAutores();
            //combo recebendo o select
            cbautor.DataSource = cAutor.CarregarCbAutores();
            //exibir na combo para o usuario
            cbautor.DisplayMember = "nome";
            //armazenar no bd o codigo (fk)
            cbautor.ValueMember = "cod_aut";
            //nao deixar nenhum fornecedor selecionado
            cbautor.SelectedIndex = -1;


            //caregar combo fornecedores
            classFornecedor cFornecedor = new classFornecedor();
            //combo recebendo o select
            cbfornecedor.DataSource = cFornecedor.CarregarCbFornecedores();
            //exibir na combo para o usuario
            cbfornecedor.DisplayMember = "nome";
            //armazenar no bd o codigo (fk)
            cbfornecedor.ValueMember = "cod_forn";
            //nao deixar nenhum fornecedor selecionado
            cbfornecedor.SelectedIndex = -1;

            //carregar combo categoria
            classCategoria cCategoria = new classCategoria();
            //combo recebendo select
            cbcategoria.DataSource = cCategoria.CarregarCbCategoria();
            //exibir na combo para usuario
            cbcategoria.DisplayMember = "nome";
            //armazenar no bd o codigo (fk)
            cbcategoria.ValueMember = "cod_cat";
            //nao deixar nenhuma categoria selecionada
            cbcategoria.SelectedIndex = -1;
            
            
            
            
            //carregar data na label
            lbdata.Text = DateTime.Now.ToShortDateString();


            //quando abrir o formulario para atualizar excluir
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Livros";
                btCadastrar.Enabled = false;
                ckStatus.Enabled = true;
                cbcategoria.SelectedValue = categoria;
                cbfornecedor.SelectedValue = fornecedor;
                cbautor.SelectedValue = autor;
                lbdata.Text = datacad.ToString();
            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void Limpar()
        {
            txtnome.Clear();
            txtqtestoque.Clear();
            txtpreco.Clear();
            cbcategoria.SelectedIndex = -1;
            cbfornecedor.SelectedIndex= -1;
            cbautor.SelectedIndex = -1;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            classLivros cLivros = new classLivros();
            if (txtnome.Text != "" && txtqtestoque.Text != "" && txtpreco.Text != "" && cbfornecedor.SelectedIndex != -1 && cbcategoria.SelectedIndex != -1 && cbautor.SelectedIndex != -1)
            {
                //passar para a propriedade o conteudo do formulario
                //todos os campos que o usuario pode preencher

                cLivros.nome = txtnome.Text;
                cLivros.qtd_estoque = Convert.ToInt32(txtqtestoque.Text);
                cLivros.preco = Convert.ToDecimal(txtpreco.Text);
                cLivros.cod_forn = Convert.ToInt32(cbfornecedor.SelectedValue);
                cLivros.cod_cat = Convert.ToInt32(cbcategoria.SelectedValue);
                cLivros.cod_prod = Convert.ToInt32(txtcodigo.Text);
                cLivros.cod_aut = Convert.ToInt32(cbautor.SelectedValue);

                //status
                if (ckStatus.Checked == true)
                {
                    cLivros.status_liv = 1;
                }
                else
                {
                    cLivros.status_liv = 0;
                }

                //chamar metodo pra cadasstrar  que esta na classe cliente
                bool resp = cLivros.AtualizarLivro();

                // se o cadastro der certo
                if (resp == true)
                {
                    MessageBox.Show("Livro : " + cLivros.nome + " Atualizado com sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar metodo de fechar 
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Erro ao realizar atualização !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else // se não preencher todos os campos obrigatorios
            {
                MessageBox.Show("Favor prencher todos os campos obrigatorios !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                txtqtestoque.BackColor = Color.LemonChiffon;
                txtpreco.BackColor = Color.LemonChiffon;
                txtnome.Focus();
            }
        }
        //evento que nao permite digitar letras
        //usando evento keypress do text 
        private void txtpreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se a tecla digitada nao for numero, BACKSPACE(08), ENTER(13), eSPAÇO(32) E VIRGULA(44)
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44)
            {
                //se o usuario pressionar tecla numerica e a de virgula no txtbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números e virgula !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtqtestoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se a tecla digitada nao for numero, BACKSPACE(08), ENTER(13), eSPAÇO(32) 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //se o usuario pressionar tecla numerica e a de virgula no txtbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classLivros cLivros = new classLivros();
            cLivros.cod_prod = Convert.ToInt32(txtcodigo.Text);
            bool resp = cLivros.ExcluirLivros();
            if (resp == true)
            {
                MessageBox.Show("Livro" + cLivros.nome + "excluido com sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Este Livro não pode ser excluido,ha registros em outras tabelas !", "Livraria Nerds !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //lembrar que os campos do tipo numero e data nao pode ser vazio
            //instanciando a classe cliente para usar pripriedades e metodos
            classLivros cLivros = new classLivros();
            if( txtnome.Text != "" && txtqtestoque.Text != "" &&  txtpreco.Text != "" && cbfornecedor.SelectedIndex != -1 && cbcategoria.SelectedIndex!= -1 && cbautor.SelectedIndex != -1)
            {
                //passar para a propriedade o conteudo do formulario
                //todos os campos que o usuario pode preencher

                cLivros.nome = txtnome.Text;
                cLivros.qtd_estoque = Convert.ToInt32(txtqtestoque.Text);
                cLivros.preco = Convert.ToDecimal(txtpreco.Text);
                cLivros.cod_forn = Convert.ToInt32(cbfornecedor.SelectedValue);
                cLivros.cod_cat = Convert.ToInt32(cbcategoria.SelectedValue);
                cLivros.cod_aut = Convert.ToInt32(cbautor.SelectedValue);
                                                          

                //chamar metodo pra cadasstrar  que esta na classe cliente
                int resp = cLivros.CadastraLivros();

                // se o cadastro der certo
                if (resp == 1)
                {
                    MessageBox.Show("Livros : " + cLivros.nome + " cadastrado com sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar metodo de limpar 
                    Limpar();
                }
                else
                {
                    MessageBox.Show(" Erro ao realizar cadastro !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else // se não preencher todos os campos obrigatorios
            {
                MessageBox.Show("Favor prencher todos os campos obrigatorios !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                txtqtestoque.BackColor = Color.LemonChiffon;
                txtpreco.BackColor = Color.LemonChiffon;
                txtnome.Focus();
            }
        }


    }
}
