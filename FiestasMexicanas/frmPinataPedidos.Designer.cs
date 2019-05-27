namespace FiestasMexicanas
{
    partial class frmPinataPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btn_guardarCotizacionPedido = new System.Windows.Forms.Button();
            this.v_COTIZACIONESDataGridView = new System.Windows.Forms.DataGridView();
            this.fiestasMexicanasDataSet = new FiestasMexicanas.FiestasMexicanasDataSet();
            this.vCOTIZACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_COTIZACIONESTableAdapter = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.v_COTIZACIONESTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamañoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hayMoldeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCOTIZACIONESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1049, 44);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Catálogo de cotizaciones y pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_guardarCotizacionPedido
            // 
            this.btn_guardarCotizacionPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardarCotizacionPedido.Location = new System.Drawing.Point(986, 56);
            this.btn_guardarCotizacionPedido.Name = "btn_guardarCotizacionPedido";
            this.btn_guardarCotizacionPedido.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarCotizacionPedido.TabIndex = 4;
            this.btn_guardarCotizacionPedido.Text = "Guardar";
            this.btn_guardarCotizacionPedido.UseVisualStyleBackColor = true;
            // 
            // v_COTIZACIONESDataGridView
            // 
            this.v_COTIZACIONESDataGridView.AllowUserToAddRows = false;
            this.v_COTIZACIONESDataGridView.AllowUserToDeleteRows = false;
            this.v_COTIZACIONESDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_COTIZACIONESDataGridView.AutoGenerateColumns = false;
            this.v_COTIZACIONESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.v_COTIZACIONESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_COTIZACIONESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.tamañoDataGridViewTextBoxColumn,
            this.detalleDataGridViewCheckBoxColumn,
            this.hayMoldeDataGridViewCheckBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.importeVentaDataGridViewTextBoxColumn,
            this.entregadoDataGridViewTextBoxColumn});
            this.v_COTIZACIONESDataGridView.DataSource = this.vCOTIZACIONESBindingSource;
            this.v_COTIZACIONESDataGridView.Location = new System.Drawing.Point(18, 85);
            this.v_COTIZACIONESDataGridView.Name = "v_COTIZACIONESDataGridView";
            this.v_COTIZACIONESDataGridView.ReadOnly = true;
            this.v_COTIZACIONESDataGridView.Size = new System.Drawing.Size(1043, 328);
            this.v_COTIZACIONESDataGridView.TabIndex = 5;
            // 
            // fiestasMexicanasDataSet
            // 
            this.fiestasMexicanasDataSet.DataSetName = "FiestasMexicanasDataSet";
            this.fiestasMexicanasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vCOTIZACIONESBindingSource
            // 
            this.vCOTIZACIONESBindingSource.DataMember = "v_COTIZACIONES";
            this.vCOTIZACIONESBindingSource.DataSource = this.fiestasMexicanasDataSet;
            // 
            // v_COTIZACIONESTableAdapter
            // 
            this.v_COTIZACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 53;
            // 
            // tamañoDataGridViewTextBoxColumn
            // 
            this.tamañoDataGridViewTextBoxColumn.DataPropertyName = "Tamaño";
            this.tamañoDataGridViewTextBoxColumn.HeaderText = "Tamaño";
            this.tamañoDataGridViewTextBoxColumn.Name = "tamañoDataGridViewTextBoxColumn";
            this.tamañoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamañoDataGridViewTextBoxColumn.Width = 71;
            // 
            // detalleDataGridViewCheckBoxColumn
            // 
            this.detalleDataGridViewCheckBoxColumn.DataPropertyName = "Detalle";
            this.detalleDataGridViewCheckBoxColumn.HeaderText = "Detalle";
            this.detalleDataGridViewCheckBoxColumn.Name = "detalleDataGridViewCheckBoxColumn";
            this.detalleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.detalleDataGridViewCheckBoxColumn.Width = 46;
            // 
            // hayMoldeDataGridViewCheckBoxColumn
            // 
            this.hayMoldeDataGridViewCheckBoxColumn.DataPropertyName = "Hay molde";
            this.hayMoldeDataGridViewCheckBoxColumn.HeaderText = "Hay molde";
            this.hayMoldeDataGridViewCheckBoxColumn.Name = "hayMoldeDataGridViewCheckBoxColumn";
            this.hayMoldeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hayMoldeDataGridViewCheckBoxColumn.Width = 63;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 64;
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            this.cANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADDataGridViewTextBoxColumn.Width = 87;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Precio unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 99;
            // 
            // importeVentaDataGridViewTextBoxColumn
            // 
            this.importeVentaDataGridViewTextBoxColumn.DataPropertyName = "Importe venta";
            this.importeVentaDataGridViewTextBoxColumn.HeaderText = "Importe venta";
            this.importeVentaDataGridViewTextBoxColumn.Name = "importeVentaDataGridViewTextBoxColumn";
            this.importeVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.importeVentaDataGridViewTextBoxColumn.Width = 97;
            // 
            // entregadoDataGridViewTextBoxColumn
            // 
            this.entregadoDataGridViewTextBoxColumn.DataPropertyName = "Entregado";
            this.entregadoDataGridViewTextBoxColumn.HeaderText = "Entregado";
            this.entregadoDataGridViewTextBoxColumn.Name = "entregadoDataGridViewTextBoxColumn";
            this.entregadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.entregadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.entregadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.entregadoDataGridViewTextBoxColumn.Width = 81;
            // 
            // frmPinataPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 425);
            this.Controls.Add(this.v_COTIZACIONESDataGridView);
            this.Controls.Add(this.btn_guardarCotizacionPedido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPinataPedidos";
            this.Text = "Catálogo de cotizaciones y pedidos";
            this.Load += new System.EventHandler(this.FrmPinataPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCOTIZACIONESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_guardarCotizacionPedido;
        private System.Windows.Forms.DataGridView v_COTIZACIONESDataGridView;
        private FiestasMexicanasDataSet fiestasMexicanasDataSet;
        private System.Windows.Forms.BindingSource vCOTIZACIONESBindingSource;
        private FiestasMexicanasDataSetTableAdapters.v_COTIZACIONESTableAdapter v_COTIZACIONESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamañoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn detalleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hayMoldeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn entregadoDataGridViewTextBoxColumn;
    }
}