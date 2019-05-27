using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

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

        public void PoblarDataGridView(DataGridView grid, string TABLA, params string[] CATALOGOS)
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
                                        and t.name = '"+TABLA+"' and t.type = 'U';";

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                        lsCampos.Add(reader["name"].ToString());
                }
                conexion.Close();
            }

            if(lsCampos.Count <= 1)
            {
                MessageBox.Show("Tabla inválida!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string inicioCampo = ObtenerInicioCampo(lsCampos[0]);
            int c = 0;
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
                    tcmbCampo.HeaderText = nombreSinInicio;
                    tcmbCampo.Name = "tc" + nombreSinInicio;
                    tcmbCampo.DataPropertyName = campoNombre;

                    tcmbCampo.ValueMember = campoNombre;
                    tcmbCampo.DisplayMember =  ObtenerInicioCampo(campoNombre)+ "Nombre";
                }
            }
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

        /*
        public void PoblarTablaSQL()
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

        }*/

    }
}
