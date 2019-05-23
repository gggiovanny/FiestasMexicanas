namespace FiestasMexicanas
{
    partial class frmArtesanoAsignacionTrabajo
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
            this.btn_artesanoPedido = new System.Windows.Forms.Button();
            this.btn_pedidoArtesano = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.fiestasMexicanasDataSet = new FiestasMexicanas.FiestasMexicanasDataSet();
            this.v_ASIGNACION_TRABAJO_ARTESANOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ASIGNACION_TRABAJO_ARTESANOSTableAdapter = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.v_ASIGNACION_TRABAJO_ARTESANOSTableAdapter();
            this.tableAdapterManager = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.TableAdapterManager();
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOTableAdapter = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOTableAdapter();
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ASIGNACION_TRABAJO_ARTESANOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1444, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Asignacion de carga de trabajo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_artesanoPedido
            // 
            this.btn_artesanoPedido.Location = new System.Drawing.Point(566, 306);
            this.btn_artesanoPedido.Name = "btn_artesanoPedido";
            this.btn_artesanoPedido.Size = new System.Drawing.Size(24, 23);
            this.btn_artesanoPedido.TabIndex = 4;
            this.btn_artesanoPedido.Text = "->";
            this.btn_artesanoPedido.UseVisualStyleBackColor = true;
            // 
            // btn_pedidoArtesano
            // 
            this.btn_pedidoArtesano.Location = new System.Drawing.Point(566, 277);
            this.btn_pedidoArtesano.Name = "btn_pedidoArtesano";
            this.btn_pedidoArtesano.Size = new System.Drawing.Size(24, 23);
            this.btn_pedidoArtesano.TabIndex = 5;
            this.btn_pedidoArtesano.Text = "<-";
            this.btn_pedidoArtesano.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(862, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artesanos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(928, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pedidos en espera";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fiestasMexicanasDataSet
            // 
            this.fiestasMexicanasDataSet.DataSetName = "FiestasMexicanasDataSet";
            this.fiestasMexicanasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_ASIGNACION_TRABAJO_ARTESANOSBindingSource
            // 
            this.v_ASIGNACION_TRABAJO_ARTESANOSBindingSource.DataMember = "v_ASIGNACION_TRABAJO_ARTESANOS";
            this.v_ASIGNACION_TRABAJO_ARTESANOSBindingSource.DataSource = this.fiestasMexicanasDataSet;
            // 
            // v_ASIGNACION_TRABAJO_ARTESANOSTableAdapter
            // 
            this.v_ASIGNACION_TRABAJO_ARTESANOSTableAdapter.ClearBeforeFill = true;
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
            // v_ASIGNACION_TRABAJO_ARTESANOSDataGridView
            // 
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.AllowUserToAddRows = false;
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.AllowUserToDeleteRows = false;
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.AutoGenerateColumns = false;
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.DataSource = this.v_ASIGNACION_TRABAJO_ARTESANOSBindingSource;
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.Location = new System.Drawing.Point(18, 141);
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.Name = "v_ASIGNACION_TRABAJO_ARTESANOSDataGridView";
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.ReadOnly = true;
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.Size = new System.Drawing.Size(517, 388);
            this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "APELLIDOS";
            this.dataGridViewTextBoxColumn3.HeaderText = "APELLIDOS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EN COLA";
            this.dataGridViewTextBoxColumn4.HeaderText = "EN COLA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 72;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GANANCIA %";
            this.dataGridViewTextBoxColumn5.HeaderText = "GANANCIA %";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NO_ PEDIDOS";
            this.dataGridViewTextBoxColumn6.HeaderText = "NO_ PEDIDOS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 96;
            // 
            // v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOBindingSource
            // 
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOBindingSource.DataMember = "v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDO";
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOBindingSource.DataSource = this.fiestasMexicanasDataSet;
            // 
            // v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOTableAdapter
            // 
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOTableAdapter.ClearBeforeFill = true;
            // 
            // v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView
            // 
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.AllowUserToAddRows = false;
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.AllowUserToDeleteRows = false;
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.AutoGenerateColumns = false;
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.DataSource = this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOBindingSource;
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.Location = new System.Drawing.Point(618, 141);
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.Name = "v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView";
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.ReadOnly = true;
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.Size = new System.Drawing.Size(838, 388);
            this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FOLIO";
            this.dataGridViewTextBoxColumn7.HeaderText = "FOLIO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 63;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FECHA PEDIDO";
            this.dataGridViewTextBoxColumn8.HeaderText = "FECHA PEDIDO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 102;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FECHA ENTREGA";
            this.dataGridViewTextBoxColumn9.HeaderText = "FECHA ENTREGA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 112;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TIPO";
            this.dataGridViewTextBoxColumn10.HeaderText = "TIPO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 57;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TAMAÑO";
            this.dataGridViewTextBoxColumn11.HeaderText = "TAMAÑO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 78;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "DETALLE";
            this.dataGridViewCheckBoxColumn1.HeaderText = "DETALLE";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 61;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "MOLDE";
            this.dataGridViewCheckBoxColumn2.HeaderText = "MOLDE";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 51;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DESCRIPCION";
            this.dataGridViewTextBoxColumn12.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 105;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CANTIDAD";
            this.dataGridViewTextBoxColumn13.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 87;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CLIENTE";
            this.dataGridViewTextBoxColumn14.HeaderText = "CLIENTE";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 77;
            // 
            // frmArtesanoAsignacionTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 549);
            this.Controls.Add(this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView);
            this.Controls.Add(this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pedidoArtesano);
            this.Controls.Add(this.btn_artesanoPedido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmArtesanoAsignacionTrabajo";
            this.Text = "Asignacion de carga de trabajo";
            this.Load += new System.EventHandler(this.FrmArtesanoAsignacionTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ASIGNACION_TRABAJO_ARTESANOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ASIGNACION_TRABAJO_ARTESANOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_artesanoPedido;
        private System.Windows.Forms.Button btn_pedidoArtesano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private FiestasMexicanasDataSet fiestasMexicanasDataSet;
        private System.Windows.Forms.BindingSource v_ASIGNACION_TRABAJO_ARTESANOSBindingSource;
        private FiestasMexicanasDataSetTableAdapters.v_ASIGNACION_TRABAJO_ARTESANOSTableAdapter v_ASIGNACION_TRABAJO_ARTESANOSTableAdapter;
        private FiestasMexicanasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView v_ASIGNACION_TRABAJO_ARTESANOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOBindingSource;
        private FiestasMexicanasDataSetTableAdapters.v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOTableAdapter v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDOTableAdapter;
        private System.Windows.Forms.DataGridView v_ASIGNACION_TRABAJO_PEDIDOS_ESPERANDODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}