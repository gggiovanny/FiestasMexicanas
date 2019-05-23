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
    public partial class frmArtesanoAsignacionTrabajo : Form
    {
        public frmArtesanoAsignacionTrabajo()
        {
            InitializeComponent();
        }

        private void FrmArtesanoAsignacionTrabajo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDO' table. You can move, or remove it, as needed.
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOTableAdapter.Fill(this.fiestasMexicanasDataSet.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDO);
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.v_ASIGNACION_TRABAJO_ARTESANOS' table. You can move, or remove it, as needed.
            this.v_ASIGNACION_TRABAJO_ARTESANOSTableAdapter.Fill(this.fiestasMexicanasDataSet.v_ASIGNACION_TRABAJO_ARTESANOS);

        }
    }
}
