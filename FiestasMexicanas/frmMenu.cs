using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FiestasMexicanas
{
    public partial class frmMenu : Form
    {
        int usuarioPuesto = 0;
        public frmMenu(int usuarioCodigo)
        {
            InitializeComponent();
            VerificarPermisos(usuarioCodigo);

        }

        private void VerificarPermisos(int usuarioCodigo)
        {

            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"SELECT 
	                                        CE.cemppCodigo 
                                        FROM CATALOGO_EMPLEADOS CE
                                        WHERE CE.cempCodigo = "+ usuarioCodigo +";";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarioPuesto = Convert.ToInt32(reader["cemppCodigo"]);
                    }
                }
                conexion.Close();
            }

            MostrarSoloFormasPermitidas();

        }
            
        private void MostrarSoloFormasPermitidas()
        {
            switch (usuarioPuesto)
            {
                case 1:
                    btn_asignacionTrabajo.Enabled = true;
                    btn_artesanos.Enabled = true;
                    btn_visorCargaTrabajo.Enabled = true;
                    btn_clientes.Enabled = true;
                    btn_gestorGanancias.Enabled = true;
                    btn_cotizacion.Enabled = true;
                    btn_catalogoCotizacionesPedidos.Enabled = true;
                    btn_adminPrecios.Enabled = true;
                    btn_proveedores.Enabled = true;
                    break;

                case 2:
                    btn_asignacionTrabajo.Enabled = false;
                    btn_artesanos.Enabled = false;
                    btn_visorCargaTrabajo.Enabled = false;
                    btn_clientes.Enabled = true;
                    btn_gestorGanancias.Enabled = false;
                    btn_cotizacion.Enabled = true;
                    btn_catalogoCotizacionesPedidos.Enabled = true;
                    btn_adminPrecios.Enabled = false;
                    btn_proveedores.Enabled = true;
                    break;

                case 3:
                    btn_asignacionTrabajo.Enabled = false;
                    btn_artesanos.Enabled = false;
                    btn_visorCargaTrabajo.Enabled = true;
                    btn_clientes.Enabled = false;
                    btn_gestorGanancias.Enabled = false;
                    btn_cotizacion.Enabled = false;
                    btn_catalogoCotizacionesPedidos.Enabled = false;
                    btn_adminPrecios.Enabled = false;
                    btn_proveedores.Enabled = false;
                    break;

                default:
                    break;
            }
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
