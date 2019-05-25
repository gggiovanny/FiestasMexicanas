using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiestasMexicanas
{
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            

        }

        private void CATALOGO_PAISESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.fiestasMexicanasDataSet);

        }

        private void Pruebas_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.v_COTIZACIONES' table. You can move, or remove it, as needed.
            this.v_COTIZACIONESTableAdapter.Fill(this.fiestasMexicanasDataSet.v_COTIZACIONES);

        }
    }
}
