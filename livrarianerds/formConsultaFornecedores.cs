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
    public partial class formConsultaFornecedores : Form
    {
        public formConsultaFornecedores()
        {
            InitializeComponent();
        }

        private void formConsultaFornecedores_Load(object sender, EventArgs e)
        {
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Status");

            //opção nome selecionada no campo
            cbOpcoes.SelectedItem = "Nome";

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

        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario

            if (cbOpcoes.SelectedIndex == 0)//nome
            {
                txtPesquisa.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbCidade.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;
                txtPesquisa.Focus();
            }

            if (cbOpcoes.SelectedIndex == 1)//cidade
            {
                txtPesquisa.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbCidade.Enabled = true;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;
                
            }

             if (cbOpcoes.SelectedIndex == 2)//sexo
            {
                txtPesquisa.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbCidade.Enabled = false;
                gbSexo.Enabled = true;
                gbStatus.Enabled = false;
             }

            if (cbOpcoes.SelectedIndex == 3)//status
            {
                txtPesquisa.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbCidade.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = true;
            }




        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //Instanciar classe fornecedor para usar metodos 
            classFornecedor cFornecedor = new classFornecedor();

            //criar variavel para ler a opcao escolhida pelo usuario
            string consulta = cbOpcoes.SelectedItem.ToString();

            switch (consulta)
            {
                //opcao nome
                case "Nome":
                    //validar se o usuario preencheu o nome
                    if(txtPesquisa.Text != "")
                    {
                        if(rbInicio.Checked == true)
                        {
                            dgvFornecedor.DataSource = cFornecedor.ConsultaFornecedorNomeInicio(txtPesquisa.Text);
                        }
                        else
                        {
                            dgvFornecedor.DataSource = cFornecedor.ConsultaFornecedorNomeContem(txtPesquisa.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Favor preencher um nome !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                //opcao cidade
                case "Cidade":

                    //validar se foi escrito algo na caixa da cidade
                    if(cbCidade.SelectedIndex != -1)
                    {
                        dgvFornecedor.DataSource = cFornecedor.ConsultaFornecedorCidade(cbCidade.SelectedValue.ToString());
                    }
                    else
                    {
                        MessageBox.Show(" Favor preencher uma cidade !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //opcao o sexo
                case "Sexo":
                    // se o radiun button selecionado

                    if (rbf.Checked == true)
                    {
                        dgvFornecedor.DataSource = cFornecedor.ConsultaFornecedorSexo("Feminino");
                    }
                    else
                    {
                        dgvFornecedor.DataSource = cFornecedor.ConsultaFornecedorSexo("Masculino");
                    }

                    break;

                //opcao status
                case "Status":
                    // se o radiun button selecionado
                    if (rbAtivo.Checked == true)
                    {
                        dgvFornecedor.DataSource = cFornecedor.ConsultaFornecedorStatus(1);
                    }
                    else
                    {
                        dgvFornecedor.DataSource = cFornecedor.ConsultaFornecedorStatus(0);
                    }

                    break;

            }


        }

        //clicar na grid de clientes e editar ou excluir um cliente
        //usar o evento celclick(pode clicar em qualquer lugar da celula, nao somente no texto)
        //usando o evento cellcontentclick(tem que clicar no conteudo(texto))
        //usando evento doubleclick(usuario precisa dar 2 cliques)
        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //validar se o usuario deseja realizar edicao ou exclusao do cliente selecionado
            if (MessageBox.Show("Deseja alterar/ excluir o fornecedor selecionado?", "Livraria nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //instanciar classe fornecedor
                classFornecedor cFornecedor = new classFornecedor();
                //instanciar o formulario
                formFornecedores fFornecedor = new formFornecedores();

                //pegar o codigo do fornecedor selecionado pelo usuario na grid
                cFornecedor.ConsultarFornecedor(Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells[0].Value));

                //passar os dados do bd para os controles do form de fornecedores
                fFornecedor.txtCodigoFornecedor.Text = cFornecedor.cod_forn.ToString();
                fFornecedor.txtnome.Text = cFornecedor.nome.ToString();
                fFornecedor.txtemail.Text = cFornecedor.email.ToString();
                fFornecedor.mskcnpj.Text = cFornecedor.cnpj.ToString();
                fFornecedor.txtrua.Text = cFornecedor.rua.ToString();
                fFornecedor.txtnumero.Text = cFornecedor.numero.ToString();
                fFornecedor.txtbairro.Text = cFornecedor.bairro.ToString();
                fFornecedor.mskcep.Text = cFornecedor.cep.ToString();
                fFornecedor.txtcomplemento.Text = cFornecedor.complemento.ToString();
                fFornecedor.txtcidade.Text = cFornecedor.cidade.ToString();
                fFornecedor.estado = cFornecedor.estado.ToString();
                fFornecedor.msktelefone.Text = cFornecedor.telefone.ToString();
                fFornecedor.mskcelular.Text = cFornecedor.celular.ToString();
                fFornecedor.datacad = cFornecedor.dt_cd;// label da data cadastro, pegar variavel criada no form de cadastro

             //radiun button sexo
             if(cFornecedor.sexo == "Feminino")
                {
                    fFornecedor.rbf.Checked = true;
                    fFornecedor.rbm.Checked = false;
                }
                else
                {
                    fFornecedor.rbf.Checked = false;
                    fFornecedor.rbm.Checked = true;
                }

                //status
                if (cFornecedor.status_forn == 1)
                {

                fFornecedor.ckStatus.Checked = true;
                }
                 else
                  {
                    fFornecedor.ckStatus.Checked = false;
                 }

            //mandar a informacao de update
            fFornecedor.tipo = "Atualização";
                //depos de atualizar fecha o form
                fFornecedor.ShowDialog();
                //chamar metodo pesquisar
                btPesquisar_Click(this, new EventArgs());


            }


        }
    }
}
