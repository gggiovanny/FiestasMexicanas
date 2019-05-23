namespace FiestasMexicanas
{
    partial class frmArtesanosVisorTrabajo
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
            this.radioBtn_espera = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_terminada = new System.Windows.Forms.RadioButton();
            this.radioBtn_forrando = new System.Windows.Forms.RadioButton();
            this.radioBtn_armando = new System.Windows.Forms.RadioButton();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.fiestasMexicanasDataSet = new FiestasMexicanas.FiestasMexicanasDataSet();
            this.v_VISOR_CARGA_TRABAJOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_VISOR_CARGA_TRABAJOTableAdapter = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.v_VISOR_CARGA_TRABAJOTableAdapter();
            this.tableAdapterManager = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.TableAdapterManager();
            this.v_VISOR_CARGA_TRABAJODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_VISOR_CARGA_TRABAJOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_VISOR_CARGA_TRABAJODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(921, 44);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Visor de carga de trabajo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // radioBtn_espera
            // 
            this.radioBtn_espera.AutoSize = true;
            this.radioBtn_espera.Location = new System.Drawing.Point(23, 28);
            this.radioBtn_espera.Name = "radioBtn_espera";
            this.radioBtn_espera.Size = new System.Drawing.Size(73, 17);
            this.radioBtn_espera.TabIndex = 5;
            this.radioBtn_espera.TabStop = true;
            this.radioBtn_espera.Text = "En espera";
            this.radioBtn_espera.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_terminada);
            this.groupBox1.Controls.Add(this.radioBtn_forrando);
            this.groupBox1.Controls.Add(this.radioBtn_armando);
            this.groupBox1.Controls.Add(this.radioBtn_espera);
            this.groupBox1.Location = new System.Drawing.Point(18, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatus";
            // 
            // radioBtn_terminada
            // 
            this.radioBtn_terminada.AutoSize = true;
            this.radioBtn_terminada.Location = new System.Drawing.Point(275, 28);
            this.radioBtn_terminada.Name = "radioBtn_terminada";
            this.radioBtn_terminada.Size = new System.Drawing.Size(75, 17);
            this.radioBtn_terminada.TabIndex = 8;
            this.radioBtn_terminada.TabStop = true;
            this.radioBtn_terminada.Text = "Terminada";
            this.radioBtn_terminada.UseVisualStyleBackColor = true;
            // 
            // radioBtn_forrando
            // 
            this.radioBtn_forrando.AutoSize = true;
            this.radioBtn_forrando.Location = new System.Drawing.Point(202, 28);
            this.radioBtn_forrando.Name = "radioBtn_forrando";
            this.radioBtn_forrando.Size = new System.Drawing.Size(67, 17);
            this.radioBtn_forrando.TabIndex = 7;
            this.radioBtn_forrando.TabStop = true;
            this.radioBtn_forrando.Text = "Forrando";
            this.radioBtn_forrando.UseVisualStyleBackColor = true;
            // 
            // radioBtn_armando
            // 
            this.radioBtn_armando.AutoSize = true;
            this.radioBtn_armando.Location = new System.Drawing.Point(111, 28);
            this.radioBtn_armando.Name = "radioBtn_armando";
            this.radioBtn_armando.Size = new System.Drawing.Size(67, 17);
            this.radioBtn_armando.TabIndex = 6;
            this.radioBtn_armando.TabStop = true;
            this.radioBtn_armando.Text = "Armando";
            this.radioBtn_armando.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(479, 76);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(121, 48);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // fiestasMexicanasDataSet
            // 
            this.fiestasMexicanasDataSet.DataSetName = "FiestasMexicanasDataSet";
            this.fiestasMexicanasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_VISOR_CARGA_TRABAJOBindingSource
            // 
            this.v_VISOR_CARGA_TRABAJOBindingSource.DataMember = "v_VISOR_CARGA_TRABAJO";
            this.v_VISOR_CARGA_TRABAJOBindingSource.DataSource = this.fiestasMexicanasDataSet;
            // 
            // v_VISOR_CARGA_TRABAJOTableAdapter
            // 
            this.v_VISOR_CARGA_TRABAJOTableAdapter.ClearBeforeFill = true;
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
            // v_VISOR_CARGA_TRABAJODataGridView
            // 
            this.v_VISOR_CARGA_TRABAJODataGridView.AllowUserToAddRows = false;
            this.v_VISOR_CARGA_TRABAJODataGridView.AllowUserToDeleteRows = false;
            this.v_VISOR_CARGA_TRABAJODataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_VISOR_CARGA_TRABAJODataGridView.AutoGenerateColumns = false;
            this.v_VISOR_CARGA_TRABAJODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.v_VISOR_CARGA_TRABAJODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_VISOR_CARGA_TRABAJODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.v_VISOR_CARGA_TRABAJODataGridView.DataSource = this.v_VISOR_CARGA_TRABAJOBindingSource;
            this.v_VISOR_CARGA_TRABAJODataGridView.Location = new System.Drawing.Point(18, 146);
            this.v_VISOR_CARGA_TRABAJODataGridView.Name = "v_VISOR_CARGA_TRABAJODataGridView";
            this.v_VISOR_CARGA_TRABAJODataGridView.ReadOnly = true;
            this.v_VISOR_CARGA_TRABAJODataGridView.Size = new System.Drawing.Size(915, 346);
            this.v_VISOR_CARGA_TRABAJODataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 79;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "APELLIDOS";
            this.dataGridViewTextBoxColumn2.HeaderText = "APELLIDOS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 91;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PIÑATAS EN COLA";
            this.dataGridViewTextBoxColumn3.HeaderText = "PIÑATAS EN COLA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID PIÑATA";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID PIÑATA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TIPO";
            this.dataGridViewTextBoxColumn5.HeaderText = "TIPO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 57;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TAMAÑO";
            this.dataGridViewTextBoxColumn6.HeaderText = "TAMAÑO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 78;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DESCRIPCION";
            this.dataGridViewTextBoxColumn7.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 105;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CANTIDAD";
            this.dataGridViewTextBoxColumn8.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 87;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ESTATUS";
            this.dataGridViewTextBoxColumn9.HeaderText = "ESTATUS";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 82;
            // 
            // frmArtesanosVisorTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 504);
            this.Controls.Add(this.v_VISOR_CARGA_TRABAJODataGridView);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmArtesanosVisorTrabajo";
            this.Text = "Visor de carga de trabajo";
            this.Load += new System.EventHandler(this.FrmArtesanosVisorTrabajo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_VISOR_CARGA_TRABAJOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_VISOR_CARGA_TRABAJODataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton radioBtn_espera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_terminada;
        private System.Windows.Forms.RadioButton radioBtn_forrando;
        private System.Windows.Forms.RadioButton radioBtn_armando;
        private System.Windows.Forms.Button btn_guardar;
        private FiestasMexicanasDataSet fiestasMexicanasDataSet;
        private System.Windows.Forms.BindingSource v_VISOR_CARGA_TRABAJOBindingSource;
        private FiestasMexicanasDataSetTableAdapters.v_VISOR_CARGA_TRABAJOTableAdapter v_VISOR_CARGA_TRABAJOTableAdapter;
        private FiestasMexicanasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView v_VISOR_CARGA_TRABAJODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}