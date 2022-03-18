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
    public partial class formRelAutores : Form
    {
        public formRelAutores()
        {
            InitializeComponent();
        }

        private void formRelAutores_Load(object sender, EventArgs e)
        {
            //carregar a combo de selecionar as opcoes
            cbTipoRel.Items.Add("Data Cadastro");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            //deixar a opcao sp selecionada
            cbTipoRel.SelectedItem = "Data Cadastro";

            //carregar combo do sexo
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            //deixar a opcao sp selecionada
            cbSexo.SelectedIndex = 0;

            

            this.rptAutor.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario
            if (cbTipoRel.SelectedIndex == 0)//data cadastro
            {
                gbDataCadastro.Enabled = true;
                gbSexo.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 1)//sexo
            {
                gbDataCadastro.Enabled = false;
                gbSexo.Enabled = true;
                gbStatus.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 2)//status
            {
                gbDataCadastro.Enabled = false;
                gbSexo.Enabled = false;
                gbStatus.Enabled = true;
            }


        }

        private void btGerarRelat_Click(object sender, EventArgs e)
        {
            //Instanciar classe autor para usar metodos 
            classAutores cAutor = new classAutores();

            //criar variavel para ler a opcao escolhida pelo usuario
            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch (relatorio)
            {
                //opcao data cadastro
                case "Data Cadastro":

                    if (mskDe.Text != "  /  /" && mskAte.Text != "  /  /")
                    {
                        classAutoresBindingSource.DataSource = cAutor.RelAutorDataCadastro(Convert.ToDateTime(mskDe.Text), Convert.ToDateTime(mskAte.Text));
                        this.rptAutor.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Digite as datas de cadastro  inicial e final !", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;

                    //opcao de sexo
                case "Sexo":
                    if(cbSexo.Text != "Escolha um Sexo")
                    {
                        classAutoresBindingSource.DataSource = cAutor.RelAutorSexo(cbSexo.SelectedItem.ToString());
                        this.rptAutor.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Escolha um sexo !", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                //opcao de status
                case "Status":
                    if (rbAtivo.Checked == true)
                    {
                        classAutoresBindingSource.DataSource = cAutor.RelAutorStatus(1);
                        this.rptAutor.RefreshReport();
                    }
                    else
                    {
                        classAutoresBindingSource.DataSource = cAutor.RelAutorStatus(0);
                        this.rptAutor.RefreshReport();
                    }

                    break;


            }



        }
    }
}
