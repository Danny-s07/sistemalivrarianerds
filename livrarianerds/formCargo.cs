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
    public partial class formCargo : Form
    {
        public formCargo()
        {
            InitializeComponent();
        }
        //variavel tipo: guardar como o formulario deve ser aberto se para cadastro ou atualizar/excluir
        //variavel estado: informação é mostrada em uma combo 
        public string tipo;

        //variavel datacad: mostra informação guardada no bd e nao a data atual como programado no load do form
        public DateTime datacad;
        private void btsaircargo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", " Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Limpar()

        {
            txtnome.Clear();
            txtnome.Focus();
        }





        private void btcadastrar_Click(object sender, EventArgs e)
        {
            //CRIEI O OBJETO DA CLASSE CARGO
            classCargo cCargo = new classCargo();

            if (txtnome.Text != "")
            {
                cCargo.nome = txtnome.Text;
                // CHAMAR METODO PARA CADASTRAR - CLASSE Cargo
                int resp = cCargo.CadastrarCargo();

                // SE O CADASTRO DER CERTO 
                if (resp == 1)
                {
                    MessageBox.Show("Cargo: " + cCargo.nome + "Cadastrado com Sucesso !", " Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //CHAMAR MÉTODO DE LIMPAR 
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Cargo já cadastro !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


            else
            {
                // COLOCANDO A MENSSAGEM E AS CORES
                MessageBox.Show("Favor preencher todos os campos, obrigatórios !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                txtnome.Focus();

            }
                    


                                                               

        }

        private void formCargo_Load(object sender, EventArgs e)
        {
            
            //CARREGAR DATA NA LABEL
            lbdata.Text = DateTime.Now.ToShortDateString();

            //QUANDO BRIR O FORMNÁRIO PARA ATUALIZAR EXCLUIR
            if (tipo == "Atualização")

            {
                lbTitulo.Text = "Atualização de Cargo";
                btcadastrar.Enabled = false;
                ckstatus.Enabled = true;
                lbdata.Text = datacad.ToString();
               
            }
            else

            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
                
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            //CRIEI O OBJETO DA CLASSE CARGO
            classCargo cCargo = new classCargo();

            if (txtnome.Text != "")



            {
                cCargo.nome = txtnome.Text;

                //STATUS
                if(ckstatus.Checked == true)
                {

                    cCargo.status_carg = 1;

                }
                else
                {
                    cCargo.status_carg = 0;

                }

                cCargo.cod_carg = Convert.ToInt32(txtcodigocargo.Text);

                

                // CHAMAR METODO PARA CADASTRAR - CLASSE Cargo
                bool resp = cCargo.AtualizarCargos();

                // SE O CADASTRO DER CERTO 
                if (resp == true)
                {
                    MessageBox.Show("Cargo: " + cCargo.nome + "Atualizado com Sucesso !", " Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //CHAMAR MÉTODO DE LIMPAR 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao realizar atualizar !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o cargo ?", "Livraria Nerds!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCargo cCargo= new classCargo();
                cCargo.cod_carg = Convert.ToInt32(txtcodigocargo.Text);

                bool resp = cCargo.ExcluirCargos();

                if (resp == true)
                {
                    MessageBox.Show("Cargo" + cCargo.nome + "Exluido com Sucesso.", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Cargo não pode ser excluido, há registro em outras tabaela !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

//pontuações das mensagens acrescentadas  por daniela 20-11-2021