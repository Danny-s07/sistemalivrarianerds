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
    public partial class formConsultaAutores : Form
    {
        public formConsultaAutores()
        {
            InitializeComponent();
        }

        private void formConsultaAutores_Load(object sender, EventArgs e)
        {
            //Carregar combo com as opções de pesquisa de autores
             cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Status");

            //opção nome selecionada no campo
            cbOpcoes.SelectedItem = "Nome";
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario

            if(cbOpcoes.SelectedIndex == 0)//nome
            {
                txtPesquisa.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                txtPesquisa.Focus();
            }

            if (cbOpcoes.SelectedIndex == 1)//sexo
            {
                txtPesquisa.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
            }

            if (cbOpcoes.SelectedIndex == 2)//status
            {
                txtPesquisa.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
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
            //Instanciar classe autores para usar metodos 
            classAutores cAutores = new classAutores();

            //criar variavel para ler a opcao escolhida pelo usuario
            string consulta = cbOpcoes.SelectedItem.ToString();

            switch (consulta)
            {
                //opção nome
                case "Nome":
                    
                    if (txtPesquisa.Text != "")
                    {
                        //verificar rb selecionado se for inicio ou contem 
                        if (rbInicio.Checked == true)
                        {
                            dgvAutores.DataSource = cAutores.ConsultaAutoresNomeInicio(txtPesquisa.Text);

                        }
                        else
                        {
                            dgvAutores.DataSource = cAutores.ConsultaAutoresNomeContem(txtPesquisa.Text);
                        }

                    }
                    break;

                //opção sexo
                case "Sexo":

                    // se o radiun button selecionado
                    if (rbf.Checked == true)
                    {
                        dgvAutores.DataSource = cAutores.ConsultaAutoresSexo("Feminino");
                    }
                    else
                    {
                        dgvAutores.DataSource = cAutores.ConsultaAutoresSexo("Masculino");
                    }
                    break;

                //opção status

                case "Status":
                    // se o radiun button selecionado
                    if(rbAtivo.Checked == true)
                    {
                        dgvAutores.DataSource = cAutores.ConsultaAutoresStatus(1);
                    }
                    else
                    {
                        dgvAutores.DataSource = cAutores.ConsultaAutoresStatus(0);
                    }
                    break;

            }

        }


        //clicar na grid de clientes e editar ou excluir um cliente
        //usar o evento celclick(pode clicar em qualquer lugar da celula, nao somente no texto)
        //usando o evento cellcontentclick(tem que clicar no conteudo(texto))
        //usando evento doubleclick(usuario precisa dar 2 cliques)

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //validar se o usuario deseja realizar edicao ou exclusao do cliente selecionado
            if (MessageBox.Show("Deseja alterar/ excluir o autor selecionado?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //instancia classe autor
                classAutores cAutores = new classAutores();
                //instancia o formulario
               formAutores fAutores = new formAutores();

                //pegar o codigo do autor selecionado pelo usuario na grid
                cAutores.ConsultarAutores(Convert.ToInt32(dgvAutores.SelectedRows[0].Cells[0].Value));

                //passar os dados do bd para os controles do form de autores
                fAutores.txtCodigo.Text = cAutores.cod_aut.ToString();
                fAutores.txtnome.Text = cAutores.nome.ToString();
                fAutores.msktelefone.Text = cAutores.telefone.ToString();
                fAutores.mskcelular.Text = cAutores.celular.ToString();
                fAutores.txtemail.Text = cAutores.email.ToString();
                fAutores.datacad = cAutores.dt_cad;

                //radio buttun sexo
                if(cAutores.sexo == "Feminino")
                {
                    fAutores.rbf.Checked = true;
                    fAutores.rbm.Checked = false;
                }
                else
                {
                    fAutores.rbf.Checked = false;
                    fAutores.rbm.Checked = true;
                }

                
                //status
                if (cAutores.status_aut == 1)
                {
                    fAutores.ckStatus.Checked = true;
                }
                else
                {
                    fAutores.ckStatus.Checked = false;
                }




                //mandar a informacao no update
                fAutores.tipo = "Atualização";
                //depois de atualizar fechar o form
                fAutores.ShowDialog();
                //chamar o metodo pesquisar
                btPesquisar_Click(this, new EventArgs());


            }




        }
    }
}
