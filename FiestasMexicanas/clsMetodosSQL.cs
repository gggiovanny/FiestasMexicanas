using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Drawing;


namespace FiestasMexicanas
{
    class clsMetodosSQL
    {
        string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

        public void PoblarComboBox(ComboBox combobox, string TABLA, string campo, string WHERE = "")
        {
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

        public int ObtenerUltimoRegistro(string TABLA)
        {
            int ultimo = 0;

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

        public List<string> ObtenerNombreCamposTabla(string TABLA)
        {
            List<string> lsCampos = new List<string>();

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                //obteniendo el nombre de los campos de la tabla
                comando.CommandText = @"select c.name from sys.columns c
                                        inner join sys.tables t 
                                        on t.object_id = c.object_id
                                        and t.name = '" + TABLA + "' and t.type = 'U';";

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                        lsCampos.Add(reader["name"].ToString());
                }

                if(lsCampos.Count == 0)
                {
                    comando.CommandText = @"select c.name from sys.columns c
                                        inner join sys.views t 
                                        on t.object_id = c.object_id
                                        and t.name = '" + TABLA + "';";

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                            lsCampos.Add(reader["name"].ToString());
                    }
                }
                conexion.Close();
            }

            return lsCampos;
        }

        public void PoblarDataGridViewView(DataGridView grid, string TABLA, params clsCatalogo[] CATALOGOS)
        {
            List<string> lsCampos = ObtenerNombreCamposTabla(TABLA);

            if (lsCampos.Count <= 1)
            {
                MessageBox.Show("Tabla inválida!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = 0;
            foreach (string campoNombre in lsCampos)
            {
                if (campoNombre.StartsWith("txt"))
                {
                    string nombreSinInicio = FormatearCampoNombre(campoNombre);
                    DataGridViewTextBoxColumn tctxCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    tctxCampo.HeaderText = nombreSinInicio;
                    tctxCampo.Name = "tc" + nombreSinInicio.Trim(' ');
                    tctxCampo.DataPropertyName = campoNombre;
                    grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    tctxCampo});
                }
                if (campoNombre.StartsWith("cmb"))
                {
                    string nombreSinInicio = FormatearCampoNombre(campoNombre);
                    DataGridViewComboBoxColumn tcmbCampo = new DataGridViewComboBoxColumn();
                    tcmbCampo.HeaderText = nombreSinInicio;
                    tcmbCampo.Name = "tcmb" + nombreSinInicio.Trim(' ');
                    tcmbCampo.DataPropertyName = campoNombre;

                    tcmbCampo.FlatStyle = FlatStyle.Flat;
                    tcmbCampo.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;

                    tcmbCampo.ValueMember = CATALOGOS[i].prefijo + "Codigo";
                    tcmbCampo.DisplayMember = CATALOGOS[i].prefijo + "Nombre";
                    PoblarComboBoxTablaSQL(tcmbCampo, CATALOGOS[i].TABLA);
                    i++;
                    grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    tcmbCampo});
                }
                if (campoNombre.StartsWith("chk"))
                {
                    string nombreSinInicio = FormatearCampoNombre(campoNombre);
                    DataGridViewCheckBoxColumn tctxCampo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                    tctxCampo.HeaderText = nombreSinInicio;
                    tctxCampo.Name = "tchk" + nombreSinInicio.Trim(' ');
                    tctxCampo.DataPropertyName = campoNombre;
                    grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    tctxCampo});
                }
            }

            PoblarTablaSQL(TABLA, grid);
            grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0F0F0");
            grid.GridColor = System.Drawing.ColorTranslator.FromHtml("#F0F0F0");
            grid.EnableHeadersVisualStyles = false;
        }

        public void PoblarDataGridViewTablaVanilla(DataGridView grid, string TABLA, params string[] CATALOGOS)
        {
            List<string> lsCampos = ObtenerNombreCamposTabla(TABLA);

            if(lsCampos.Count <= 1)
            {
                MessageBox.Show("Tabla inválida!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string inicioCampo = ObtenerInicioCampo(lsCampos[0]);
            int i = 0;
            foreach (string campoNombre in lsCampos)
            {
                if(campoNombre.StartsWith(inicioCampo))
                {
                    string nombreSinInicio = FormatearCampoNombre(campoNombre);
                    DataGridViewTextBoxColumn tctxCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    tctxCampo.HeaderText = nombreSinInicio;
                    tctxCampo.Name = "tc" + nombreSinInicio;
                    tctxCampo.DataPropertyName = campoNombre;
                    grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    tctxCampo});
                }
                else
                {
                    string nombreSinInicio = FormatearCampoNombre(campoNombre);
                    DataGridViewComboBoxColumn tcmbCampo = new DataGridViewComboBoxColumn();
                    tcmbCampo.HeaderText = campoNombre;
                    tcmbCampo.Name = "tc" + nombreSinInicio;
                    tcmbCampo.DataPropertyName = campoNombre;

                    tcmbCampo.ValueMember = campoNombre;
                    tcmbCampo.DisplayMember =  ObtenerInicioCampo(campoNombre)+ "Nombre";
                    PoblarComboBoxTablaSQL(tcmbCampo, CATALOGOS[i]);
                    i++;
                    grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    tcmbCampo});
                }
            }

            PoblarTablaSQL(TABLA, grid);
        }

        public void PoblarComboBoxTablaSQL(DataGridViewComboBoxColumn tcmbCampo, string CATALOGO)
        {
            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM "+CATALOGO+";", conexion);
                DataTable dbTabla = new DataTable();
                adapter.Fill(dbTabla);                
                tcmbCampo.DataSource = dbTabla;
                conexion.Close();
            }
        }

        public string FormatearCampoNombre(string campoNombre)
        {
            int i;
            for (i = 0; i < campoNombre.Length; i++)
            {
                if (char.IsUpper(campoNombre[i]))
                    break;
            }
            
            return campoNombre.Remove(0, i);
        }

        public string ObtenerInicioCampo(string campoNombre)
        {
            int i;
            for (i = 0; i < campoNombre.Length; i++)
            {
                if (char.IsUpper(campoNombre[i]))
                    break;
            }

            return campoNombre.Remove(i);
        }

        
        public void PoblarTablaSQL(string TABLA, DataGridView grid)
        {

            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + TABLA + ";", conexion);
                DataTable dbTabla = new DataTable();
                adapter.Fill(dbTabla);
                grid.DataSource = dbTabla;

                conexion.Close();
            }

        }

    }
}
