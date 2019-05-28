using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FiestasMexicanas
{
    public partial class frmPinataPreciosCotizaciones : Form
    {
        clsMetodosSQL sql = new clsMetodosSQL();

        public frmPinataPreciosCotizaciones()
        {
            InitializeComponent();
        }

        private void FrmPinataPreciosCotizaciones_Load(object sender, EventArgs e)
        {
            PoblarTabla();
        }

        private void PoblarTabla()
        {
            sql.PoblarTablaSQL("v_PRECIO_PINATA", grdPrecios);
            grdPrecios.Columns["Codigo"].ReadOnly = true;
            grdPrecios.Columns["Tipo piñata"].ReadOnly = true;

            DataGridViewCheckBoxColumn colEdited = new DataGridViewCheckBoxColumn();
            colEdited.HeaderText = "edited";
            colEdited.Name = "edited";
            grdPrecios.Columns.Add(colEdited);
            grdPrecios.Columns["edited"].Visible = false;
        }

        private void Guardar()
        {
            int contadorGuardados = 0;
            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();

                foreach (DataGridViewRow row in grdPrecios.Rows)
                {
                    if (Convert.ToInt32(row.Cells["edited"].Value) != 1)
                        continue;
                    SqlCommand comando = new SqlCommand("UPDATE_PRECIOS_PINATAS", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Codigo", Convert.ToInt32(row.Cells["Codigo"].Value));
                    comando.Parameters.AddWithValue("@PrecioChica", Convert.ToDecimal(row.Cells["Precio chica"].Value.ToString().TrimStart('$')));
                    comando.Parameters.AddWithValue("@PrecioMediana", Convert.ToDecimal(row.Cells["Precio mediana"].Value.ToString().TrimStart('$')));
                    comando.Parameters.AddWithValue("@PrecioGrande", Convert.ToDecimal(row.Cells["Precio grande"].Value.ToString().TrimStart('$')));
                    comando.Parameters.AddWithValue("@PrecioDetalle", Convert.ToDecimal(row.Cells["Costo detallada"].Value.ToString().TrimStart('$')));
                    comando.Parameters.AddWithValue("@PrecioAlambreMetro", Convert.ToDecimal(row.Cells["Alambre metro"].Value.ToString().TrimStart('$')));
                    comando.Parameters.AddWithValue("@ExisteMolde", Convert.ToBoolean(row.Cells["Molde"].Value));

                    comando.ExecuteNonQuery();
                    contadorGuardados++;
                    row.Cells["edited"].Value = 0;
                }

                conexion.Close();
            }

            if (contadorGuardados > 0)
                MessageBox.Show("Guardado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nada que guardar!", "Nada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void GrdPrecios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grdPrecios.CurrentRow.Cells["edited"].Value = 1;
        }

        private void Btn_guardarPrecios_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
