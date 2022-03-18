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
    public partial class formConsultaFuncionario : Form
    {
        public formConsultaFuncionario()
        {
            InitializeComponent();
        }
       

        private void formConsultaFuncionario_Load(object sender, EventArgs e)
        {
            cbopcoes.Items.Add("Nome");
            cbopcoes.Items.Add("Cpf");
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
                gbcpf.Enabled = false; // alterado por  daniela  19-11-2021
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;
                txtpesquisar.Focus();
            }

            if (cbopcoes.SelectedIndex == 1)//CPF
            {
                txtpesquisar.Enabled = false;
                gbtipopesquisa.Enabled = false;
                gbcpf.Enabled = true;  // alterado por  daniela  19-11-2021
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;
                mskcpf.Focus();
            }

            if (cbopcoes.SelectedIndex == 2)//Sexo
            {
                txtpesquisar.Enabled = false;
                gbtipopesquisa.Enabled = false;
                gbcpf.Enabled = false; // alterado por  daniela  19-11-2021
                gbsexo.Enabled = true;
                gbstatus.Enabled = false;
            }

            if (cbopcoes.SelectedIndex == 3)//Status
            {
                txtpesquisar.Enabled = false;
                gbtipopesquisa.Enabled = false;
                gbcpf.Enabled = false;  // alterado por  daniela  19-11-2021
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
            classFuncionario cFuncionario = new classFuncionario();

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
                            dgvfuncionario.DataSource = cFuncionario.ConsultaFuncionarioNomeInicio(txtpesquisar.Text);
                        }
                        else
                        {
                            dgvfuncionario.DataSource = cFuncionario.ConsultaFuncionarioNomeContem(txtpesquisar.Text);
                        }


                    }
                    break;
                //OPÇÃO do SEXO
                case "Sexo":
                    //Se o RADIO BUTTON SELECIONADO
                    if (rbf.Checked == true)
                    {
                        dgvfuncionario.DataSource = cFuncionario.ConsulaFuncionarioSexo("Feminino");
                    }
                    else
                    {
                        dgvfuncionario.DataSource = cFuncionario.ConsulaFuncionarioSexo("Masculino");
                    }
                    break;

                //OPÇÃO do CPF
                case "Cpf":
                    //validar se o usuario digitou cpf

                    if (mskcpf.Text != "   .   .   -")
                    {
                        dgvfuncionario.DataSource = cFuncionario.ConsultaFuncionarioCPF(mskcpf.Text);
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
                        dgvfuncionario.DataSource = cFuncionario.ConsultaFuncionarioStatus(1);
                    }
                    else
                    {
                        dgvfuncionario.DataSource = cFuncionario.ConsultaFuncionarioStatus(0);
                    }
                    break;
            }
        }

        private void dgvfuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉDULA, NÃO SOMENTE NO TEXTO)

            //VALIDAR SE USUÁRIO DESEJA REALIZAR EDIÇÃO OU EXCLUSÃO DO Funcionario SELECIONADO

            if (MessageBox.Show("Deseja alterar / excluir o Funcionario selecionado?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
           DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE FUNCIONARIO PARA USAR MÉTODOS E PROPRIEDADES
                classFuncionario cFuncionario = new
                classFuncionario();

                //INSTANCIAR O FORMUÁRIO DE CADASTRO/ ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                formFuncionario fFuncionario = new formFuncionario();

                //PEGAR O CÓDIGO DO CLIENTE SELECIONADO PEÇO USUARIO NA FRID 
                cFuncionario.ConsultarFuncionario(Convert.ToInt32(dgvfuncionario.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE FUNCIONARIO

                fFuncionario.txtcodigofuncionario.Text = cFuncionario.cod_func.ToString();
                fFuncionario.txtnome.Text = cFuncionario.nome.ToString();
                fFuncionario.mskrg.Text = cFuncionario.rg.ToString();
                fFuncionario.mskcpf.Text = cFuncionario.cpf.ToString();
                fFuncionario.mskdatanascimento.Text = cFuncionario.datanascimento.ToString();
                fFuncionario.txtrua.Text = cFuncionario.rua.ToString();
                fFuncionario.txtnumero.Text = cFuncionario.numero.ToString();
                fFuncionario.txtcomplemento.Text = cFuncionario.complemento.ToString();
                fFuncionario.txtbairro.Text = cFuncionario.bairro.ToString();
                fFuncionario.txtcidade.Text = cFuncionario.cidade.ToString();
                fFuncionario.estado = cFuncionario.estado.ToString();
                fFuncionario.mskcep.Text = cFuncionario.cep.ToString();
                fFuncionario.txtemail.Text = cFuncionario.email.ToString();
                fFuncionario.msktelefone.Text = cFuncionario.telefone.ToString();
                fFuncionario.mskcelular.Text = cFuncionario.celular.ToString();
                fFuncionario.datacad = cFuncionario.dt_cad;
                fFuncionario.cargo = cFuncionario.cod_carg;

                //SEXO
                if (cFuncionario.sexo == "Feminino")
                {
                    fFuncionario.rbf.Checked = true;
                    fFuncionario.rbm.Checked = false;
                }
                else
                {
                    fFuncionario.rbf.Checked = false;
                    fFuncionario.rbm.Checked = true;
                }

                //STATUS

                if (cFuncionario.status_func == 1)
                {
                    fFuncionario.ckstatus.Checked = true;
                }
                else
                {
                    fFuncionario.ckstatus.Checked = false;
                }
                //MANDAR A INFORMAÇÃO DE UPDATE
                fFuncionario.tipo = "Atualização";
                //DEPOIS DE ATUALIZAR FECHA O FORMULARIO
                fFuncionario.ShowDialog();
                //CHAMAR MÉTODO DE PESQUISA
                btpesquisar_Click(this, new EventArgs());
            }

        }
    }
}

// algumas pontuações das mensagens acrescentadas  por daniela 20-11-2021