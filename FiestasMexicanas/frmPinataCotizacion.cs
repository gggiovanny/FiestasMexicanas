using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Limpiar();
            AutoCompletar();
        }       

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.CATALOGO_TAMANO_PINATA' table. You can move, or remove it, as needed.
            this.cATALOGO_TAMANO_PINATATableAdapter.Fill(this.fiestasMexicanasDataSet.CATALOGO_TAMANO_PINATA);
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.CATALOGO_TIPO_PINATA' table. You can move, or remove it, as needed.
            this.cATALOGO_TIPO_PINATATableAdapter.Fill(this.fiestasMexicanasDataSet.CATALOGO_TIPO_PINATA);

        }

        private void Limpiar()
        {
            select_tipo.ResetText();
            select_tipo.SelectedIndex = -1;
            select_tamano.ResetText();
            select_tamano.SelectedIndex = -1;

        }

        private int Guardar()
        {
            int result;
            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;

                comando.CommandText = @"UPDATE CATALOGO_CLIENTES
                                            SET cclieNombres = 'DIDIER JESUS'
                                            WHERE cclieCodigo = 1;";

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }

        private void AutoCompletar()
        {


            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;

                comando.CommandText = @"SELECT * FROM CATALOGO_CLIENTES;";


                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while(reader.Read())
                    {                        
                        txt_nombres.AutoCompleteCustomSource.Add(reader["cclieNombres"].ToString());
                        txt_apellidos.AutoCompleteCustomSource.Add(reader["cclieApellidoPaterno"].ToString() + ' ' + reader["cclieApellidoMaterno"].ToString());
                        txt_razonSocial.AutoCompleteCustomSource.Add(reader["cclieRazonSocial"].ToString());
                        txt_direccion.AutoCompleteCustomSource.Add(reader["cclieDireccion"].ToString());
                        txt_tel.AutoCompleteCustomSource.Add(reader["cclieTelefono"].ToString());
                        txt_cel.AutoCompleteCustomSource.Add(reader["cclieCelular"].ToString());
                        txt_email.AutoCompleteCustomSource.Add(reader["cclieEmail"].ToString());
                    }
                }



                conexion.Close();
            }
        }

        private void Btn_guardarPedido_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
