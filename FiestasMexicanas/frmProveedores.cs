using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiestasMexicanas
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.v_PROVEEDORES' table. You can move, or remove it, as needed.
            this.v_PROVEEDORESTableAdapter.Fill(this.fiestasMexicanasDataSet.v_PROVEEDORES);

        }
    }
}
