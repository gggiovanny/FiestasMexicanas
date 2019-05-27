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
        bool costoGenerado = false;
        decimal dPrecioUnitario = 0;

        decimal dPrecioChica = 0;
        decimal dPrecioMediana = 0;
        decimal dPrecioGrande = 0;
        decimal dExtraDetalle = 0;
        decimal dAlambreMetro = 0;
        #endregion

        #region CONSTRUCTOR
        public frmPinataCotizacion()
        {
            InitializeComponent();
            Limpiar();
            PoblarAutocompletadoSQL();
            PoblarComboBoxSQL(select_tipo, "CATALOGO_TIPO_PINATA", "ctpinNombre");
            PoblarComboBoxSQL(select_tamano, "CATALOGO_TAMANO_PINATA", "ctampNombre");
            PoblarComboBoxSQL(select_pais, "CATALOGO_PAISES", "cpaiNombre");
        }
        #endregion

        #region EVENTOS
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {

        }    

        private void Btn_guardarPedido_Click(object sender, EventArgs e)
        {
            if(!costoGenerado)
            {
                MessageBox.Show(this, "Primero genere un costo para la piñata!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_estimarCosto.BackColor = Color.Red;
                return;
            }
            if(Guardar() >= 1)
                MessageBox.Show(this, "Pedido guardado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Error al guardar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            int result = -1;
            
            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = String.Format(@"INSERT INTO PEDIDO_PINATA
                                        (
	                                        ppedCodigo, 
	                                        ctpinCodigo,
	                                        ctampCodigo,
	                                        ppedLlevaDetalle,
	                                        ppedDescripcion,
	                                        cclieCodigo, 
	                                        ppedPrecioUnitario,
	                                        ppedCantidad,
	                                        ppedFechaPedido,
	                                        ppedFechaEntregaProgramada
                                        )
                                        VALUES ( {0}, {1}, {2}, {3}, '{4}', {5}, {6}, {7}, CONVERT(date, '{8}'), CONVERT(date, '{9}') );",
                                        ObtenerUltimoRegistroSQL("PEDIDO_PINATA") + 1,
                                        select_tipo.SelectedIndex + 1,
                                        select_tamano.SelectedIndex + 1,
                                        radioBtn_detallada.Checked ? 1 : 0,
                                        txt_descripcionPinata.Text,
                                        txt_apellidos.AutoCompleteCustomSource.IndexOf(txt_apellidos.Text.ToUpper()) + 1,
                                        num_PrecioVenta.Value,
                                        dPrecioUnitario,
                                        DateTime.Now,
                                        dateFechaEntrega.Value
                                        );

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

        private void Txt_AutoCompletadoLlenar(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                if (sender.GetType() == typeof(TextBox))
                {
                    TextBox txt = sender as TextBox;
                    int indicePersona = txt.AutoCompleteCustomSource.IndexOf(txt.Text);

                    if (indicePersona >= 0)
                    {
                        clienteNuevo = false;
                        AutoCompletadoSugerenciaAceptada(indicePersona);
                    }
                    else
                    {
                        clienteNuevo = true;
                    }
                }
            }
        }

        private void AutoCompletadoSugerenciaAceptada(int indicePersona)
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

        private int ObtenerUltimoRegistroSQL(string TABLA)
        {
            int ultimo = 0;

            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM " + TABLA + ";";
                using (SqlDataReader reader = comando.ExecuteReader())
                    while (reader.Read())
                        ultimo = Convert.ToInt32(reader[0]);
                conexion.Close();
            }
            return ultimo;
        }
        #endregion

        private void PoblarExistenciaMolde()
        {

            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"SELECT ppinExisteMolde FROM PRECIO_PINATA WHERE ctpinCodigo = " + (select_tipo.Items.IndexOf(select_tipo.SelectedItem) + 1);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                        check_existeMolde.Checked = Convert.ToBoolean(reader["ppinExisteMolde"]);
                }
                conexion.Close();
            }

        }

        private void Btn_estimarCosto_Click(object sender, EventArgs e)
        {
            if (select_tipo.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Ingrese primero un tipo de piñata!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                select_tipo.BackColor = Color.Red;
                select_tipo.FlatStyle = FlatStyle.Flat;
                return;
            }
            if (select_tamano.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Ingrese primero un tamaño de piñata!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                select_tamano.BackColor = Color.Red;
                select_tamano.FlatStyle = FlatStyle.Flat;
                return;
            }

            EstimarCosto();
            btn_estimarCosto.BackColor = SystemColors.Control;
        }

        private void ObtenerPrecios()
        {
            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"SELECT * FROM PRECIO_PINATA WHERE ctpinCodigo = " + (select_tipo.Items.IndexOf(select_tipo.SelectedItem) + 1);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dPrecioChica = Convert.ToDecimal(reader ["ppinChica"]);
                        dPrecioMediana = Convert.ToDecimal(reader["ppinMediana"]);
                        dPrecioGrande = Convert.ToDecimal(reader["ppinGrande"]);

                        dExtraDetalle = Convert.ToDecimal(reader["ppinDetalle"]);
                        dAlambreMetro = Convert.ToDecimal(reader["ppinAlambreMetro"]);
                    }
                }
                conexion.Close();
            }
        }

        private void EstimarCosto()
        {
            decimal dPrecioBase = 0;
            switch (select_tamano.Items.IndexOf(select_tamano.SelectedItem) + 1)
            {
                case 1:
                    dPrecioBase = dPrecioChica;
                    break;
                case 2:
                    dPrecioBase = dPrecioMediana;
                    break;
                case 3:
                    dPrecioBase = dPrecioGrande;
                    break;
                default:
                    break;
            }

            dPrecioUnitario = dPrecioBase;
            dPrecioUnitario += radioBtn_detallada.Checked ? dExtraDetalle : 0;

            dPrecioUnitario += dAlambreMetro * num_metrosAprox.Value;

            decimal dPrecioTotal = dPrecioUnitario * num_cantidad.Value;

            num_PrecioVenta.Value = dPrecioTotal;
            costoGenerado = true;
        }

        private void Select_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PoblarExistenciaMolde();
            ObtenerPrecios();
            select_tipo.BackColor = SystemColors.Window;
            select_tipo.FlatStyle = FlatStyle.Standard;
        }

        private void Check_LlevaEstructuraAlambre_CheckedChanged(object sender, EventArgs e)
        {
            num_metrosAprox.Enabled = check_LlevaEstructuraAlambre.Checked;
            num_metrosAprox.Value = 0;
        }

        private void Select_tamano_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_tamano.BackColor = SystemColors.Window;
            select_tamano.FlatStyle = FlatStyle.Standard;

        }
    }
}
