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
        clsMetodosSQL sql = new clsMetodosSQL();

        public Pruebas()
        {
            InitializeComponent();
        }

        private void Pruebas_Load_1(object sender, EventArgs e)
        {
            sql.PoblarDataGridView(dgrdCotizacion, "PEDIDO_PINATA", "pped");
        }

        
    }
}
