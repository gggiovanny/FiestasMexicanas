using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FiestasMexicanas
{
    public partial class frmPinataPedidos : Form
    {
        clsMetodosSQL sql = new clsMetodosSQL();

        public frmPinataPedidos()
        {
            InitializeComponent();
        }

        private void FrmPinataPedidos_Load(object sender, EventArgs e)
        {
            #region CONFIGURACION GRID
            sql.PoblarDataGridViewView( grdCotizacion, "v_COTIZACIONES",
                                        DataGridViewComboBoxDisplayStyle.ComboBox,
                                        new clsCatalogo("CATALOGO_TIPO_PINATA", "ctpin"),
                                        new clsCatalogo("CATALOGO_TAMANO_PINATA", "ctamp"),
                                        new clsCatalogo("v_CATALOGO_CLIENTES", "cclie"));
            //columna para marcar como editado
            DataGridViewCheckBoxColumn colEdited = new DataGridViewCheckBoxColumn();
            colEdited.HeaderText = "edited";
            colEdited.Name = "edited";
            grdCotizacion.Columns.Add(colEdited);
            grdCotizacion.Columns["edited"].Visible = false;

            grdCotizacion.Columns["Codigo"].ReadOnly = true;
            grdCotizacion.Columns["Hay Molde"].ReadOnly = true;
            grdCotizacion.Columns["edited"].ReadOnly = true;

            #endregion
        }

        private void Btn_guardarCotizacionPedido_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void GrdCotizacion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            grdCotizacion.CurrentRow.Cells["edited"].Value = 1;
        }

        private void Guardar()
        {
            int contadorGuardados = 0;
            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();

                foreach (DataGridViewRow row in grdCotizacion.Rows)
                {
                    if (Convert.ToInt32(row.Cells["edited"].Value) != 1)
                        continue;
                    SqlCommand comando = new SqlCommand("UPDATE_COTIZACIONES", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    bool bEntregado = row.Cells["Entregado"].Value == DBNull.Value ? false : Convert.ToBoolean(row.Cells["Entregado"].Value);

                    comando.Parameters.AddWithValue("@Codigo", Convert.ToInt32(row.Cells["Codigo"].Value));
                    comando.Parameters.AddWithValue("@CodigoTipoPiñata", Convert.ToInt32(row.Cells["Tipo"].Value));
                    comando.Parameters.AddWithValue("@CodigoTamañoPiñata", Convert.ToInt32(row.Cells["Tamaño"].Value));
                    comando.Parameters.AddWithValue("@LlevaDetalle", Convert.ToBoolean(row.Cells["Tamaño"].Value));
                    comando.Parameters.AddWithValue("@Descripcion", row.Cells["Descripcion"].Value.ToString());
                    comando.Parameters.AddWithValue("@CodigoCliente", Convert.ToInt32(row.Cells["Cliente"].Value));
                    comando.Parameters.AddWithValue("@ImporteVentaUnidad", Convert.ToDecimal(row.Cells["Importe Venta"].Value.ToString().TrimStart('$')));
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));
                    comando.Parameters.AddWithValue("@FechaSalidaEntregado", bEntregado ? DateTime.Now : Convert.ToDateTime("01/01/1900"));
                    comando.ExecuteNonQuery();
                    contadorGuardados++;
                    row.Cells["edited"].Value = 0;
                }

                conexion.Close();
            }

            if(contadorGuardados > 0)
                MessageBox.Show("Guardado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nada que guardar!", "Nada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
