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
    public partial class formRelFornecedores : Form
    {
        public formRelFornecedores()
        {
            InitializeComponent();
        }

        private void formRelFornecedores_Load(object sender, EventArgs e)
        {

            //carregar a combo das selecoes
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            //deixar a opcao Preco selecionada
            cbTipoRel.SelectedItem = "Cidade";


            //carregar combo categoria
            classFornecedor cFornecedor = new classFornecedor();
            //combo recebendo select
            cbCidade.DataSource = cFornecedor.CarregarCbCidade();
            //exibir na combo para usuario
            cbCidade.DisplayMember = "cidade";
            //armazenar no bd o codigo (fk)
            cbCidade.ValueMember = "cidade";
            //nao deixar nenhuma categoria selecionada
            cbCidade.SelectedIndex = -1;

            //carregar combo do sexo
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            //deixar a opcao sp selecionada
            cbSexo.SelectedIndex = 0;



            this.rptFornecedor.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {

            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario
            if (cbTipoRel.SelectedIndex == 0)//Cidade
            {
                gbCidade.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 1)//sexo
            {
                gbCidade.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 2)//status
            {
                gbCidade.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
            }

        }

        private void btGerarRelat_Click(object sender, EventArgs e)
        {
            //Instanciar classe fornecedor para usar metodos
            classFornecedor cFornecedor = new classFornecedor();

            //criar variavel para ler a opcao escolhida pelo usuario
            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch (relatorio)
            {

                //opcao cidade
                case "Cidade":
                    if (cbCidade.SelectedIndex != -1)
                    {
                        classFornecedorBindingSource.DataSource = cFornecedor.RelFornecedoresCidade(cbCidade.SelectedValue.ToString());
                        this.rptFornecedor.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Escolha um cidade !", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //opcao  combo sexo
                case "Sexo":
                    if (cbSexo.Text != " Escolha um Sexo")
                    {
                        classFornecedorBindingSource.DataSource = cFornecedor.RelFornecedorSexo(cbSexo.SelectedItem.ToString());
                        this.rptFornecedor.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Escolha um sexo !", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                //opcao status
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        classFornecedorBindingSource.DataSource = cFornecedor.RelFornecedoresStatus(1);
                        this.rptFornecedor.RefreshReport();
                    }
                    else
                    {
                        classFornecedorBindingSource.DataSource = cFornecedor.RelFornecedoresStatus(0);
                        this.rptFornecedor.RefreshReport();
                    }
                  break;




            }


        }
    }
}
