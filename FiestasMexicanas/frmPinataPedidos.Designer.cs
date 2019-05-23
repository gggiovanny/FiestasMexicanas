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
            this.fiestasMexicanasDataSet = new FiestasMexicanas.FiestasMexicanasDataSet();
            this.v_COTIZACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_COTIZACIONESTableAdapter = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.v_COTIZACIONESTableAdapter();
            this.tableAdapterManager = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.TableAdapterManager();
            this.v_COTIZACIONESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(916, 44);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Catálogo de cotizaciones y pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_guardarCotizacionPedido
            // 
            this.btn_guardarCotizacionPedido.Location = new System.Drawing.Point(645, 56);
            this.btn_guardarCotizacionPedido.Name = "btn_guardarCotizacionPedido";
            this.btn_guardarCotizacionPedido.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarCotizacionPedido.TabIndex = 4;
            this.btn_guardarCotizacionPedido.Text = "Guardar";
            this.btn_guardarCotizacionPedido.UseVisualStyleBackColor = true;
            // 
            // fiestasMexicanasDataSet
            // 
            this.fiestasMexicanasDataSet.DataSetName = "FiestasMexicanasDataSet";
            this.fiestasMexicanasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_COTIZACIONESBindingSource
            // 
            this.v_COTIZACIONESBindingSource.DataMember = "v_COTIZACIONES";
            this.v_COTIZACIONESBindingSource.DataSource = this.fiestasMexicanasDataSet;
            // 
            // v_COTIZACIONESTableAdapter
            // 
            this.v_COTIZACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTESANOS_PEDIDOSTableAdapter = null;
            this.tableAdapterManager.ARTESANOSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATALOGO_CIUDADESTableAdapter = null;
            this.tableAdapterManager.CATALOGO_CLIENTESTableAdapter = null;
            this.tableAdapterManager.CATALOGO_EMPLEADOS_PUESTOSTableAdapter = null;
            this.tableAdapterManager.CATALOGO_EMPLEADOSTableAdapter = null;
            this.tableAdapterManager.CATALOGO_ESTADOSTableAdapter = null;
            this.tableAdapterManager.CATALOGO_PAISESTableAdapter = null;
            this.tableAdapterManager.CATALOGO_PEDIDO_ESTATUSTableAdapter = null;
            this.tableAdapterManager.CATALOGO_PROVEEDORESTableAdapter = null;
            this.tableAdapterManager.CATALOGO_TAMANO_PINATATableAdapter = null;
            this.tableAdapterManager.CATALOGO_TIPO_PINATATableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PEDIDO_PINATATableAdapter = null;
            this.tableAdapterManager.PRECIO_PINATATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOS_SISTEMATableAdapter = null;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.v_COTIZACIONESDataGridView.DataSource = this.v_COTIZACIONESBindingSource;
            this.v_COTIZACIONESDataGridView.Location = new System.Drawing.Point(18, 85);
            this.v_COTIZACIONESDataGridView.Name = "v_COTIZACIONESDataGridView";
            this.v_COTIZACIONESDataGridView.ReadOnly = true;
            this.v_COTIZACIONESDataGridView.Size = new System.Drawing.Size(910, 328);
            this.v_COTIZACIONESDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 53;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tamaño";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tamaño";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 71;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Detalle";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Detalle";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 46;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Hay molde";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Hay molde";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 63;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CLIENTE";
            this.dataGridViewTextBoxColumn5.HeaderText = "CLIENTE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 77;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CANTIDAD";
            this.dataGridViewTextBoxColumn6.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 87;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Importe venta";
            this.dataGridViewTextBoxColumn7.HeaderText = "Importe venta";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 97;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Entregado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Entregado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 81;
            // 
            // frmPinataPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 425);
            this.Controls.Add(this.v_COTIZACIONESDataGridView);
            this.Controls.Add(this.btn_guardarCotizacionPedido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPinataPedidos";
            this.Text = "Catálogo de cotizaciones y pedidos";
            this.Load += new System.EventHandler(this.FrmPinataPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_COTIZACIONESDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_guardarCotizacionPedido;
        private FiestasMexicanasDataSet fiestasMexicanasDataSet;
        private System.Windows.Forms.BindingSource v_COTIZACIONESBindingSource;
        private FiestasMexicanasDataSetTableAdapters.v_COTIZACIONESTableAdapter v_COTIZACIONESTableAdapter;
        private FiestasMexicanasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView v_COTIZACIONESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}