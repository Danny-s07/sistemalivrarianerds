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
    public partial class formFornecedores : Form
    {
        public formFornecedores()
        {
            InitializeComponent();
        }

        //variavel tipo: guardar como o formulario deve ser aberto se para cadastro ou atualizar/excluir
        //variavel estado: informação é mostrada em uma combo 
        public string tipo, estado;

        //variavel datacad: mostra informação guardada no bd e nao a data atual como programado no load do form
        public DateTime datacad;
        private void formFornecedores_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add("AC");
            cbestado.Items.Add("AL");
            cbestado.Items.Add("AP");
            cbestado.Items.Add("AM");
            cbestado.Items.Add("BA");
            cbestado.Items.Add("CE");
            cbestado.Items.Add("ES");
            cbestado.Items.Add("GO");
            cbestado.Items.Add("MA");
            cbestado.Items.Add("MT");
            cbestado.Items.Add("MS");
            cbestado.Items.Add("MG");
            cbestado.Items.Add("PA");
            cbestado.Items.Add("PB");
            cbestado.Items.Add("PR");
            cbestado.Items.Add("PE");
            cbestado.Items.Add("PI");
            cbestado.Items.Add("RJ");
            cbestado.Items.Add("RN");
            cbestado.Items.Add("RS");
            cbestado.Items.Add("RO");
            cbestado.Items.Add("RR");
            cbestado.Items.Add("SC");
            cbestado.Items.Add("SP");
            cbestado.Items.Add("SE");
            cbestado.Items.Add("TO");
            cbestado.Items.Add("DF");



            //colocar os itens em ordem alfabetica
            cbestado.Sorted = true;
            //deixar a opcao sp selecionada
            cbestado.SelectedItem = "SP";
            //nenhuma opcao selecionada
            //cbEstado.SelectdIndex = -1

            //carregar data na label
            lbdata.Text = DateTime.Now.ToShortDateString();


            //quando abrir o formulario para atualizar excluir
            if (tipo == "Atualização")
            {
                lbTitulo.Text = "Atualização de Fornecedores";
                btCadastrar.Enabled = false;
                ckStatus.Enabled = true;
                cbestado.SelectedItem = estado;
                lbdata.Text = datacad.ToString();
            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }

         }

        private void Limpar()
        {
            txtnome.Clear();
            rbf.Checked = true;
            txtrua.Clear();
            txtnumero.Clear();
            txtcomplemento.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            cbestado.SelectedItem = "SP";
            mskcep.Clear();
            txtemail.Clear();
            msktelefone.Clear();
            mskcelular.Clear();
            txtnome.Clear();
            mskcnpj.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //lembrar que os campos do tipo numero e data nao pode ser vazio
            //caso nao seja obrigatorio no bd fazer um if para mandar o (numero) e uma data

            //instanciando a classe fornecedor para usar pripriedades e metodos
            classFornecedor cFornecedor = new classFornecedor();

            //validar campos obrigatorios
            //preencher pelo menos um telefone
            if (txtnome.Text != "" && mskcnpj.Text != "" && txtrua.Text != "" && txtnumero.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      -"))
            {
                //passar para a propriedade o conteudo do formulario
                //todos os campos que o usuario pode preencher
                cFornecedor.nome = txtnome.Text;
                cFornecedor.email = txtemail.Text;
                cFornecedor.cnpj = mskcnpj.Text;
                cFornecedor.rua = txtrua.Text;
                cFornecedor.numero = Convert.ToInt32(txtnumero.Text);
                cFornecedor.bairro = txtbairro.Text;
                cFornecedor.cidade = txtcidade.Text;
                cFornecedor.estado = cbestado.SelectedItem.ToString();

                //radiobutton
                if (rbf.Checked)
                {
                    cFornecedor.sexo = "Feminino";
                }
                else
                {
                    cFornecedor.sexo= "Masculino";
                }

                //mascaras que não sao campo obrigatorio
                if (mskcep.Text != "     -")
                {
                    cFornecedor.cep = mskcep.Text;
                }
                else
                {
                    cFornecedor.cep = "";
                }

                //telefone 
                if (msktelefone.Text != "(  )     -")
                {
                    cFornecedor.telefone = msktelefone.Text;
                }
                else
                {
                    cFornecedor.telefone= "";
                }
                //celuar
                if (mskcelular.Text != "(  )      -")
                {
                    cFornecedor.celular= mskcelular.Text;
                }
                else
                {
                   cFornecedor.celular = "";
                }

                               
                //chamar metodo pra cadasstrar  que esta na classe cliente
                int resp = cFornecedor.CadastrarFornecedor();

                // se o cadastro der certo
                if (resp == 1)
                {
                    MessageBox.Show("Fornecedores : " + cFornecedor.nome + " cadastrado com sucesso !", " Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar metodo de limpar 
                    Limpar();
                }
                else
                {
                    MessageBox.Show(" Erro ao realizar cadastro !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            
            else // se não preencher todos os campos obrigatorios
            {
                MessageBox.Show("Favor prencher todos os campos obrigatorios !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                txtrua.BackColor = Color.LemonChiffon;
                txtnumero.BackColor = Color.LemonChiffon;
                msktelefone.BackColor = Color.LemonChiffon;
                mskcelular.BackColor = Color.LemonChiffon;
                mskcnpj.BackColor = Color.LemonChiffon;
                txtnome.Focus();
            }

        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            //lembrar que os campos do tipo numero e data nao pode ser vazio
            //caso nao seja obrigatorio no bd fazer um if para mandar o (numero) e uma data

            //instanciando a classe fornecedor para usar pripriedades e metodos
            classFornecedor cFornecedor = new classFornecedor();

            //validar campos obrigatorios
            //preencher pelo menos um telefone
            if (txtnome.Text != "" && mskcnpj.Text != "" && txtrua.Text != "" && txtnumero.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      -"))
            {
                //passar para a propriedade o conteudo do formulario
                //todos os campos que o usuario pode preencher
                cFornecedor.nome = txtnome.Text;
                cFornecedor.email = txtemail.Text;
                cFornecedor.cnpj = mskcnpj.Text;
                cFornecedor.rua = txtrua.Text;
                cFornecedor.numero = Convert.ToInt32(txtnumero.Text);
                cFornecedor.bairro = txtbairro.Text;
                cFornecedor.cidade = txtcidade.Text;
                cFornecedor.estado = cbestado.SelectedItem.ToString();

                //radiobutton
                if (rbf.Checked)
                {
                    cFornecedor.sexo = "Feminino";
                }
                else
                {
                    cFornecedor.sexo = "Masculino";
                }

                //mascaras que não sao campo obrigatorio
                if (mskcep.Text != "     -")
                {
                    cFornecedor.cep = mskcep.Text;
                }
                else
                {
                    cFornecedor.cep = "";
                }

                //telefone 
                if (msktelefone.Text != "(  )     -")
                {
                    cFornecedor.telefone = msktelefone.Text;
                }
                else
                {
                    cFornecedor.telefone = "";
                }
                //celuar
                if (mskcelular.Text != "(  )      -")
                {
                    cFornecedor.celular = mskcelular.Text;
                }
                else
                {
                    cFornecedor.celular = "";
                }

                
                //status
                if (ckStatus.Checked == true)
                {
                    cFornecedor.status_forn = 1;
                }
                else
                {
                    cFornecedor.status_forn = 0;
                }

                //carregar o codigo do fornecedor
                cFornecedor.cod_forn = Convert.ToInt32(txtCodigoFornecedor.Text);

                 //chamar metodo pra cadasstrar  que esta na classe fornecedor
                bool resp = cFornecedor.AtualizarFornecedor();

                // se o cadastro der certo
                if (resp == true)
                {
                    MessageBox.Show("Fornecedores : " + cFornecedor.nome + " Atualização com sucesso ! ", " Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //chamar metodo de fechar 
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Erro ao  Atualizar cadastro !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            else // se não preencher todos os campos obrigatorios
            {
                MessageBox.Show("Favor prencher todos os campos obrigatorios !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                txtrua.BackColor = Color.LemonChiffon;
                txtnumero.BackColor = Color.LemonChiffon;
                msktelefone.BackColor = Color.LemonChiffon;
                mskcelular.BackColor = Color.LemonChiffon;
                mskcnpj.BackColor = Color.LemonChiffon;
                txtnome.Focus();
            }

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Fornecedor ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classFornecedor cFornecedor = new classFornecedor();
                cFornecedor.cod_forn = Convert.ToInt32(txtCodigoFornecedor.Text);
                bool resp = cFornecedor.ExcluirFornecedores();

                if (resp == true)
                {
                    MessageBox.Show("Fornecedor" + cFornecedor.nome + "excluido com sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Fornecedor não pode ser excluido,ha registros em outras tabelas !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        
        
        
        
        
        
        
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se a tecla digitada nao for numero , bacspace(08), enter(13) e espaço(32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //se o usuario pressionar uma tecla não numerica no tetxbox, cancela o evento key press
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Numeros !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
