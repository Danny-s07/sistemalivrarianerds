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
    public partial class formConsultaCategoria : Form
    {
        public formConsultaCategoria()
        {
            InitializeComponent();
        }

        private void formConsultacategoria_Load(object sender, EventArgs e)
        {
            //carregar a combo
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Status");

            //opção nome selecionada no campo
            cbOpcoes.SelectedItem = "Nome";

        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar e desabilitar controles do form de acordo com a escolha da pesquisa feita pelo usuario

            if (cbOpcoes.SelectedIndex == 0)//nome
            {
                txtPesquisa.Enabled = true;
                gbTipoPesquisa.Enabled = true;
                gbStatus.Enabled = false;
                txtPesquisa.Focus();
            }

            if (cbOpcoes.SelectedIndex == 1)//status
            {
                txtPesquisa.Enabled = false;
                gbTipoPesquisa.Enabled = false;
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
            // Instanciar classe categoria para usar metodos
            classCategoria cCategoria = new classCategoria();

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
                            dgvCategoria.DataSource = cCategoria.ConsultaCategoriaNomeInicio(txtPesquisa.Text);

                        }
                        else
                        {
                            dgvCategoria.DataSource = cCategoria.ConsultaCategoriaNomeContem(txtPesquisa.Text);
                        }

                    }
                    break;

                //opção status

                case "Status":
                    // se o radiun button selecionado
                    if (rbAtivo.Checked == true)
                    {
                        dgvCategoria.DataSource = cCategoria.ConsultaAutoresStatus(1);
                    }
                    else
                    {
                        dgvCategoria.DataSource = cCategoria.ConsultaAutoresStatus(0);
                    }
                    break;

            }
        }


        //clicar na grid de clientes e editar ou excluir um cliente
        //usar o evento celclick(pode clicar em qualquer lugar da celula, nao somente no texto)
        //usando o evento cellcontentclick(tem que clicar no conteudo(texto))
        //usando evento doubleclick(usuario precisa dar 2 cliques)
        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //validar se o usuario deseja realizar edicao ou exclusao do cliente selecionado
            if (MessageBox.Show("Deseja alterar/ excluir a categoria selecionada?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //instancia classe autor
                classCategoria cCategoria = new classCategoria();
                //instancia o formulario
                formCategoria fCategoria = new formCategoria();

                //pegar o codigo do autor selecionado pelo usuario na grid
                cCategoria.ConsultarCategoria(Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value));

                //passar os dados do bd para os controles do form de autores
                fCategoria.txtCodigo.Text = cCategoria.cod_cat.ToString();
                fCategoria.txtnome.Text = cCategoria.nome.ToString();
                fCategoria.datacad = cCategoria.dt_cad;

                 //status
                if (cCategoria.status_cat == 1)
                {
                    fCategoria.ckStatus.Checked = true;
                }
                else
                {
                    fCategoria.ckStatus.Checked = false;
                }




                //mandar a informacao no update
                fCategoria.tipo = "Atualização";
                //depois de atualizar fechar o form
                fCategoria.ShowDialog();
                //chamar o metodo pesquisar
                btPesquisar_Click(this, new EventArgs());


            }
        }
    }
}
