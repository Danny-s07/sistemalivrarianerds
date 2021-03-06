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
    public partial class formRelVendaCompleto : Form
    {
        public formRelVendaCompleto()
        {
            InitializeComponent();
        }

        private void formRelVendaCompleto_Load(object sender, EventArgs e)
        {

            cbTipoRel.Items.Add("Funcionario");
            cbTipoRel.Items.Add("Funcionario e periodo de Venda");
            cbTipoRel.Items.Add("Cliente");
            cbTipoRel.Items.Add("Cliente e periodo de Venda");
            cbTipoRel.Items.Add("Periodo de Venda");

            //deixar algo ja carregado
            cbTipoRel.SelectedItem = "Funcionario";

             //caregar combo fornecedores
            classFuncionario cFuncionario = new classFuncionario();
            //combo recebendo o select
            cbFuncionario.DataSource = cFuncionario.CarregarCbFuncionario();
            //exibir na combo para o usuario
            cbFuncionario.DisplayMember = "nome";
            //armazenar no bd o codigo (fk)
            cbFuncionario.ValueMember = "cod_func";
            //nao deixar nenhum fornecedor selecionado
            cbFuncionario.SelectedIndex = -1;


            //caregar combo cliente
            classCliente cCliente = new classCliente();
            //combo recebendo o select
            cbCliente.DataSource = cCliente.CarregarCbCliente();
            //exibir na combo para o usuario
            cbCliente.DisplayMember = "nome";
            //armazenar no bd o codigo (fk)
            cbCliente.ValueMember = "cod_cli";
            //nao deixar nenhum cliente selecionado
            cbCliente.SelectedIndex = -1;


            this.rptVendaCompleta.RefreshReport();
        }

        private void btGerarRel_Click(object sender, EventArgs e)
        {
            //instanciar a classe 
            classRelVenda cRelVenda = new classRelVenda();

            //criar variavel para ler a opcao escolhida pelo usuario

            string relatorio = cbTipoRel.SelectedItem.ToString();

            switch (relatorio)
            {

                case "Funcionario":
                    if(cbFuncionario.SelectedIndex != -1)
                    {
                        classRelVendaBindingSource.DataSource = cRelVenda.RelVendaFuncionario(Convert.ToInt32(cbFuncionario.SelectedValue.ToString()));
                        this.rptVendaCompleta.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show(" Escolha um Funcionario !", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Funcionario e periodo de Venda":
                    if (cbFuncionario.SelectedIndex != -1)
                    {
                        classRelVendaBindingSource.DataSource = cRelVenda.RelVendaFuncionarioData(Convert.ToInt32(cbFuncionario.SelectedValue.ToString()), Convert.ToDateTime(dtpDateDe.Text), Convert.ToDateTime(dtpDateAte.Text));
                        this.rptVendaCompleta.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show(" Escolha um Funcionario !", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                    break;

                case "Periodo de Venda":
                    classRelVendaBindingSource.DataSource = cRelVenda.RelVendaPeriodo(Convert.ToDateTime(dtpDateDe.Text), Convert.ToDateTime(dtpDateAte.Text));
                    this.rptVendaCompleta.RefreshReport();

                    break;

                case "Cliente":
                    if (cbCliente.SelectedIndex != -1)
                    {
                        classRelVendaBindingSource.DataSource = cRelVenda.RelVendaCliente(Convert.ToInt32(cbCliente.SelectedValue.ToString()));
                        this.rptVendaCompleta.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show(" Escolha um Cliente !", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Cliente e periodo de Venda":
                    if (cbCliente.SelectedIndex != -1)
                    {
                        classRelVendaBindingSource.DataSource = cRelVenda.RelVendaClienteData(Convert.ToInt32(cbCliente.SelectedValue.ToString()), Convert.ToDateTime(dtpDateDe.Text), Convert.ToDateTime(dtpDateAte.Text));
                        this.rptVendaCompleta.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show(" Escolha um Cliente !", "Livraria Nerds ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    break;









            }
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0) //funcionario
            {
                gbFuncionario.Enabled = true;
                gbPeriodoVenda.Enabled = false;
                gbCliente.Enabled = false;
                
            }
            if (cbTipoRel.SelectedIndex == 1) //funcionario e periodo
            {
                gbFuncionario.Enabled = true;
                gbPeriodoVenda.Enabled = true;
                gbCliente.Enabled = false;

            }
            if (cbTipoRel.SelectedIndex == 2) //cliente
            {
                gbFuncionario.Enabled = false;
                gbPeriodoVenda.Enabled = false;
                gbCliente.Enabled = true;

            }
            if (cbTipoRel.SelectedIndex == 3) //cliente e periodo
            {
                gbFuncionario.Enabled = false;
                gbPeriodoVenda.Enabled = true;
                gbCliente.Enabled = true;

            }

            if (cbTipoRel.SelectedIndex == 4) //periodo
            {
                gbFuncionario.Enabled = false;
                gbPeriodoVenda.Enabled = true;
                gbCliente.Enabled = false;

            }
        }
    }
}
