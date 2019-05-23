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
    public partial class frmPinataCotizacion : Form
    {
        public frmPinataCotizacion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.CATALOGO_TIPO_PINATA' table. You can move, or remove it, as needed.
            this.cATALOGO_TIPO_PINATATableAdapter.Fill(this.fiestasMexicanasDataSet.CATALOGO_TIPO_PINATA);

        }
    }
}
