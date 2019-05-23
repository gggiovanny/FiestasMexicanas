namespace FiestasMexicanas
{
    partial class frmGestorGanancias
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidadPiñatas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_compraVenta = new System.Windows.Forms.TextBox();
            this.txt_articulosFiesta = new System.Windows.Forms.TextBox();
            this.txt_materiales = new System.Windows.Forms.TextBox();
            this.txt_sueldos = new System.Windows.Forms.TextBox();
            this.txt_servicios = new System.Windows.Forms.TextBox();
            this.txt_gasolina = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_otrosGastos = new System.Windows.Forms.TextBox();
            this.txt_otrosIngresos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_gananciaTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dulces = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtn_mes = new System.Windows.Forms.RadioButton();
            this.radioBtn_semana = new System.Windows.Forms.RadioButton();
            this.fiestasMexicanasDataSet = new FiestasMexicanas.FiestasMexicanasDataSet();
            this.v_GESTOR_GANANCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_GESTOR_GANANCIASTableAdapter = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.v_GESTOR_GANANCIASTableAdapter();
            this.tableAdapterManager = new FiestasMexicanas.FiestasMexicanasDataSetTableAdapters.TableAdapterManager();
            this.v_GESTOR_GANANCIASDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GESTOR_GANANCIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GESTOR_GANANCIASDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(824, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestor de ganancias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresos por piñatas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(646, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Piñatas:";
            // 
            // txt_cantidadPiñatas
            // 
            this.txt_cantidadPiñatas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_cantidadPiñatas.Location = new System.Drawing.Point(705, 137);
            this.txt_cantidadPiñatas.Name = "txt_cantidadPiñatas";
            this.txt_cantidadPiñatas.ReadOnly = true;
            this.txt_cantidadPiñatas.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidadPiñatas.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "+ Ingresos totales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Sueldos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Materiales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Servicios:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 26);
            this.label8.TabIndex = 40;
            this.label8.Text = "- Gastos totales";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Compra-venta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Articulos de fiesta:";
            // 
            // txt_compraVenta
            // 
            this.txt_compraVenta.Location = new System.Drawing.Point(139, 57);
            this.txt_compraVenta.Name = "txt_compraVenta";
            this.txt_compraVenta.Size = new System.Drawing.Size(100, 20);
            this.txt_compraVenta.TabIndex = 43;
            // 
            // txt_articulosFiesta
            // 
            this.txt_articulosFiesta.Location = new System.Drawing.Point(139, 83);
            this.txt_articulosFiesta.Name = "txt_articulosFiesta";
            this.txt_articulosFiesta.Size = new System.Drawing.Size(100, 20);
            this.txt_articulosFiesta.TabIndex = 44;
            // 
            // txt_materiales
            // 
            this.txt_materiales.Location = new System.Drawing.Point(139, 15);
            this.txt_materiales.Name = "txt_materiales";
            this.txt_materiales.Size = new System.Drawing.Size(100, 20);
            this.txt_materiales.TabIndex = 45;
            // 
            // txt_sueldos
            // 
            this.txt_sueldos.Location = new System.Drawing.Point(139, 41);
            this.txt_sueldos.Name = "txt_sueldos";
            this.txt_sueldos.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldos.TabIndex = 46;
            // 
            // txt_servicios
            // 
            this.txt_servicios.Location = new System.Drawing.Point(139, 67);
            this.txt_servicios.Name = "txt_servicios";
            this.txt_servicios.Size = new System.Drawing.Size(100, 20);
            this.txt_servicios.TabIndex = 47;
            // 
            // txt_gasolina
            // 
            this.txt_gasolina.Location = new System.Drawing.Point(139, 93);
            this.txt_gasolina.Name = "txt_gasolina";
            this.txt_gasolina.Size = new System.Drawing.Size(100, 20);
            this.txt_gasolina.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Gasolina:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(90, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Otros:";
            // 
            // txt_otrosGastos
            // 
            this.txt_otrosGastos.Location = new System.Drawing.Point(139, 119);
            this.txt_otrosGastos.Name = "txt_otrosGastos";
            this.txt_otrosGastos.Size = new System.Drawing.Size(100, 20);
            this.txt_otrosGastos.TabIndex = 51;
            // 
            // txt_otrosIngresos
            // 
            this.txt_otrosIngresos.Location = new System.Drawing.Point(139, 109);
            this.txt_otrosIngresos.Name = "txt_otrosIngresos";
            this.txt_otrosIngresos.Size = new System.Drawing.Size(100, 20);
            this.txt_otrosIngresos.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(90, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "Otros:";
            // 
            // txt_gananciaTotal
            // 
            this.txt_gananciaTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_gananciaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gananciaTotal.Location = new System.Drawing.Point(736, 507);
            this.txt_gananciaTotal.Name = "txt_gananciaTotal";
            this.txt_gananciaTotal.Size = new System.Drawing.Size(100, 26);
            this.txt_gananciaTotal.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(598, 510);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 56;
            this.label15.Text = "Ganancia total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dulces:";
            // 
            // txt_dulces
            // 
            this.txt_dulces.Location = new System.Drawing.Point(139, 31);
            this.txt_dulces.Name = "txt_dulces";
            this.txt_dulces.Size = new System.Drawing.Size(100, 20);
            this.txt_dulces.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.txt_otrosIngresos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_dulces);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_compraVenta);
            this.groupBox1.Controls.Add(this.txt_articulosFiesta);
            this.groupBox1.Location = new System.Drawing.Point(566, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos adicionales";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.txt_otrosGastos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_materiales);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_sueldos);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_servicios);
            this.groupBox2.Controls.Add(this.txt_gasolina);
            this.groupBox2.Location = new System.Drawing.Point(566, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 149);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtn_mes);
            this.groupBox3.Controls.Add(this.radioBtn_semana);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 52);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Periodo";
            // 
            // radioBtn_mes
            // 
            this.radioBtn_mes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioBtn_mes.AutoSize = true;
            this.radioBtn_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_mes.Location = new System.Drawing.Point(93, 19);
            this.radioBtn_mes.Name = "radioBtn_mes";
            this.radioBtn_mes.Size = new System.Drawing.Size(58, 19);
            this.radioBtn_mes.TabIndex = 3;
            this.radioBtn_mes.TabStop = true;
            this.radioBtn_mes.Text = "x Mes";
            this.radioBtn_mes.UseVisualStyleBackColor = true;
            // 
            // radioBtn_semana
            // 
            this.radioBtn_semana.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioBtn_semana.AutoSize = true;
            this.radioBtn_semana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_semana.Location = new System.Drawing.Point(6, 19);
            this.radioBtn_semana.Name = "radioBtn_semana";
            this.radioBtn_semana.Size = new System.Drawing.Size(81, 19);
            this.radioBtn_semana.TabIndex = 2;
            this.radioBtn_semana.TabStop = true;
            this.radioBtn_semana.Text = "x Semana";
            this.radioBtn_semana.UseVisualStyleBackColor = true;
            // 
            // fiestasMexicanasDataSet
            // 
            this.fiestasMexicanasDataSet.DataSetName = "FiestasMexicanasDataSet";
            this.fiestasMexicanasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_GESTOR_GANANCIASBindingSource
            // 
            this.v_GESTOR_GANANCIASBindingSource.DataMember = "v_GESTOR_GANANCIAS";
            this.v_GESTOR_GANANCIASBindingSource.DataSource = this.fiestasMexicanasDataSet;
            // 
            // v_GESTOR_GANANCIASTableAdapter
            // 
            this.v_GESTOR_GANANCIASTableAdapter.ClearBeforeFill = true;
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
            // v_GESTOR_GANANCIASDataGridView
            // 
            this.v_GESTOR_GANANCIASDataGridView.AllowUserToAddRows = false;
            this.v_GESTOR_GANANCIASDataGridView.AllowUserToDeleteRows = false;
            this.v_GESTOR_GANANCIASDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_GESTOR_GANANCIASDataGridView.AutoGenerateColumns = false;
            this.v_GESTOR_GANANCIASDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.v_GESTOR_GANANCIASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_GESTOR_GANANCIASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.v_GESTOR_GANANCIASDataGridView.DataSource = this.v_GESTOR_GANANCIASBindingSource;
            this.v_GESTOR_GANANCIASDataGridView.Location = new System.Drawing.Point(12, 137);
            this.v_GESTOR_GANANCIASDataGridView.Name = "v_GESTOR_GANANCIASDataGridView";
            this.v_GESTOR_GANANCIASDataGridView.ReadOnly = true;
            this.v_GESTOR_GANANCIASDataGridView.Size = new System.Drawing.Size(544, 352);
            this.v_GESTOR_GANANCIASDataGridView.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FECHA";
            this.dataGridViewTextBoxColumn1.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 67;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PIÑATAS VENDIDAS";
            this.dataGridViewTextBoxColumn2.HeaderText = "PIÑATAS VENDIDAS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 124;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VENTAS BRUTAS";
            this.dataGridViewTextBoxColumn3.HeaderText = "VENTAS BRUTAS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IVA";
            this.dataGridViewTextBoxColumn4.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 49;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VENTAS NETAS";
            this.dataGridViewTextBoxColumn5.HeaderText = "VENTAS NETAS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 105;
            // 
            // frmGestorGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 549);
            this.Controls.Add(this.v_GESTOR_GANANCIASDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_gananciaTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cantidadPiñatas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmGestorGanancias";
            this.Text = "Gestor de ganancias";
            this.Load += new System.EventHandler(this.FrmGestorGanancias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiestasMexicanasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GESTOR_GANANCIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GESTOR_GANANCIASDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidadPiñatas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_compraVenta;
        private System.Windows.Forms.TextBox txt_articulosFiesta;
        private System.Windows.Forms.TextBox txt_materiales;
        private System.Windows.Forms.TextBox txt_sueldos;
        private System.Windows.Forms.TextBox txt_servicios;
        private System.Windows.Forms.TextBox txt_gasolina;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_otrosGastos;
        private System.Windows.Forms.TextBox txt_otrosIngresos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_gananciaTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dulces;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtn_mes;
        private System.Windows.Forms.RadioButton radioBtn_semana;
        private FiestasMexicanasDataSet fiestasMexicanasDataSet;
        private System.Windows.Forms.BindingSource v_GESTOR_GANANCIASBindingSource;
        private FiestasMexicanasDataSetTableAdapters.v_GESTOR_GANANCIASTableAdapter v_GESTOR_GANANCIASTableAdapter;
        private FiestasMexicanasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView v_GESTOR_GANANCIASDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}