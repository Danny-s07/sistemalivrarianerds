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
    public partial class formConsultaCargo : Form
    {
        public formConsultaCargo()
        {
            InitializeComponent();
        }

        private void formConsultaCargo_Load(object sender, EventArgs e)
        {
            {
                cbopcoes.Items.Add("Nome");
                cbopcoes.Items.Add("Status");

                //opção nome selecionada no campo
                cbopcoes.SelectedItem = "Nome";
            }
        }

        private void cbopcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario
            if (cbopcoes.SelectedIndex == 0)//nome
            {
                txtpesquisar.Enabled = true;
                gbtipopesquisa.Enabled = true;
                 gbstatus.Enabled = false;
                txtpesquisar.Focus();
            }

            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario
            if (cbopcoes.SelectedIndex == 1)//status
            {
                txtpesquisar.Enabled = false;
                gbtipopesquisa.Enabled = false;
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
            classCargo cCargo = new classCargo();

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
                            dgvcargos.DataSource = cCargo.ConsultaCargosNomeinicio(txtpesquisar.Text);
                        }
                        else
                        {
                            dgvcargos.DataSource = cCargo.ConsultarCargosNomeContem
                            (txtpesquisar.Text);
                        }

                    }
                    break;

                //OPÇÃO STATUS
                case "Status":
                    //SE O RADIO BUTTON SELECIONADO
                    if (rbativo.Checked == true)
                    {
                        dgvcargos.DataSource = cCargo.ConsultaCargosStatus(1);
                    }
                    else
                    {
                        dgvcargos.DataSource = cCargo.ConsultaCargosStatus(0);
                    }
                    break;

            }
        }

        private void dgvcargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //USAR O EVENTO CELLCLICK (PODE CLICAR EM QUALQUER LUGAR DA CÉDULA, NÃO SOMENTE NO TEXTO)

            //VALIDAR SE USUÁRIO DESEJA REALIZAR EDIÇÃO OU EXCLUSÃO DO Funcionario SELECIONADO

            if (MessageBox.Show("Deseja alterar / excluir o Cargo selecionado ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
           DialogResult.Yes)
            {
                //INSTANCIAR A CLASSE FUNCIONARIO PARA USAR MÉTODOS E PROPRIEDADES
                classCargo cCargos = new
                classCargo();

                //INSTANCIAR O FORMUÁRIO DE CADASTRO/ ATUALIZAÇÃO DE CLIENTE PARA USAR OS CONTROLES DO FORM
                formCargo fCargos = new formCargo();

                //PEGAR O CÓDIGO DO CLIENTE SELECIONADO PEÇO USUARIO NA FRID 
                cCargos.ConsultarCargos(Convert.ToInt32(dgvcargos.SelectedRows[0].Cells[0].Value));

                //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE FUNCIONARIO

                //PASSAR OS DADOS DO BD PARA OS CONTROLES DO FORM DE FUNCIONARIO

                fCargos.txtcodigocargo.Text = cCargos.cod_carg.ToString();
                fCargos.txtnome.Text = cCargos.nome.ToString();
                fCargos.datacad = cCargos.dt_cad;


                //STATUS

                if (cCargos.status_carg == 1)
                {
                    fCargos.ckstatus.Checked = true;
                }
                else
                {
                    fCargos.ckstatus.Checked = false;
                }
                //MANDAR A INFORMAÇÃO DE UPDATE
                fCargos.tipo = "Atualização";
                //DEPOIS DE ATUALIZAR FECHA O FORMULARIO
                fCargos.ShowDialog();
                //CHAMAR MÉTODO DE PESQUISA
                btpesquisar_Click(this, new EventArgs());
            }

        }
        
    }
}

//pontuações das mensagens acrescentadas  por daniela 20-11-2021