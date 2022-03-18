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
    public partial class formRelCategoria : Form
    {
        public formRelCategoria()
        {
            InitializeComponent();
        }

        private void formRelCategoria_Load(object sender, EventArgs e)
        {

            //criando um objeto da classe categoria 
            classCategoria cCategoria = new classCategoria();


            //relatorio recebendo select
            classCategoriaBindingSource.DataSource = cCategoria.RelCategoria();
                                              
            
            this.reportViewer1.RefreshReport();
        }
    }
}
