using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FiestasMexicanas
{
    public partial class frmGestorGanancias : Form
    {
        clsMetodosSQL sql = new clsMetodosSQL();

        public frmGestorGanancias()
        {
            InitializeComponent();
        }

        private void FrmGestorGanancias_Load(object sender, EventArgs e)
        {
            PoblarTabla();
            numDulces.Controls[0].Visible = false;
            numCompraVenta.Controls[0].Visible = false;
            numArtFiesta.Controls[0].Visible = false;
            numOtrosIngresos.Controls[0].Visible = false;

            numMateriales.Controls[0].Visible = false;
            numSueldos.Controls[0].Visible = false;
            numServicios.Controls[0].Visible = false;
            numGasolina.Controls[0].Visible = false;
            numOtrosGastos.Controls[0].Visible = false;

            numGananciaTotal.Controls[0].Visible = false;
        }

        private void PoblarTabla()
        {
            sql.PoblarTablaSQL("v_GESTOR_GANANCIAS", grdIngresosPinata);
            decimal suma = 0;

            foreach (DataGridViewRow row in grdIngresosPinata.Rows)
            {
                suma += Convert.ToDecimal(row.Cells["VENTAS NETAS"].Value.ToString().Trim('$'));
            }

            txt_cantidadPiñatas.Text = suma.ToString(); ;
        }

        private void Num_Editado(object sender, EventArgs e)
        {
            decimal total = 0;
            total += Convert.ToDecimal(txt_cantidadPiñatas.Text);
            total += numDulces.Value;
            total += numCompraVenta.Value;
            total += numArtFiesta.Value;
            total += numOtrosIngresos.Value;

            total -= numMateriales.Value;
            total -= numSueldos.Value;
            total -= numServicios.Value;
            total -= numGasolina.Value;
            total -= numOtrosGastos.Value;

            numGananciaTotal.Value = total;
        }
    }
}
