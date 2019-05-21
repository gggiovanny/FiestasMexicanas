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

        private void cATALOGO_ESTADOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATALOGO_ESTADOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fiestasMexicanasPrueba);

        }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasPrueba.CATALOGO_ESTADOS' table. You can move, or remove it, as needed.
            this.cATALOGO_ESTADOSTableAdapter.Fill(this.fiestasMexicanasPrueba.CATALOGO_ESTADOS);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
