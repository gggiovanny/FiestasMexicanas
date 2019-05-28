using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FiestasMexicanas
{
    public partial class frmArtesanosVisorTrabajo : Form
    {
        clsMetodosSQL sql = new clsMetodosSQL();

        public frmArtesanosVisorTrabajo()
        {
            InitializeComponent();

        }

        private void FrmArtesanosVisorTrabajo_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            sql.PoblarTablaSQL("v_VISOR_CARGA_TRABAJO", grdCargaTrabajo);
            grdCargaTrabajo.Columns["CODIGO_PEDIDO"].Visible = false;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if(grdCargaTrabajo.CurrentRow == null)
            {
                MessageBox.Show("Primero seleccione un trabajo!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guardar();
        }

        private int Guardar()
        {
            int result = -1;

            int codigoEstatus = 0;
            if (radioBtn_espera.Checked)
                codigoEstatus = 1;
            if (radioBtn_armando.Checked)
                codigoEstatus = 2;
            if (radioBtn_forrando.Checked)
                codigoEstatus = 3;
            if (radioBtn_terminada.Checked)
                codigoEstatus = 4;

            string fechaCompletado = "";

            if(codigoEstatus == 4)
            {
                DialogResult resultado =  MessageBox.Show("Está a punto de marcar una piñata como finalizada y esto no se puede deshacer. ¿Desea continuar?", "ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.No)
                    return result;

                fechaCompletado = string.Format(",\nartpedFechaCompletado = CONVERT(date, '{0}')\n", DateTime.Now);
            }


            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = String.Format(@"UPDATE ARTESANOS_PEDIDOS
                                                        SET cpestCodigo = {0}{1}
                                                        WHERE ppedCodigo = {2}; ",
                                                        codigoEstatus,
                                                        fechaCompletado,
                                                        Convert.ToInt32(grdCargaTrabajo.CurrentRow.Cells["CODIGO_PEDIDO"].Value));

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }

            MessageBox.Show("Guardado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarTabla();
            return result;
        }

    }
}
