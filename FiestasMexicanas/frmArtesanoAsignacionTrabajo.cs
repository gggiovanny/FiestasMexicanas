using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace FiestasMexicanas
{
    public partial class frmArtesanoAsignacionTrabajo : Form
    {
        clsMetodosSQL sql = new clsMetodosSQL();
        List<clsPedidoArtesano> lsPedidosPendientes = new List<clsPedidoArtesano>();
        List<DataGridViewRow> lsRowsBorradas = new List<DataGridViewRow>();


        public frmArtesanoAsignacionTrabajo()
        {
            InitializeComponent();
        }

        private void FrmArtesanoAsignacionTrabajo_Load(object sender, EventArgs e)
        {
            PoblarTablas();
        }

        private void PoblarTablas()
        {
            sql.PoblarTablaSQL("v_ASIGNACION_TRABAJO_ARTESANOS", grdArtesanos);
            sql.PoblarTablaSQL("v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDO", grdPedidos);
        }

        private void Btn_AgregarPedido_Click(object sender, EventArgs e)
        {
            if (grdPedidos.CurrentRow == null || grdArtesanos.CurrentRow == null)
            {
                MessageBox.Show("Elija un artesano y un pedido!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            lsPedidosPendientes.Add(new clsPedidoArtesano(  Convert.ToInt32(grdArtesanos.CurrentRow.Cells["ID"].Value), 
                                                            Convert.ToInt32(grdPedidos.CurrentRow.Cells["FOLIO"].Value)
                                                        ));
            lsRowsBorradas.Add(grdPedidos.CurrentRow);
            grdPedidos.Rows.RemoveAt(grdPedidos.CurrentRow.Index);

            grdArtesanos.CurrentRow.Cells["NO. PEDIDOS"].Value = Convert.ToInt32(grdArtesanos.CurrentRow.Cells["NO. PEDIDOS"].Value) + 1;
        }

        private void Btn_QuitarUltimoPedido_Click(object sender, EventArgs e)
        {
            if (lsPedidosPendientes.Count < 1)
                return;

            PoblarTablas();
            
            lsPedidosPendientes.RemoveAt(lsPedidosPendientes.Count - 1);
            lsRowsBorradas.RemoveAt(lsRowsBorradas.Count - 1);
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private int Guardar()
        {
            int result = -1;

            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;

                foreach (clsPedidoArtesano pedidoArtesano in lsPedidosPendientes)
                {
                    comando.CommandText = String.Format(@"INSERT INTO ARTESANOS_PEDIDOS(cempCodigo, ppedCodigo, cpestCodigo) VALUES({0}, {1}, 1);",
                                                pedidoArtesano.codigoEmpleado,
                                                pedidoArtesano.codigoPedido);
                    result = comando.ExecuteNonQuery();

                }
                conexion.Close();
            }
            lsPedidosPendientes = new List<clsPedidoArtesano>();
            MessageBox.Show("Guardado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PoblarTablas();
            return result;
        }
    }
}
