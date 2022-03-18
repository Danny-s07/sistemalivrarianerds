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
    public partial class formAutores : Form
    {
        public formAutores()
        {
            InitializeComponent();
        }

        //variavel tipo: guardar como o formulario deve ser aberto se para cadastro ou atualizar/excluir
        //variavel estado: informação é mostrada em uma combo 
        public string tipo;

        //variavel datacad: mostra informação guardada no bd e nao a data atual como programado no load do form
        public DateTime datacad;



        private void formAutores_Load(object sender, EventArgs e)
        {
            //carregar data na label
            lbdata.Text = DateTime.Now.ToShortDateString();

            //quando abrir o formulario para atualizar e excluir
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Autor";
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
            rbf.Checked = true;
            txtemail.Clear();
            msktelefone.Clear();
            mskcelular.Clear();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //lembrar que os campos do tipo numero e data nao pode ser vazio
            //caso nao seja obrigatorio no bd fazer um if para mandar o (numero) e uma data

            //instanciando a classe cliente para usar pripriedades e metodos
            classAutores cAutores = new classAutores();
            if (txtnome.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      -"))
            {
                cAutores.nome = txtnome.Text;
                cAutores.email = txtemail.Text;

                //radiobutton
                if (rbf.Checked)
                {
                    cAutores.sexo = "Feminino";
                }
                else
                {
                    cAutores.sexo = "Masculino";
                }


                //telefone residencial
                if (msktelefone.Text != "(  )     -")
                {
                    cAutores.telefone = msktelefone.Text;
                }
                else
                {
                    cAutores.telefone = "";
                }
                //telefone celuar
                if (mskcelular.Text != "(  )      -")
                {
                    cAutores.celular = mskcelular.Text;
                }
                else
                {
                    cAutores.celular = "";
                }

                //chamar metodo pra cadasstrar  que esta na classe cliente
                int resp = cAutores.CadastrarAutor();

                // se o cadastro der certo
                if (resp == 1)
                {
                    MessageBox.Show("Autor  : " + cAutores.nome + " cadastrado com sucesso !", "Livraria nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar metodo de limpar 
                    Limpar();
                }
                else
                {
                    MessageBox.Show(" Erro ao realizar cadastro !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor prencher todos os campos obrigatorios !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                mskcelular.BackColor = Color.LemonChiffon;
                msktelefone.BackColor = Color.LemonChiffon;
                txtnome.Focus();

            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            //lembrar que os campos do tipo numero e data nao pode ser vazio
            //caso nao seja obrigatorio no bd fazer um if para mandar o (numero) e uma data

            //instanciando a classe cliente para usar pripriedades e metodos
            classAutores cAutores = new classAutores();
            if (txtnome.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      -"))
            {
                cAutores.nome = txtnome.Text;
                cAutores.email = txtemail.Text;

                //radiobutton
                if (rbf.Checked)
                {
                    cAutores.sexo = "Feminino";
                }
                else
                {
                    cAutores.sexo = "Masculino";
                }

                //status
                if(ckStatus.Checked == true)
                {
                    cAutores.status_aut = 1;
                }
                else
                {
                    cAutores.status_aut = 0;
                }



                //telefone residencial
                if (msktelefone.Text != "(  )     -")
                {
                    cAutores.telefone = msktelefone.Text;
                }
                else
                {
                    cAutores.telefone = "";
                }
                //telefone celuar
                if (mskcelular.Text != "(  )      -")
                {
                    cAutores.celular = mskcelular.Text;
                }
                else
                {
                    cAutores.celular = "";
                }

                //status
                if (ckStatus.Checked == true)
                {
                    cAutores.status_aut = 1;
                }
                else
                {
                    cAutores.status_aut = 0;
                }

                //carregar o codigo autor
                cAutores.cod_aut = Convert.ToInt32(txtCodigo.Text);

                //chamar metodo pra atualizar  que esta na classe cliente
                bool resp = cAutores.AtualizarAutores();

                // se o cadastro der certo
                if (resp == true)
                {
                    MessageBox.Show("Autor  : " + cAutores.nome + " atualizado com sucesso !", "Livraria nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar metodo de limpar 
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Erro ao realizar atualizar ! ", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor prencher todos os campos obrigatorios !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                mskcelular.BackColor = Color.LemonChiffon;
                msktelefone.BackColor = Color.LemonChiffon;
                txtnome.Focus();

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Autor ? ", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                classAutores cAutor = new classAutores();
                cAutor.cod_aut = Convert.ToInt32(txtCodigo.Text);
                bool resp = cAutor.ExcluirAutores();
                if(resp == true)
                {
                    MessageBox.Show("Autor" + cAutor.nome + "excluido com sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Autor não pode ser excluido,ha registros em outras tabelas !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
