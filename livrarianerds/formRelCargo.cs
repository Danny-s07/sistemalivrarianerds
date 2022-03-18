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
    public partial class formRelCargo : Form
    {
        public formRelCargo()
        {
            InitializeComponent();
        }

        private void RelCargo_Load(object sender, EventArgs e)
        {
        this.reportViewer1.RefreshReport();

            classCargo cCargo = new classCargo();

            classCargoBindingSource.DataSource = cCargo.RelCargo();

            

        }
    }
}
