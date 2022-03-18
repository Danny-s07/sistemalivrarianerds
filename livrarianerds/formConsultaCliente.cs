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
    public partial class formConsultaCliente : Form
    {
        public formConsultaCliente()
        {
            InitializeComponent();
        }

        private void formConsultaCliente_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO COM AS OPÇÕES DE PESQUISA DE CLIENTE


            cbopcoes.Items.Add("Nome");
            cbopcoes.Items.Add("CPF");
            cbopcoes.Items.Add("Sexo");
            cbopcoes.Items.Add("Status");

            //opção nome selecionada no campo
            cbopcoes.SelectedItem = "Nome";
        }

        private void cbopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario
            if (cbopcoes.SelectedIndex == 0)//nome
            {
                txtpesquisar.Enabled = true;
                gbtipopesquisa.Enabled = true;
                gbcpf.Enabled = false;
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;
                txtpesquisar.Focus();
            }

            if (cbopcoes.SelectedIndex == 1)//CPF
            {
                txtpesquisar.Enabled = false;
                gbtipopesquisa.Enabled = false;
                gbcpf.Enabled = true;
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;
                mskcpf.Focus();
            }

            if (cbopcoes.SelectedIndex == 2)//Sexo
            {
                txtpesquisar.Enabled = false;
                gbtipopesquisa.Enabled = false;
                gbcpf.Enabled = false;
                gbsexo.Enabled = true;
                gbstatus.Enabled = false;
            }

            if (cbopcoes.SelectedIndex == 3)//Status
            {
                txtpesquisar.Enabled = false;
                gbtipopesquisa.Enabled = false;
                gbcpf.Enabled = false;
                gbsexo.Enabled = false;
                gbstatus.Enabled = true;
            }

        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            //Instanciar classe cliente para usar metodos 
            classCliente cCliente = new classCliente();

            //criar variavel para ler a opcao escolhida pelo usuario
            string consulta = cbopcoes.SelectedItem.ToString();

            switch (consulta)
            {
                //Opção nome
                case "Nome":
                //validar se o usuario preencheu o nome
            if (txtpesquisar.Text != "")
            { 
                 //VERIFICAR RG SELECIONADO SE FOR INICIO OU CONTEM
                 if (rbinicio.Checked == true)
                 {
                  dgvcliente.DataSource = cCliente.ConsultaClienteNomeInicio(txtpesquisar.Text);
                 }
            else
            {

            dgvcliente.DataSource = cCliente.ConsultaClienteNomeContem(txtpesquisar.Text);

            }
                   
                                 
            }
            break;
                //OPÇÃO do SEXO
                case "Sexo":
             //Se o RADIO BUTTON SELECIONADO
            if (rbf.Checked == true)
            {
               dgvcliente.DataSource = cCliente.ConsulaClineteSexo("Feminino"); 
            }    
            else
            {
                 dgvcliente.DataSource = cCliente.ConsulaClineteSexo("Masculino");  
            }
            break;

                //OPÇÃO do CPF
                case "CPF":
                    //validar se o usuario digitou cpf

                    if (mskcpf.Text != "   .   .   -")
                    {
                        dgvcliente.DataSource = cCliente.ConsultaClienteCPF(mskcpf.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor preencher um CPF !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                //OPÇÃO STATUS
                case "Status":
               //SE O RADIO BUTTON SELECIONADO
                if (rbativo.Checked == true)
                {
                        dgvcliente.DataSource = cCliente.ConsultaClienteStatus(1);    
                }
                else
                {
                        dgvcliente.DataSource = cCliente.ConsultaClienteStatus(0); 
                }
                break;


            } 

        }

        private void dgvcliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉDULA, NÃO SOMENTE NO TEXTO)

            //VALIDAR SE USUÁRIO DESEJA REALIZAR EDIÇÃO OU EXCLUSÃO DO CLIENTE SELECIONADO

            if (MessageBox.Show("Deseja alterar / excluir o cliente selecionado?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
           DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE CLIENTE PARA USAR MÉTODOS E PROPRIEDADES
                classCliente cCliente = new
                classCliente();

                //INSTANCIAR O FORMUÁRIO DE CADASTRO/ ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                formCliente fCliente = new formCliente();

                //PEGAR O CÓDIGO DO CLIENTE SELECIONADO PEÇO USUARIO NA FRID 
                cCliente.ConsultarCliente(Convert.ToInt32(dgvcliente.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE CLIENTES

                fCliente.txtcodigocliente.Text = cCliente.cod_cli.ToString();
                fCliente.txtnome.Text = cCliente.nome.ToString();
                fCliente.mskrg.Text = cCliente.rg.ToString();
                fCliente.mskcpf.Text = cCliente.cpf.ToString();
                fCliente.mskdatanascimento.Text = cCliente.datanascimento.ToString();
                fCliente.txtrua.Text = cCliente.rua.ToString();
                fCliente.txtnumero.Text = cCliente.numero.ToString();
                fCliente.txtcomplemento.Text = cCliente.complemento.ToString();
                fCliente.txtbairro.Text = cCliente.bairro.ToString();
                fCliente.txtcidade.Text = cCliente.cidade.ToString();
                fCliente.estado = cCliente.estado.ToString();
                fCliente.mskcep.Text = cCliente.cep.ToString();
                fCliente.txtemail.Text = cCliente.email.ToString();
                fCliente.msktelefone.Text = cCliente.telefones.ToString();
                fCliente.mskcelular.Text = cCliente.celular.ToString();
                fCliente.datacad = cCliente.dt_cad;

                //SEXO
                if (cCliente.sexo == "Feminino")
                {
                    fCliente.rbf.Checked = true;
                    fCliente.rbm.Checked = false;
                }
                else
                {
                    fCliente.rbf.Checked = false;
                    fCliente.rbm.Checked = true;
                }

                //STATUS

                if (cCliente.status_cli == 1)
                {
                    fCliente.ckstatus.Checked = true;
                }

                //MANDAR A INFORMAÇÃO DE UPDATE
                fCliente.tipo = "Atualização";
                //DEPOIS DE ATUALIZAR FECHA O FORMULARIO
                fCliente.ShowDialog();
                //CHAMAR MÉTODO DE PESQUISA
                btpesquisar_Click(this, new EventArgs());
            }

        }
    }
}

//pontuações das mensagens acrescentadas  por daniela 20-11-2021