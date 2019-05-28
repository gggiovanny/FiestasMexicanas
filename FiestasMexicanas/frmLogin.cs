using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FiestasMexicanas
{
    public partial class frmLogin : Form
    {
        clsMetodosSQL sql = new clsMetodosSQL();
        int codigoEmpleado = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            if (VerificarUsuario())
                AbrirMenu();
            else
                MessageBox.Show("Usuario o contraseña incorrectos!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool VerificarUsuario()
        {
            string sConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FiestasMexicanas.Properties.Settings.FiestasMexicanasConnectionStringBueno"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(sConnectionString))
            {
                conexion.Open();
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"SELECT * FROM USUARIOS_SISTEMA;";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string usuario = (reader["usisAlias"]).ToString();
                        string contraseña = (reader["usisPassword"]).ToString();
                        codigoEmpleado = Convert.ToInt32(reader["cempCodigo"]);

                        if (txt_usuario.Text == usuario && txt_contraseña.Text == contraseña)
                            return true;
                    }
                }
                conexion.Close();
            }
            return false;
        }

        private void AbrirMenu()
        {
            this.Hide();
            var frmMenu = new frmMenu(codigoEmpleado);
            frmMenu.Closed += (s, args) => this.Close();
            frmMenu.Show();
        }

        private void Txt_contraseña_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (VerificarUsuario())
                    AbrirMenu();
                else
                    MessageBox.Show("Usuario o contraseña incorrectos!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
