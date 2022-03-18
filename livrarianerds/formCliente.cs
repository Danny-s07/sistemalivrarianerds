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
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        }
        //variavel tipo: guardar como o formulario deve ser aberto se para cadastro ou atualizar/excluir
        //variavel estado: informação é mostrada em uma combo 
        public string tipo, estado;

        //variavel datacad: mostra informação guardada no bd e nao a data atual como programado no load do form
        public DateTime datacad;

        private void formCliente_Load(object sender, EventArgs e)
        {

            //Carregando a combo
            cbestado.Items.Add("AC");
            cbestado.Items.Add("AL");
            cbestado.Items.Add("AP");
            cbestado.Items.Add("AM");
            cbestado.Items.Add("BA");
            cbestado.Items.Add("CE");
            cbestado.Items.Add("DF");
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

            //COLOCAR OS ITENS EM ORDEM AFABÉTICA
            cbestado.Sorted = true;

            //DEXAR A OPÇÃO SP SELECIONADA
            cbestado.SelectedItem = "SP";

            //NEHNUMA OPÇAO SELECIONADA
            //cbestado.SelectedIndex = -1;

            //CURSOS NO CAMPO NOME DO CLIENTE
            txtnome.Focus();

            //CARREGAR DATA NA LABEL
            lbdata.Text = DateTime.Now.ToShortDateString();

            //QUANDO ABRIR O FORMÚLARIO PARA ATUALIZAR EXCLUIR
            if (tipo == "Atualização")
            {
                lbtitulo.Text = "Atualização de Cliente";
                btcadastrar.Enabled = false;
                ckstatus.Enabled = true;
                cbestado.SelectedItem = estado;
                lbdata.Text = datacad.ToString();
            }
            else
            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;
            }
        }
        private void limpar()

        {
            txtnome.Clear();
            mskrg.Clear();
            mskcpf.Clear();
            mskdatanascimento.Clear();
            rbm.Checked = true;
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
            txtnome.Focus();
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            {
                //LEMBRAR QUE OS CAMPOS DO TIPO NÚMERO E DATA NÕA PODEM SER VAZIO, CASO NÃO SEJA OBRIGATORIO NO BD FAZER UM IF PARA MANDAR  0 (NÚMERO) E UMA DATA
                //CRIAR OBJETO DA CLASSE CLIENTE PARA USAR PROPRIEDADES E METODOS E PROPRIEDADES!!!
                classCliente cCliente = new classCliente();

                //validar campos obrigatorios
                //PREENCHER PELO MENOS UM TELEFONE
                if (txtnome.Text != "" && mskcpf.Text != "   .   .   -" && mskdatanascimento.Text != "  /  /" && txtrua.Text != "" && txtnumero.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      - "))
                {
                    //PASSAR PARA A PROPRIEDADE O CONTEUDO DO FORMULARIO
                    //PASSAR OS CAMPOS QUE O USUÁRIO PODE PREENCHER 
                    cCliente.nome = txtnome.Text;
                    cCliente.cpf = mskcpf.Text;
                    cCliente.datanascimento = Convert.ToDateTime(mskdatanascimento.Text);
                    cCliente.rua = txtrua.Text;
                    cCliente.numero = Convert.ToInt32(txtnumero.Text);
                    cCliente.complemento = txtcomplemento.Text;
                    cCliente.bairro = txtbairro.Text;
                    cCliente.cidade = txtcidade.Text;
                    cCliente.estado = cbestado.SelectedItem.ToString(); //COMBOBOX - PEGAR ITEM SELECIONADO PELO USUÁRIO
                    cCliente.email = txtemail.Text;
                    //RAIDBUTTOM
                    if (rbf.Checked)
                    {
                        cCliente.sexo = "Feminino";
                    }
                    else
                    {
                        cCliente.sexo = "Masculino";
                    }

                    //MASCARAS QUE NÃO É CAMPO OBRIGATORIO 
                    // RG

                    if (mskrg.Text != "  -   -   -")
                    {
                        cCliente.rg = mskrg.Text;
                    }
                    else //SE O USUÁRIO NÃO PREENCHUEU O RG
                    {
                        cCliente.rg = "";
                    }

                    //CEP
                    if (mskcep.Text != "   .   .   -")
                    {
                        cCliente.cep = mskcep.Text;
                    }
                    else
                    {
                        cCliente.cep = "";

                    }
                    //TELEFONE RESIDENCIAL
                    if (msktelefone.Text != "(  )     -")
                    {
                        cCliente.telefones = msktelefone.Text;
                    }
                    else
                    {
                        cCliente.telefones = "";

                    }

                    //TELEFONE CELULAR

                    if (mskcelular.Text != "(  )      -")
                    {
                        cCliente.celular = mskcelular.Text;
                    }
                    else
                    {
                        cCliente.celular = "";
                    }

                    // CHAMAR METODO PARA CADASTRAR - CLASSE CLIENTE
                    int resp = cCliente.CadastrarCliente();

                    // SE O CADASTRO DER CERTO 
                    if (resp == 1)
                    {
                        MessageBox.Show("Cliente: " + cCliente.nome + "Cadastrado com Sucesso !", " Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //CHAMAR MÉTODO DE LIMPAR 
                        limpar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar cadastro !", " Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }

                else //REFERENTE AOS CAMPOS OBRIGATORIOS 
                {
                    //COLOCANDO A MENSSAGEM E AS CORES
                    MessageBox.Show("Favor preencher todos os campos, obrigatórios !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnome.BackColor = Color.LemonChiffon;
                    mskcpf.BackColor = Color.LemonChiffon;
                    mskdatanascimento.BackColor = Color.LemonChiffon;
                    txtrua.BackColor = Color.LemonChiffon;
                    txtnumero.BackColor = Color.LemonChiffon;
                    msktelefone.BackColor = Color.LemonChiffon;
                    mskcelular.BackColor = Color.LemonChiffon;
                    txtnome.Focus();


                }
            }


        }
        //VALIDAR SE A DATA FOI PREENCHIDA CORRETAMENTE
        //USANDO O EVENTO VALIDATIONCOMPLETED DA MÁSCAARA (QUANDO CRIAR A MÁSCARA TEM QUE SER O TIPO DATETIME)

        private void mskdatanascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data Inválida.", "Livraria Nerds",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskdatanascimento.Focus();

            }
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //SE A TECLA DIGITADA NÃO FOR NÚMERO, BACKSPACE (08), ENTER (13) E ESPAÇO (32)
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
                {
                    //SE O USUÁRIO PREESSIONAR UMA TECLA NÃO NÚMERICA NO TEXTBOX, CANCELA O EVENTO KEY PRESS
                    e.Handled = true;
                    MessageBox.Show("Este campo aceitar apenas Números!", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o Cliente ?","Livraria Nerds!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCliente cCliente = new classCliente();
                cCliente.cod_cli = Convert.ToInt32(txtcodigocliente.Text);

                bool resp = cCliente.ExcluirCliente();

            if (resp == true)
                {
                    MessageBox.Show("Cliente" + cCliente.nome + "Exluido com Sucesso.", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }





        }

        private void btsaircliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Tem certeza que deseja sair ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            //lembrar que os campos do tipo numero e data nao pode ser vazio
            //caso nao seja obrigatorio no bd fazer um if para mandar o (numero) e uma data

            //instanciando a classe cliente para usar pripriedades e metodos
            classCliente cCliente = new classCliente();

            //validar campos obrigatorios
            //preencher pelo menos um telefone
            if (txtnome.Text != "" && mskcpf.Text != "   .   .   -" && mskdatanascimento.Text != "  /  /" && txtrua.Text != "" && txtnumero.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      -"))

            {
                ////passar para a propriedade o conteudo do formulario
                //todos os campos que o usuario pode preencher
                cCliente.nome = txtnome.Text;
                cCliente.cpf = mskcpf.Text;
                cCliente.datanascimento = Convert.ToDateTime(mskdatanascimento.Text);
                cCliente.rua = txtrua.Text;
                cCliente.numero = Convert.ToInt32(txtnumero.Text);
                cCliente.complemento = txtcomplemento.Text;
                cCliente.bairro = txtbairro.Text;
                cCliente.cidade = txtcidade.Text;
                cCliente.estado = cbestado.SelectedItem.ToString();//combobox pegar item selecionado pelo user
                cCliente.email = txtemail.Text;


                //RADIOBUTTON
                if (rbf.Checked)

                {
                    cCliente.sexo = "Feminino";
                }
                else
                {
                    cCliente.sexo = "Masculino";
                }

                //STATUS
                if (ckstatus.Checked == true)

                {
                    cCliente.status_cli = 1;

                }
                else
                {
                    cCliente.status_cli = 0;

                }

                //CODIGO CLIENTE
                cCliente.cod_cli = Convert.ToInt32(txtcodigocliente.Text);
                //MASCARAS QUE NÃO SÃO CAMPO OBRIGATORIO
                if (mskrg.Text != "  .   .   -")
                {
                    cCliente.rg = mskrg.Text;
                }
                else //SE O USUARIO NÃO PREENCHEU O RG
                {
                    cCliente.rg = "";
                }
                if (mskcep.Text != "     -")
                {
                    cCliente.cep = mskcep.Text;
                }

                else
                {
                    cCliente.cep = "";
                }

                //TELEFONE 
                //telefone residencial
                if (msktelefone.Text != "(  )     -")
                {
                    cCliente.telefones = msktelefone.Text;
                }
                else
                {
                    cCliente.telefones = "";
                }
                //telefone celuar
                if (mskcelular.Text != "(  )      -")
                {
                    cCliente.celular = mskcelular.Text;
                }
                else
                {
                    cCliente.celular = "";
                }

                //CHAMAR MÉTODO DE ATUALIZAR
                bool resp = cCliente.AtualizarCliente();

                if (resp == true)
                {
                    MessageBox.Show("Cliente : " + cCliente.nome + "Atualizado com Sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Erro ao atualizar !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            else // SE NÃO PREENCHER TODOS OS CAMPOS OBRIGATORIOS
            {
                MessageBox.Show("Favor preencher todos os campos obrigatorios !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.BackColor = Color.LemonChiffon;
                mskcpf.BackColor = Color.LemonChiffon;
                mskdatanascimento.BackColor = Color.LemonChiffon;
                txtrua.BackColor = Color.LemonChiffon;
                txtnumero.BackColor = Color.LemonChiffon;
                msktelefone.BackColor = Color.AliceBlue;
                mskcelular.BackColor = Color.AliceBlue;
                txtnome.Focus();

            }


        }

    }

}

//pontuações das mensagens acrescentadas  por daniela 20-11-2021