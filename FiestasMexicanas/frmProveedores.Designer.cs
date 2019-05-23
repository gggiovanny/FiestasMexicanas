namespace FiestasMexicanas
{
    partial class frmProveedores
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_razonSocial = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.select_pais = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.select_estado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.select_ciudad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.fiestasMexicanasDataSet = new FiestasMexicanas.FiestasMexicanasDataSet();
            this.v_PROVEEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_PROVEEDORESTableAdapter = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.v_PROVEEDORESTableAdapter();
            this.tableAdapterManager = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.TableAdapterManager();
            this.v_PROVEEDORESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_PROVEEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_PROVEEDORESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(910, 44);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Proveedores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_codigo);
            this.groupBox4.Controls.Add(this.btn_buscar);
            this.groupBox4.Controls.Add(this.txt_razonSocial);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.select_pais);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.select_estado);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.select_ciudad);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_cel);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txt_email);
            this.groupBox4.Controls.Add(this.txt_tel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_direccion);
            this.groupBox4.Controls.Add(this.txt_apellidos);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_nombres);
            this.groupBox4.Location = new System.Drawing.Point(18, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(892, 224);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Codigo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(78, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(117, 20);
            this.txt_codigo.TabIndex = 33;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(488, 47);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 32;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.Location = new System.Drawing.Point(78, 75);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(404, 20);
            this.txt_razonSocial.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Razon Social";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(358, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "País";
            // 
            // select_pais
            // 
            this.select_pais.FormattingEnabled = true;
            this.select_pais.Location = new System.Drawing.Point(393, 127);
            this.select_pais.Name = "select_pais";
            this.select_pais.Size = new System.Drawing.Size(89, 21);
            this.select_pais.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Estado";
            // 
            // select_estado
            // 
            this.select_estado.FormattingEnabled = true;
            this.select_estado.Location = new System.Drawing.Point(245, 127);
            this.select_estado.Name = "select_estado";
            this.select_estado.Size = new System.Drawing.Size(89, 21);
            this.select_estado.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ciudad";
            // 
            // select_ciudad
            // 
            this.select_ciudad.FormattingEnabled = true;
            this.select_ciudad.Location = new System.Drawing.Point(78, 127);
            this.select_ciudad.Name = "select_ciudad";
            this.select_ciudad.Size = new System.Drawing.Size(89, 21);
            this.select_ciudad.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cel.";
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(245, 154);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(117, 20);
            this.txt_cel.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tel.";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(78, 180);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(176, 20);
            this.txt_email.TabIndex = 20;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(78, 154);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(117, 20);
            this.txt_tel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dirección";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(78, 101);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(404, 20);
            this.txt_direccion.TabIndex = 18;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(258, 49);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(224, 20);
            this.txt_apellidos.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombres";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(78, 49);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(117, 20);
            this.txt_nombres.TabIndex = 13;
            // 
            // fiestasMexicanasDataSet
            // 
            this.fiestasMexicanasDataSet.DataSetName = "FiestasMexicanasDataSet";
            this.fiestasMexicanasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_PROVEEDORESBindingSource
            // 
            this.v_PROVEEDORESBindingSource.DataMember = "v_PROVEEDORES";
            this.v_PROVEEDORESBindingSource.DataSource = this.fiestasMexicanasDataSet;
            // 
            // v_PROVEEDORESTableAdapter
            // 
            this.v_PROVEEDORESTableAdapter.ClearBeforeFill = true;
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
            // v_PROVEEDORESDataGridView
            // 
            this.v_PROVEEDORESDataGridView.AllowUserToAddRows = false;
            this.v_PROVEEDORESDataGridView.AllowUserToDeleteRows = false;
            this.v_PROVEEDORESDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_PROVEEDORESDataGridView.AutoGenerateColumns = false;
            this.v_PROVEEDORESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.v_PROVEEDORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_PROVEEDORESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.v_PROVEEDORESDataGridView.DataSource = this.v_PROVEEDORESBindingSource;
            this.v_PROVEEDORESDataGridView.Location = new System.Drawing.Point(18, 286);
            this.v_PROVEEDORESDataGridView.Name = "v_PROVEEDORESDataGridView";
            this.v_PROVEEDORESDataGridView.ReadOnly = true;
            this.v_PROVEEDORESDataGridView.Size = new System.Drawing.Size(892, 355);
            this.v_PROVEEDORESDataGridView.TabIndex = 34;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIRECCION";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 91;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TEL_";
            this.dataGridViewTextBoxColumn5.HeaderText = "TEL_";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 58;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CEL_";
            this.dataGridViewTextBoxColumn6.HeaderText = "CEL_";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 58;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn7.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 64;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PAIS";
            this.dataGridViewTextBoxColumn8.HeaderText = "PAIS";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 56;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ESTADO";
            this.dataGridViewTextBoxColumn9.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 76;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CIUDAD";
            this.dataGridViewTextBoxColumn10.HeaderText = "CIUDAD";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 73;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 653);
            this.Controls.Add(this.v_PROVEEDORESDataGridView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_PROVEEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_PROVEEDORESDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_razonSocial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox select_pais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox select_estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox select_ciudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombres;
        private FiestasMexicanasDataSet fiestasMexicanasDataSet;
        private System.Windows.Forms.BindingSource v_PROVEEDORESBindingSource;
        private FiestasMexicanasDataSetTableAdapters.v_PROVEEDORESTableAdapter v_PROVEEDORESTableAdapter;
        private FiestasMexicanasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView v_PROVEEDORESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}