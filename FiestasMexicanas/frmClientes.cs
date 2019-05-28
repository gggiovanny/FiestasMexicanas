using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FiestasMexicanas
{
    public partial class frmClientes : Form
    {
        clsMetodosSQL sql = new clsMetodosSQL();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            sql.PoblarTablaSQL("v_CLIENTES", grdClientes);
            PoblarAutocompletadoSQL();
            sql.PoblarComboBox(select_pais, "CATALOGO_PAISES", "cpaiNombre");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            sql.PoblarTablaSQL("v_CLIENTES", grdClientes);

            // (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("ID = '{0}'", txt_codigo.Text);
            if (!string.IsNullOrEmpty(txt_nombres.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOMBRE = '{0}'", txt_nombres.Text);

            if (!string.IsNullOrEmpty(txt_apellidos.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("APELLIDOS = '{0}'", txt_apellidos.Text);

            if (!string.IsNullOrEmpty(txt_razonSocial.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("'RAZON SOCIAL' = '{0}'", txt_razonSocial.Text);

            if (!string.IsNullOrEmpty(txt_tel.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("TEL = '{0}'", txt_tel.Text);

            if (!string.IsNullOrEmpty(txt_cel.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("CEL = '{0}'", txt_cel.Text);

            if (!string.IsNullOrEmpty(txt_email.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("EMAIL = '{0}'", txt_email.Text);

            if (!string.IsNullOrEmpty(txt_direccion.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("DIRECCION = '{0}'", txt_direccion.Text);

            if (!string.IsNullOrEmpty(select_pais.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("PAIS = '{0}'", select_pais.Text);

            if (!string.IsNullOrEmpty(select_estado.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("ESTADO = '{0}'", select_estado.Text);

            if (!string.IsNullOrEmpty(select_ciudad.Text))
                (grdClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("CIUDAD = '{0}'", select_ciudad.Text);


                
        }

        private void PoblarAutocompletadoSQL()
        {
            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;

                comando.CommandText = @"SELECT
	                                    CC.cclieCodigo,
	                                    CC.cclieNombres,
	                                    CC.cclieApellidoPaterno,
	                                    CC.cclieApellidoMaterno,
	                                    CC.cclieRazonSocial,
	                                    CC.cclieDireccion,
	                                    CC.cclieTelefono,
	                                    CC.cclieCelular,
	                                    CC.cclieEmail,
	                                    CP.cpaiNombre,
	                                    CE.cedoNombre,
	                                    CCIU.cciuNombre
                                    FROM CATALOGO_CLIENTES CC
                                    INNER JOIN CATALOGO_PAISES CP
	                                    ON CC.cpaiIndice = CP.cpaiIndice
                                    INNER JOIN CATALOGO_ESTADOS CE
	                                    ON CC.cpaiIndice = CE.cpaiIndice
	                                    AND CC.cedoIndice = CE.cedoIndice
                                    INNER JOIN CATALOGO_CIUDADES CCIU
	                                    ON CC.cpaiIndice = CCIU.cpaiIndice
	                                    AND CC.cedoIndice = CCIU.cedoIndice
	                                    AND CC.cciuIndice = CCIU.cciuIndice;";


                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txt_nombres.AutoCompleteCustomSource.Add(reader["cclieNombres"].ToString());
                        txt_apellidos.AutoCompleteCustomSource.Add(reader["cclieApellidoPaterno"].ToString() + ' ' + reader["cclieApellidoMaterno"].ToString());
                        txt_razonSocial.AutoCompleteCustomSource.Add(reader["cclieRazonSocial"].ToString());
                        txt_direccion.AutoCompleteCustomSource.Add(reader["cclieDireccion"].ToString());
                        txt_tel.AutoCompleteCustomSource.Add(reader["cclieTelefono"].ToString());
                        txt_cel.AutoCompleteCustomSource.Add(reader["cclieCelular"].ToString());
                        txt_email.AutoCompleteCustomSource.Add(reader["cclieEmail"].ToString());
                        select_pais.AutoCompleteCustomSource.Add(reader["cpaiNombre"].ToString());
                        select_estado.AutoCompleteCustomSource.Add(reader["cedoNombre"].ToString());
                        select_ciudad.AutoCompleteCustomSource.Add(reader["cciuNombre"].ToString());
                    }
                }

                conexion.Close();
            }
        }

        private void Select_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cpaiIndice = select_pais.SelectedIndex + 1;
            if (cpaiIndice != Convert.ToInt32(select_pais.Tag)) //en el tag se guarda el indice anterior
            {
                select_estado.Items.Clear();
                select_estado.Text = "";
                select_ciudad.Items.Clear();
                select_ciudad.Text = "";
                sql.PoblarComboBox(select_estado, "CATALOGO_ESTADOS", "cedoNombre", "WHERE cpaiIndice = " + cpaiIndice);
                select_pais.Tag = cpaiIndice;
            }
        }

        private void Select_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cpaiIndice = select_pais.SelectedIndex + 1;
            int cedoIndice = select_estado.SelectedIndex + 1;

            if (cedoIndice != Convert.ToInt32(select_estado.Tag)) //en el tag se guarda el indice anterior
            {
                select_ciudad.Items.Clear();
                select_ciudad.Text = "";
                sql.PoblarComboBox(select_ciudad, "CATALOGO_CIUDADES", "cciuNombre", "WHERE cpaiIndice = " + cpaiIndice + " AND cedoIndice = " + cedoIndice);
                select_estado.Tag = cedoIndice;
            }
        }
    }
}
