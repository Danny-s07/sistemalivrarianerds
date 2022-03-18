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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configurando o botao de sair com apenas se ele colocar sim do contrario ele volta ao sistema
            if (MessageBox.Show("Tem certeza que deseja fechar o sistema ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolbtsair_Click(object sender, EventArgs e)
        {
            //configurando o botao de sair com apenas se ele colocar sim do contrario ele volta ao sistema
            if (MessageBox.Show("Tem certeza que deseja fechar o sistema", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timerprincipal_Tick(object sender, EventArgs e)
        {
            //exibir data na label da barra de status
            toolbData.Text = DateTime.Now.ToShortDateString();
            toolbHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void menuCadAutores_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formAutores>().Count()>0)
            {
                MessageBox.Show("O formulario de Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de autores e instanciar
                formAutores fCadAutores = new formAutores();
                //tornar o form autores filho do form principal(mdi)
                fCadAutores.MdiParent = this;
                //chamar o form
                fCadAutores.Show();
            }
        }

        private void menuCadCategoria_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formCategoria>().Count()>0)
            {
                MessageBox.Show("O formulario de Cadastro já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario nao estiver aberto , abrir e estanciar como objeto
                formCategoria fCadCategoria = new formCategoria();
                //tornando filho do formulario principal
                fCadCategoria.MdiParent = this;
                //exibindo o form
                fCadCategoria.Show();
            }
        }

        private void toolCadFornecedores_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formFornecedores>().Count()>0)
            {
                MessageBox.Show("O formulario de Cadastro já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario nao estiver aberto , abrir e estanciar como objeto
                formFornecedores fCadFornecedores = new formFornecedores();
                fCadFornecedores.MdiParent = this;
                fCadFornecedores.Show();

            }
        }

        private void menuCadLivros_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formLivros>().Count() > 0)
            {
                MessageBox.Show("O formulario de Cadastro já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario nao estiver aberto , abrir e estanciar como objeto
                formLivros fCadLivro = new formLivros();
                fCadLivro.MdiParent = this;
                fCadLivro.Show();
            }
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaLivros>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formConsultaLivros fCadConsultaLivro = new formConsultaLivros();
                //tornar o form cliente filho do form principal(mdi)
                fCadConsultaLivro.MdiParent = this;
                //chamar o form
                fCadConsultaLivro.Show();

            }
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<formConsultaFornecedores>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formConsultaFornecedores fCadConsultaFornecedores = new formConsultaFornecedores();
                //tornar o form cliente filho do form principal(mdi)
                fCadConsultaFornecedores.MdiParent = this;
                //chamar o form
                fCadConsultaFornecedores.Show();

            }
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaAutores>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formConsultaAutores fCadConsultaAutores = new formConsultaAutores();
                //tornar o form cliente filho do form principal(mdi)
                fCadConsultaAutores.MdiParent = this;
                //chamar o form
                fCadConsultaAutores.Show();

            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaCategoria>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formConsultaCategoria fCadConsultaCategoria = new formConsultaCategoria();
                //tornar o form cliente filho do form principal(mdi)
                fCadConsultaCategoria.MdiParent = this;
                //chamar o form
                fCadConsultaCategoria.Show();

            }
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelCategoria>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelCategoria fCadRelCategoria = new formRelCategoria();
                //tornar o form cliente filho do form principal(mdi)
                fCadRelCategoria.MdiParent = this;
                //chamar o form
                fCadRelCategoria.Show();

            }
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelLivros>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelLivros fCadRelLivros = new formRelLivros();
                //tornar o form cliente filho do form principal(mdi)
                fCadRelLivros.MdiParent = this;
                //chamar o form
                fCadRelLivros.Show();

            }
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelFornecedores>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelFornecedores fCadRelFornecedor = new formRelFornecedores();
                //tornar o form cliente filho do form principal(mdi)
                fCadRelFornecedor.MdiParent = this;
                //chamar o form
                fCadRelFornecedor.Show();

            }
        }

        private void autoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelAutores>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelAutores fCadRelAutores = new formRelAutores();
                //tornar o form cliente filho do form principal(mdi)
                fCadRelAutores.MdiParent = this;
                //chamar o form
                fCadRelAutores.Show();

            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelCliente>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelCliente fCadRelCliente = new formRelCliente();
                 //tornar o form cliente filho do form principal(mdi)
                fCadRelCliente.MdiParent = this;
                //chamar o form
                fCadRelCliente.Show();

            }
        }

        private void cargosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelCargo>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelCargo fCadRelCargo = new formRelCargo();
                //tornar o form cliente filho do form principal(mdi)
                fCadRelCargo.MdiParent = this;
                //chamar o form
                fCadRelCargo.Show();

            }
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelFuncionario>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelFuncionario fCadRelFuncionario = new formRelFuncionario();
                //tornar o form cliente filho do form principal(mdi)
                fCadRelFuncionario.MdiParent = this;
                //chamar o form
                fCadRelFuncionario.Show();

            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaCliente>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formConsultaCliente fCadConsultaCliente = new formConsultaCliente();
                //tornar o form cliente filho do form principal(mdi)
                fCadConsultaCliente.MdiParent = this;
                //chamar o form
                fCadConsultaCliente.Show();

            }
        }

        //vitor  17-11-2021
        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaCargo>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formConsultaCargo fCadConsultaCargo = new formConsultaCargo();
                //tornar o form cliente filho do form principal(mdi)
                fCadConsultaCargo.MdiParent = this;
                //chamar o form
                fCadConsultaCargo.Show();

            }
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsultaFuncionario>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formConsultaFuncionario fCadConsultaFuncionario = new formConsultaFuncionario();
                //tornar o form cliente filho do form principal(mdi)
                fCadConsultaFuncionario.MdiParent = this;
                //chamar o form
                fCadConsultaFuncionario.Show();

            }
        }

        private void menuCadCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formCliente>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formCliente fCadCliente = new formCliente();
                //tornar o form cliente filho do form principal(mdi)
                fCadCliente.MdiParent = this;
                //chamar o form
                fCadCliente.Show();

            }
        }

        private void menuCadCargos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formCargo>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formCargo fCadCargo = new formCargo();
                //tornar o form cliente filho do form principal(mdi)
                fCadCargo.MdiParent = this;
                //chamar o form
                fCadCargo.Show();

            }
        }

        private void menuCadFuncionarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formFuncionario>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formFuncionario fCadFuncionario = new formFuncionario();
                //tornar o form cliente filho do form principal(mdi)
                fCadFuncionario.MdiParent = this;
                //chamar o form
                fCadFuncionario.Show();

            }
        }

        private void cadastroVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formVenda>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formVenda fCadVenda = new formVenda();
                //tornar o form cliente filho do form principal(mdi)
                fCadVenda.MdiParent = this;
                //chamar o form
                fCadVenda.Show();

            }
        }

        private void relatorioVendaCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelVendaCompleto>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelVendaCompleto fCadRelVendaCompleto = new formRelVendaCompleto();
                //tornar o form cliente filho do form principal(mdi)
                fCadRelVendaCompleto.MdiParent = this;
                //chamar o form
                fCadRelVendaCompleto.Show();

            }
        }

        private void relatorioVendaSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelVendaSimples>().Count() > 0)
            {
                MessageBox.Show("O formulario Cadastro ja esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //se o formulario  nao estiver aberto 
                //criar o objeto do formulario de cliente e instanciar
                formRelVendaSimples fCadRelVendaSimples = new formRelVendaSimples();
                //tornar o form cliente filho do form principal(mdi)
                fCadRelVendaSimples.MdiParent = this;
                //chamar o form
                fCadRelVendaSimples.Show();

            }
        }
    }
}
