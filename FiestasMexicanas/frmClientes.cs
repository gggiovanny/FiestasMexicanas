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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.CATALOGO_ESTADOS' table. You can move, or remove it, as needed.
            this.cATALOGO_ESTADOSTableAdapter.Fill(this.fiestasMexicanasDataSet.CATALOGO_ESTADOS);
            // TODO: This line of code loads data into the 'fiestasMexicanasDataSet.v_CLIENTES' table. You can move, or remove it, as needed.
            this.v_CLIENTESTableAdapter.Fill(this.fiestasMexicanasDataSet.v_CLIENTES);
            /*
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "ID", true));
            this.txt_nombres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "NOMBRE", true));
            this.txt_apellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "APELLIDOS", true));
            this.txt_razonsocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "RAZON SOCIAL", true));
            this.txt_direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "DIRECCION", true));
            this.select_ciudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "CIUDAD", true));
            this.select_estado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "ESTADO", true));
            this.select_pais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "PAIS", true));
            this.txt_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "TEL", true));
            this.txt_cel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "CEL", true));
            this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_CLIENTESBindingSource, "EMAIL", true));
            */
            v_CLIENTESBindingSource.Filter += "ID < 1000 ";




        }

        private void GrdClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            



        }
    }
}
