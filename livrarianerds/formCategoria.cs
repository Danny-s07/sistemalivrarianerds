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
    public partial class formCategoria : Form
    {
        public formCategoria()
        {
            InitializeComponent();
        }
        //variavel tipo: guardar como o formulario deve ser aberto se para cadastro ou atualizar/excluir
        //variavel estado: informação é mostrada em uma combo 
        public string tipo;

        //variavel datacad: mostra informação guardada no bd e nao a data atual como programado no load do form
        public DateTime datacad;

        private void formCategoria_Load(object sender, EventArgs e)
        {

            //carregar data na label
            lbdata.Text = DateTime.Now.ToShortDateString();
            // quando abrir o formulario para atualizar e excluir
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Categoria";
                btCadastrar.Enabled = false;
                ckStatus.Enabled = true;
                lbdata.Text = datacad.ToString();
            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void Limpar()
        {
            txtnome.Clear();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();
            if (txtnome.Text != "")
            {
                cCategoria.nome = txtnome.Text;

                //chamar metodo pra cadasstrar  que esta na classe cliente
                int resp = cCategoria.CadastrarCategoria();

                // se o cadastro der certo
                if (resp == 1)
                {
                    MessageBox.Show("Categoria "  + cCategoria.nome +  " cadastrado com sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar metodo de limpar 
                    Limpar();
                }
                else
                {
                    MessageBox.Show(" Categoria já cadastrada !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else // se não preencher todos os campos obrigatorios
            {
                MessageBox.Show("Favor prencher todos os campos obrigatorios !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.AliceBlue;
                txtnome.Focus();
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();
            if (txtnome.Text != "")
            {
                cCategoria.nome = txtnome.Text;
                //status
                if (ckStatus.Checked == true)
                {
                    cCategoria.status_cat = 1;
                }
                else
                {
                    cCategoria.status_cat = 0;
                }


                //carregar o codigo autor
                cCategoria.cod_cat = Convert.ToInt32(txtCodigo.Text);

                //chamar metodo pra cadasstrar  que esta na classe cliente
                bool resp = cCategoria.AtualizarCategoria();

                // se o cadastro der certo
                if (resp == true)
                {
                    MessageBox.Show("Categoria" + cCategoria.nome + " atualizado  com sucesso ! ", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar metodo de limpar 
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Erro ao atualizar !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a Categoria ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                classCategoria cCategoria = new classCategoria();
                cCategoria.cod_cat = Convert.ToInt32(txtCodigo.Text);
                bool resp = cCategoria.ExcluirCategoria();
                if (resp == true)
                {
                    MessageBox.Show("Categoria" + cCategoria.nome + " excluida com sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Esta Categoria não pode ser excluido,ha registros em outras tabelas !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }   }

