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
    public partial class formRelLivros : Form
    {
        public formRelLivros()
        {
            InitializeComponent();
        }

        private void formRelLivros_Load(object sender, EventArgs e)
        {

            //carregar a combo das opções
            cbTipoRel.Items.Add("Preço");
            cbTipoRel.Items.Add("Fornecedor");
            cbTipoRel.Items.Add("Categoria");
            cbTipoRel.Items.Add("Status");
            //deixar a opcao Preco selecionada
            cbTipoRel.SelectedItem = "Preço";


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

            this.rptLivros.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario
            if (cbTipoRel.SelectedIndex == 0)//preco
            {
                gbPreco.Enabled = true;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = false;
                gbStatus.Enabled = false;
               
            }

            if (cbTipoRel.SelectedIndex == 1)//fornecedor
            {
                gbPreco.Enabled = false;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = true;
                gbStatus.Enabled = false;

            }

            if (cbTipoRel.SelectedIndex == 2)//categoria
            {
                gbPreco.Enabled = false;
                gbCategoria.Enabled = true;
                gbFornecedor.Enabled = false;
                gbStatus.Enabled = false;

            }

            if (cbTipoRel.SelectedIndex == 3)//status
            {
                gbPreco.Enabled = false;
                gbCategoria.Enabled = false;
                gbFornecedor.Enabled = false;
                gbStatus.Enabled = true;

            }






        }

        private void btGerarRelat_Click(object sender, EventArgs e)
        {
            //Instanciar classe livro para usar metodos 
            classLivros cLivros = new classLivros();

            //criar variavel para ler a opcao escolhida pelo usuario
            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch (relatorio)
            {
                //opcao de preco
                case "Preço":
                    if(txtDe.Text != "" && txtAte.Text !="")
                    {
                        classLivrosBindingSource.DataSource = cLivros.RelLivroPreco(Convert.ToDecimal(txtDe.Text), Convert.ToDecimal(txtAte.Text));
                        this.rptLivros.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Digite o preço inicial e final ! ", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;
                //opcao fornecedor
                case "Fornecedor":
                    if (cbFornecedor.SelectedIndex != -1)
                    {
                        classLivrosBindingSource.DataSource = cLivros.RelLivroFornecedor(Convert.ToInt32(cbFornecedor.SelectedValue.ToString()));
                        this.rptLivros.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show(" Escolha um fornecedor !", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //opcao categoria
                case "Categoria":
                    if (cbCategoria.SelectedIndex != -1)
                    {
                        classLivrosBindingSource.DataSource = cLivros.RelLivroCategoria(Convert.ToInt32(cbCategoria.SelectedValue.ToString()));
                        this.rptLivros.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Escolha uma categoria !", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //opcao status
                case "Status":

                    if(rbAtivo.Checked == true)
                    {
                        classLivrosBindingSource.DataSource = cLivros.RelLivroStatus(1);
                        this.rptLivros.RefreshReport();
                    }
                    else
                    {
                        classLivrosBindingSource.DataSource = cLivros.RelLivroStatus(0);
                        this.rptLivros.RefreshReport();
                    }
                    
                    break;
            }

        }

        private void txtDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se a tecla digitada nao for numero, BACKSPACE(08), ENTER(13), eSPAÇO(32) E VIRGULA(44)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44)
            {
                //se o usuario pressionar tecla numerica e a de virgula no txtbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números e virgula !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAte_KeyPress(object sender, KeyPressEventArgs e)
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
