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
    public partial class formRelCliente : Form
    {
        public formRelCliente()
        {
            InitializeComponent();
        }

        private void RelCliente_Load(object sender, EventArgs e)
        {


            //carregar combo categoria
            classCliente cCliente = new classCliente();
            //combo recebendo select
            cbcidade.DataSource = cCliente.RelCarregarcidade();
            //exibir na combo para usuario
            cbcidade.DisplayMember = "cidade";
            //armazenar no bd o codigo (fk)
            cbcidade.ValueMember = "cidade";
            //nao deixar nenhuma categoria selecionada
            cbcidade.SelectedIndex = -1;



            //carregar combo tipo
            cbtipo.Items.Add("Aniversariantes por Dia e Mês");
            cbtipo.Items.Add("Aniversariantes do Mês");
            cbtipo.Items.Add("Idade");
            cbtipo.Items.Add("Cidade");
            cbtipo.Items.Add("Sexo");
            cbtipo.Items.Add("Status");
            //deixar a opcao sp selecionada
            cbtipo.SelectedIndex = 0;


            //carregar combo dia
            cbdia.Items.Add("Escolha um Dia");
            cbdia.Items.Add(01);
            cbdia.Items.Add(02);
            cbdia.Items.Add(03);
            cbdia.Items.Add(04);
            cbdia.Items.Add(05);
            cbdia.Items.Add(06);
            cbdia.Items.Add(07);
            cbdia.Items.Add(08);
            cbdia.Items.Add(09);
            cbdia.Items.Add(10);
            cbdia.Items.Add(11);
            cbdia.Items.Add(12);
            cbdia.Items.Add(13);
            cbdia.Items.Add(14);
            cbdia.Items.Add(15);
            cbdia.Items.Add(16);
            cbdia.Items.Add(17);
            cbdia.Items.Add(18);
            cbdia.Items.Add(19);
            cbdia.Items.Add(20);
            cbdia.Items.Add(21);
            cbdia.Items.Add(22);
            cbdia.Items.Add(23);
            cbdia.Items.Add(24);
            cbdia.Items.Add(25);
            cbdia.Items.Add(26);
            cbdia.Items.Add(27);
            cbdia.Items.Add(28);
            cbdia.Items.Add(29);
            cbdia.Items.Add(30);
            cbdia.Items.Add(31);
            //deixar a opcao sp selecionada

            cbdia.SelectedIndex = 0;
            cbdia.MaxDropDownItems = 10;


            //carregar combo do mes
            cbmes.Items.Add("Escolha um Mês");
            cbmes.Items.Add("Janeiro");
            cbmes.Items.Add("Fevereiro");
            cbmes.Items.Add("Março");
            cbmes.Items.Add("Abril");
            cbmes.Items.Add("Maio");
            cbmes.Items.Add("Junho");
            cbmes.Items.Add("Julho");
            cbmes.Items.Add("Agosto");
            cbmes.Items.Add("Setembro");
            cbmes.Items.Add("Outubro");
            cbmes.Items.Add("Novembro");
            cbmes.Items.Add("Dezembro");
            //deixar a opcao sp selecionada
            cbmes.SelectedIndex = 0;


            //carregar combo do sexo
            cbsexo.Items.Add("Escolha um Sexo");
            cbsexo.Items.Add("Feminino");
            cbsexo.Items.Add("Masculino");
            //deixar a opcao sp selecionada
            cbsexo.SelectedIndex = 0;

            this.rptvcliente.RefreshReport();


        }

        private void btgerarRelatorio_Click(object sender, EventArgs e)
        {
            //Instanciar classe cliente para usar metodos 
            classCliente cCliente = new classCliente();

            //criar variavel para ler a opcao escolhida pelo usuario
            string gerar = cbtipo.SelectedItem.ToString();

            switch (gerar)
            {

                //OPÇÃO NOME
                case "Aniversariantes por Dia e Mês":

                    if (cbdia.SelectedIndex != 0 && cbmes.SelectedIndex != 0)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteAniversarioDiaMes(cbdia.SelectedIndex, cbmes.SelectedIndex);
                        this.rptvcliente.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Por Favor escolher um dia e um mês", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                case "Aniversariantes do Mês":

                    if (cbmes.SelectedIndex != 0)
                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteAniversariMes(cbmes.SelectedIndex);
                        this.rptvcliente.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher um mês!", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                case "Idade":


                    if (txtDe.Text != "" && txtAte.Text != "")
                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteidade(Convert.ToInt32(txtDe.Text), Convert.ToInt32(txtAte.Text));
                        this.rptvcliente.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Por Favor Preencher uma idade!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    break;


                case "Cidade":

                    if (cbcidade.SelectedIndex != -1)// alterado por Daniela  dia 19/11/2021  estava zero e tinha que por -1
                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteCidade(cbcidade.SelectedValue.ToString());
                        this.rptvcliente.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Por Favor Preencher uma cidade!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    break;


                case "Sexo":

                    if (cbsexo.SelectedIndex != -1)

                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteSexo(cbsexo.SelectedItem.ToString());
                        this.rptvcliente.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Por Favor Preencher um sexo!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;


                case "Status":

                    if (rbativo.Checked == true)

                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteStatus(1);
                        this.rptvcliente.RefreshReport();
                    }
                    else

                    {
                        classClienteBindingSource.DataSource = cCliente.RelClienteStatus(0);
                        this.rptvcliente.RefreshReport();
                    }

                    break;

            }
        }

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //HABILITAR E DESABILITAR CONTROLES DO FORM DE CACOTDO COM A ESCOLGHA DE PESQUISA FEITA PELO USUARIO

            if (cbtipo.SelectedIndex == 0 ) //por dia e mês
            {
                gbaniversariantes.Enabled = true;
                cbdia.Enabled = true;
                cbmes.Enabled = true;
                gbidade.Enabled = false;
                gbcidade.Enabled = false;
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;
                
            }
            if (cbtipo.SelectedIndex == 1) //por mês
            {
                gbaniversariantes.Enabled = true;
                cbdia.Enabled = false;
                cbmes.Enabled = true;
                gbcidade.Enabled = false;
                gbidade.Enabled = false;
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;

            }
            if (cbtipo.SelectedIndex == 2) //por idade
            {
                gbaniversariantes.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                gbcidade.Enabled = false;
                gbidade.Enabled = true;
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;
            }

            if (cbtipo.SelectedIndex == 3) //POR CIDADE
            {
                gbaniversariantes.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                gbcidade.Enabled = true;
                gbidade.Enabled = false;
                gbsexo.Enabled = false;
                gbstatus.Enabled = false;

            }

            if (cbtipo.SelectedIndex == 4) //POR SEXO
            {
                gbaniversariantes.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                gbcidade.Enabled = false;
                gbidade.Enabled = false;
                gbsexo.Enabled = true;
                gbstatus.Enabled = false;

            }
            if (cbtipo.SelectedIndex == 5) //POR STATUS
            {
                gbaniversariantes.Enabled = false;
                cbdia.Enabled = false;
                cbmes.Enabled = false;
                gbcidade.Enabled = false;
                gbidade.Enabled = false;
                gbsexo.Enabled = false;
                gbstatus.Enabled = true;
                
            }
        }

        //eventos key press a baixo adicionados por daniela 20-11-2021
        private void txtDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se a tecla digitada nao for numero, BACKSPACE(08), ENTER(13), eSPAÇO(32) 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //se o usuario pressionar tecla numerica e a de virgula no txtbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAte_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se a tecla digitada nao for numero, BACKSPACE(08), ENTER(13), eSPAÇO(32) 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //se o usuario pressionar tecla numerica e a de virgula no txtbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
    
