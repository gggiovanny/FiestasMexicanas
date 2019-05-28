using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Drawing;

namespace FiestasMexicanas
{
    public partial class frmArtesanoSueldo : Form
    {
        clsMetodosSQL sql = new clsMetodosSQL();

        public frmArtesanoSueldo()
        {
            InitializeComponent();
        }

        private void FrmArtesanoSueldo_Load(object sender, EventArgs e)
        {
            PoblarTabla();

        }

        private void PoblarTabla()
        {
            sql.PoblarTablaSQL("v_ARTESANOS_SUELDOS", grdArtesanos);

            foreach (DataGridViewColumn col in grdArtesanos.Columns)
                col.ReadOnly = true;

            grdArtesanos.Columns["GANANCIA %"].ReadOnly = false;
            grdArtesanos.Columns["GANANCIA %"].DefaultCellStyle.BackColor = Color.LightGray;
            grdArtesanos.Columns["SUELDO BRUTO"].ReadOnly = false;
            grdArtesanos.Columns["SUELDO BRUTO"].DefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
