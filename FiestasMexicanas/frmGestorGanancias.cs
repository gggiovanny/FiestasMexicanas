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
    public partial class frmGestorGanancias : Form
    {
        public frmGestorGanancias()
        {
            InitializeComponent();
        }

        private void FrmGestorGanancias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.v_GESTOR_GANANCIAS' table. You can move, or remove it, as needed.
            this.v_GESTOR_GANANCIASTableAdapter.Fill(this.fiestasMexicanasDataSet.v_GESTOR_GANANCIAS);

        }
    }
}
