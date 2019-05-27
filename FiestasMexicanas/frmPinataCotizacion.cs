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
        #region VARIABLES
        bool clienteNuevo = false;
        #endregion

        public frmPinataCotizacion()
        {
            InitializeComponent();
            Limpiar();
            PoblarAutocompletadoSQL();
            PoblarComboBoxSQL(select_tipo, "CATALOGO_TIPO_PINATA", "ctpinNombre");
            PoblarComboBoxSQL(select_tamano, "CATALOGO_TAMANO_PINATA", "ctampNombre");
            PoblarComboBoxSQL(select_pais, "CATALOGO_PAISES", "cpaiNombre");
        }

        #region EVENTOS
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {

        }    

        private void Btn_guardarPedido_Click(object sender, EventArgs e)
        {
            Guardar();
        }


        private void Txt_nombres_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                if (sender.GetType() == typeof(TextBox))
                {
                    TextBox txt = sender as TextBox;
                    int indicePersona = txt.AutoCompleteCustomSource.IndexOf(txt.Text.ToUpper());

                    if (indicePersona >= 0)
                    {
                        clienteNuevo = false;
                        SugerenciaAceptada(indicePersona);
                    }
                    else
                    {
                        clienteNuevo = true;
                    }
                }
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
                PoblarComboBoxSQL(select_estado, "CATALOGO_ESTADOS", "cedoNombre", "WHERE cpaiIndice = " + cpaiIndice);
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
                PoblarComboBoxSQL(select_ciudad, "CATALOGO_CIUDADES", "cciuNombre", "WHERE cpaiIndice = " + cpaiIndice + " AND cedoIndice = " + cedoIndice);
                select_estado.Tag = cedoIndice;
            }
        }

        #endregion

        #region METODOS
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

        private void SugerenciaAceptada(int indicePersona)
        {
            txt_nombres.Text = txt_nombres.AutoCompleteCustomSource[indicePersona];
            txt_apellidos.Text = txt_apellidos.AutoCompleteCustomSource[indicePersona];
            txt_razonSocial.Text = txt_razonSocial.AutoCompleteCustomSource[indicePersona];
            txt_direccion.Text = txt_direccion.AutoCompleteCustomSource[indicePersona];
            txt_tel.Text = txt_tel.AutoCompleteCustomSource[indicePersona];
            txt_cel.Text = txt_cel.AutoCompleteCustomSource[indicePersona];
            txt_email.Text = txt_email.AutoCompleteCustomSource[indicePersona];

            select_pais.Text = select_pais.AutoCompleteCustomSource[indicePersona];
            select_estado.Text = select_estado.AutoCompleteCustomSource[indicePersona];
            select_ciudad.Text = select_ciudad.AutoCompleteCustomSource[indicePersona];


        }

        private void PoblarComboBoxSQL(ComboBox combobox, string TABLA, string campo, string WHERE = "")
        {

            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"SELECT * FROM " + TABLA + " " + WHERE + ";";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                        combobox.Items.Add(reader[campo]);
                }            
                conexion.Close();
            }

        }
        #endregion
    }
}
