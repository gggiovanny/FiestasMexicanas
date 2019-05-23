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
    public partial class frmArtesanosVisorTrabajo : Form
    {
        public frmArtesanosVisorTrabajo()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmArtesanosVisorTrabajo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.v_VISOR_CARGA_TRABAJO' table. You can move, or remove it, as needed.
            this.v_VISOR_CARGA_TRABAJOTableAdapter.Fill(this.fiestasMexicanasDataSet.v_VISOR_CARGA_TRABAJO);

        }
    }
}
