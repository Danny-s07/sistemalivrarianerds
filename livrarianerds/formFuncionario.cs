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
    public partial class formFuncionario : Form
    {
        public formFuncionario()
        {
            InitializeComponent();
        }
        //variavel tipo: guardar como o formulario deve ser aberto se para cadastro ou atualizar/excluir
        //variavel estado: informação é mostrada em uma combo 
        public string tipo, estado;

        //variavel datacad: mostra informação guardada no bd e nao a data atual como programado no load do form
        public DateTime datacad;

        public int cargo;
        private void btsairfuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void formFuncionario_Load(object sender, EventArgs e)
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

            // CARREGAR COMBO CARGO 
            classCargo cCargo = new classCargo();
            //COMBO RECEBENDO O SELECT
            cbcargo.DataSource = cCargo.CarregarCbcargo();

            //EXIBIR NA COMBO PARA O USUARIO
            cbcargo.DisplayMember = "nome";
            //ARMAZENAR NO BD O CÓDIGO (FK)
            cbcargo.ValueMember = "cod_carg";
            //NÃO DEIXAR NENHUMA MARCA SELECIONADA
            cbcargo.SelectedIndex = -1;

            //QUANDO BRIR O FORMNÁRIO PARA ATUALIZAR EXCLUIR
            if (tipo == "Atualização")

            {
                lbTitulo.Text = "Atualização de Funcionario";
                btcadastrar.Enabled = false;
                ckstatus.Enabled = true;
                cbestado.SelectedItem = estado;
                lbdata.Text = datacad.ToString();
                cbcargo.SelectedValue = cargo;
            }
            else

            {
                btatualizar.Enabled = false;
                btexcluir.Enabled = false;


            }
        }
            private void Limpar()

            {
                txtnome.Clear();
                mskrg.Clear();
                mskcpf.Clear();
                mskdatanascimento.Clear();
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
                txtnome.Focus();
                cbcargo.SelectedItem = "";

            }


            private void btcadastrar_Click(object sender, EventArgs e)
        {
            //LEMBRAR QUE OS CAMPOS DO TIPO NÚMERO E DATA NÕA PODEM SER VAZIO, CASO NÃO SEJA OBRIGATORIO NO BD FAZER UM IF PARA MANDAR  0 (NÚMERO) E UMA DATA
            //CRIAR OBJETO DA CLASSE FUNCIONARIO PARA USAR PROPRIEDADES E METODOS E PROPRIEDADES!!!
            classFuncionario cFuncionario = new classFuncionario();


            //validar campos obrigatorios
            //PREENCHER PELO MENOS UM TELEFONE
            if (txtnome.Text != "" && mskcpf.Text != "   .   .   -" && mskdatanascimento.Text != "  /  /" && txtrua.Text != "" && txtnumero.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      - "))
            {
                //PASSAR PARA A PROPRIEDADE O CONTEUDO DO FORMULARIO
                //PASSAR OS CAMPOS QUE O USUÁRIO PODE PREENCHER 
                cFuncionario.nome = txtnome.Text;
                cFuncionario.cpf = mskcpf.Text;
                cFuncionario.datanascimento = Convert.ToDateTime(mskdatanascimento.Text);
                cFuncionario.rua = txtrua.Text;
                cFuncionario.numero = Convert.ToInt32(txtnumero.Text);
                cFuncionario.complemento = txtcomplemento.Text;
                cFuncionario.bairro = txtbairro.Text;
                cFuncionario.cidade = txtcidade.Text;
                cFuncionario.estado = cbestado.SelectedItem.ToString(); //COMBOBOX - PEGAR ITEM SELECIONADO PELO USUÁRIO
                cFuncionario.email = txtemail.Text;
                cFuncionario.cod_carg = Convert.ToInt32(cbcargo.SelectedValue);

                //RAIDBUTTOM
                if (rbf.Checked)
                {
                    cFuncionario.sexo = "Feminino";
                }
                else
                {
                    cFuncionario.sexo = "Masculino";
                }

                //MASCARAS QUE NÃO É CAMPO OBRIGATORIO 
                // RG

                if (mskrg.Text != "  -   -   -")
                {
                    cFuncionario.rg = mskrg.Text;
                }
                else //SE O USUÁRIO NÃO PREENCHUEU O RG
                {
                    cFuncionario.rg = "";
                }

                //CEP
                if (mskcep.Text != "   .   .   -")
                {
                    cFuncionario.cep = mskcep.Text;
                }
                else
                {
                    cFuncionario.cep = "";

                }
                //TELEFONE RESIDENCIAL
                //TELEFONE RESIDENCIAL
                if (msktelefone.Text != "(  )     -")
                {
                    cFuncionario.telefone = msktelefone.Text;
                }
                else
                {
                    cFuncionario.telefone = "";

                }

                //TELEFONE CELULAR

                if (mskcelular.Text != "(  )      -")
                {
                    cFuncionario.celular = mskcelular.Text;
                }
                else
                {
                    cFuncionario.celular = "";
                }

                //CHAMAR METODO PARA CADASATRAR- CLASSE CLIENTE
                int resp = cFuncionario.CadastrarFuncionario();

                //SE O CADASTRO DER CERTO 
                if(resp ==1)
                {
                    MessageBox.Show("Funcionario: " + cFuncionario.nome + "Cadastrado com Sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //CHAMAR MÉTODO DE LIMPAR
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao realizar cadastro !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                                      }
                                                                                                    
            }
            else  //REFERENTE AOS CAMPOS OBRIGATORIOS

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
        //VALIDAR SE A DATA FOI PREENCHIDA CORRETAMENTE
        //USANDO O EVENTO VALIDATION COMPLETED DA MASCARA (QUANDO CRIAR A MÁSCARA TEM QUE SER O TIPO DATETIME)

        private void mskdatanascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput) 
            {
                MessageBox.Show("Data Inválida.", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskdatanascimento.Focus();

            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o funcionario ?", "Livraria Nerds!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classFuncionario cfuncionario = new classFuncionario();
                cfuncionario.cod_func = Convert.ToInt32(txtcodigofuncionario.Text);

                bool resp = cfuncionario.ExcluirFuncionario();

                if (resp == true)
                {
                    MessageBox.Show("Funcionario" + cfuncionario.nome + "Exluido com Sucesso.", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este Funcionario não pode ser excluido, há registro em outras tabaela !" , "Livraria Nerds", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
            }



        }

        private void btsairFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair ?", "Livraria Nerds", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btcadastrar_Click_1(object sender, EventArgs e)
        {

            //LEMBRAR QUE OS CAMPOS DO TIPO NÚMERO E DATA NÕA PODEM SER VAZIO, CASO NÃO SEJA OBRIGATORIO NO BD FAZER UM IF PARA MANDAR  0 (NÚMERO) E UMA DATA
            //CRIAR OBJETO DA CLASSE FUNCIONARIO PARA USAR PROPRIEDADES E METODOS E PROPRIEDADES!!!
            classFuncionario cFuncionario = new classFuncionario();


            //validar campos obrigatorios
            //PREENCHER PELO MENOS UM TELEFONE
            if (txtnome.Text != "" && mskcpf.Text != "   .   .   -" && mskdatanascimento.Text != "  /  /" && txtrua.Text != "" && txtnumero.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      - "))
            {
                //PASSAR PARA A PROPRIEDADE O CONTEUDO DO FORMULARIO
                //PASSAR OS CAMPOS QUE O USUÁRIO PODE PREENCHER 
                cFuncionario.nome = txtnome.Text;
                cFuncionario.cpf = mskcpf.Text;
                cFuncionario.datanascimento = Convert.ToDateTime(mskdatanascimento.Text);
                cFuncionario.rua = txtrua.Text;
                cFuncionario.numero = Convert.ToInt32(txtnumero.Text);
                cFuncionario.complemento = txtcomplemento.Text;
                cFuncionario.bairro = txtbairro.Text;
                cFuncionario.cidade = txtcidade.Text;
                cFuncionario.estado = cbestado.SelectedItem.ToString(); //COMBOBOX - PEGAR ITEM SELECIONADO PELO USUÁRIO
                cFuncionario.email = txtemail.Text;
                cFuncionario.cod_carg = Convert.ToInt32(cbcargo.SelectedValue);

                //RAIDBUTTOM
                if (rbf.Checked)
                {
                    cFuncionario.sexo = "Feminino";
                }
                else
                {
                    cFuncionario.sexo = "Masculino";
                }

                //MASCARAS QUE NÃO É CAMPO OBRIGATORIO 
                // RG

                if (mskrg.Text != "  -   -   -")
                {
                    cFuncionario.rg = mskrg.Text;
                }
                else //SE O USUÁRIO NÃO PREENCHUEU O RG
                {
                    cFuncionario.rg = "";
                }

                //CEP
                if (mskcep.Text != "   .   .   -")
                {
                    cFuncionario.cep = mskcep.Text;
                }
                else
                {
                    cFuncionario.cep = "";

                }
                //TELEFONE RESIDENCIAL
                //TELEFONE RESIDENCIAL
                if (msktelefone.Text != "(  )     -")
                {
                    cFuncionario.telefone = msktelefone.Text;
                }
                else
                {
                    cFuncionario.telefone = "";

                }

                //TELEFONE CELULAR

                if (mskcelular.Text != "(  )      -")
                {
                    cFuncionario.celular = mskcelular.Text;
                }
                else
                {
                    cFuncionario.celular = "";
                }

                //CHAMAR METODO PARA CADASATRAR- CLASSE CLIENTE
                int resp = cFuncionario.CadastrarFuncionario();

                //SE O CADASTRO DER CERTO 
                if (resp == 1)
                {
                    MessageBox.Show("Funcionario: " + cFuncionario.nome + "Cadastrado com Sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //CHAMAR MÉTODO DE LIMPAR
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao realizar cadastro ?", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else  //REFERENTE AOS CAMPOS OBRIGATORIOS

            {
                //COLOCANDO A MENSSAGEM E AS CORES

                MessageBox.Show("Favor preencher todos os campos, obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        //VALIDAR SE A DATA FOI PREENCHIDA CORRETAMENTE
        //USANDO O EVENTO VALIDATION COMPLETED DA MASCARA (QUANDO CRIAR A MÁSCARA TEM QUE SER O TIPO DATETIME)

       

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SE A TECLA DIGITADA NÃO FOR NÚMERO, BACKSPACE (080, ENTER (13) E ESPAÇO (32)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //SE O USUARIO PRESSIONAR UMA TECLA NÃO NÚMERICA NO TEXTBOX, CANCELA O EVENTO KEY PRESS
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas Números!", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                             
            }

        }

        

        private void mskdatanascimento_TypeValidationCompleted_1(object sender, TypeValidationEventArgs e)
        {

            if (!e.IsValidInput)
            {
                MessageBox.Show("Data Inválida.", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskdatanascimento.Focus();

            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            //lembrar que os campos do tipo numero e data nao pode ser vazio
            //caso nao seja obrigatorio no bd fazer um if para mandar o (numero) e uma data

            //instanciando a classe cliente para usar pripriedades e metodos
            classFuncionario cFuncionario = new classFuncionario();

            //validar campos obrigatorios
            //preencher pelo menos um telefone
            if (txtnome.Text != "" && mskcpf.Text != "   .   .   -" && mskdatanascimento.Text != "  /  /" && txtrua.Text != "" && txtnumero.Text != "" && (msktelefone.Text != "(  )     -" || mskcelular.Text != "(  )      -"))

            {
                ////passar para a propriedade o conteudo do formulario
                //todos os campos que o usuario pode preencher
                cFuncionario.nome = txtnome.Text;
                cFuncionario.cpf = mskcpf.Text;
                cFuncionario.datanascimento = Convert.ToDateTime(mskdatanascimento.Text);
                cFuncionario.rua = txtrua.Text;
                cFuncionario.numero = Convert.ToInt32(txtnumero.Text);
                cFuncionario.complemento = txtcomplemento.Text;
                cFuncionario.bairro = txtbairro.Text;
                cFuncionario.cidade = txtcidade.Text;
                cFuncionario.estado = cbestado.SelectedItem.ToString();//combobox pegar item selecionado pelo user
                cFuncionario.email = txtemail.Text;


                //RADIOBUTTON
                if (rbf.Checked)

                {
                    cFuncionario.sexo = "Feminino";
                }
                else
                {
                    cFuncionario.sexo = "Masculino";
                }

                //STATUS
                if (ckstatus.Checked == true)

                {
                    cFuncionario.status_func = 1;

                }
                else
                {
                    cFuncionario.status_func = 0;

                }

                //CODIGO CLIENTE
                cFuncionario.cod_func = Convert.ToInt32(txtcodigofuncionario.Text);
                //MASCARAS QUE NÃO SÃO CAMPO OBRIGATORIO
                if (mskrg.Text != "  .   .   -")
                {
                    cFuncionario.rg = mskrg.Text;
                }
                else //SE O USUARIO NÃO PREENCHEU O RG
                {
                    cFuncionario.rg = "";
                }
                if (mskcep.Text != "     -")
                {
                    cFuncionario.cep = mskcep.Text;
                }

                else
                {
                    cFuncionario.cep = "";
                }

                //TELEFONE 
                //telefone residencial
                if (msktelefone.Text != "(  )     -")
                {
                    cFuncionario.telefone = msktelefone.Text;
                }
                else
                {
                    cFuncionario.telefone = "";
                }
                //telefone celuar
                if (mskcelular.Text != "(  )      -")
                {
                    cFuncionario.celular = mskcelular.Text;
                }
                else
                {
                    cFuncionario.celular = "";
                }

                //CHAMAR MÉTODO DE ATUALIZAR
                bool resp = cFuncionario.AtualizarFuncionario();

                if (resp == true)
                {
                    MessageBox.Show("Funcionario : " + cFuncionario.nome + "Atualizado com Sucesso !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Erro ao realizar cadastro !", "Livraria Nerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            

        }

    }

}


        

     