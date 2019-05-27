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
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        private void Pruebas_Load_1(object sender, EventArgs e)
        {
            PoblarComboBoxTablaSQL();
            PoblarTablaSQL();
        }

        private void PoblarTablaSQL()
        {

            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PEDIDO_PINATA;", conexion);
                DataTable dbTabla = new DataTable();
                adapter.Fill(dbTabla);
                dataGridView1.DataSource = dbTabla;

                conexion.Close();
            }

        }

        private void PoblarComboBoxTablaSQL()
        {
            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CATALOGO_TIPO_PINATA;", conexion);
                DataTable dbTabla = new DataTable();
                adapter.Fill(dbTabla);
                tlistTipoPinata.ValueMember = "ctpinCodigo";
                tlistTipoPinata.DisplayMember = "ctpinNombre";
                tlistTipoPinata.DataSource = dbTabla;


                conexion.Close();
            }
        }
    }
}
