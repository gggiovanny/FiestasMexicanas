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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {            
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }

        private void Btn_asignacionTrabajo_Click(object sender, EventArgs e)
        {            
            new frmArtesanoAsignacionTrabajo().ShowDialog();
        }

        private void Btn_artesanos_Click(object sender, EventArgs e)
        {
            new frmArtesanoSueldo().ShowDialog();
        }

        private void Btn_visorCargaTrabajo_Click(object sender, EventArgs e)
        {
            new frmArtesanosVisorTrabajo().ShowDialog();
        }

        private void Btn_gestorGanancias_Click(object sender, EventArgs e)
        {
            new frmGestorGanancias().ShowDialog();
        }

        private void Btn_cotizacion_Click(object sender, EventArgs e)
        {
            new frmPinataCotizacion().ShowDialog();
        }

        private void Btn_catalogoCotizacionesPedidos_Click(object sender, EventArgs e)
        {
            new frmPinataPedidos().ShowDialog();
        }

        private void Btn_adminPrecios_Click(object sender, EventArgs e)
        {
            new frmPinataPreciosCotizaciones().ShowDialog();
        }

        private void Btn_proveedores_Click(object sender, EventArgs e)
        {
            new frmProveedores().ShowDialog();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {
            new Pruebas().ShowDialog();
        }
    }
}
