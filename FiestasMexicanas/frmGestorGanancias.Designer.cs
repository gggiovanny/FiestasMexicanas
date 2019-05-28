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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtn_mes = new System.Windows.Forms.RadioButton();
            this.radioBtn_semana = new System.Windows.Forms.RadioButton();
            this.grdIngresosPinata = new System.Windows.Forms.DataGridView();
            this.numDulces = new System.Windows.Forms.NumericUpDown();
            this.numCompraVenta = new System.Windows.Forms.NumericUpDown();
            this.numArtFiesta = new System.Windows.Forms.NumericUpDown();
            this.numOtrosIngresos = new System.Windows.Forms.NumericUpDown();
            this.numMateriales = new System.Windows.Forms.NumericUpDown();
            this.numSueldos = new System.Windows.Forms.NumericUpDown();
            this.numServicios = new System.Windows.Forms.NumericUpDown();
            this.numGasolina = new System.Windows.Forms.NumericUpDown();
            this.numOtrosGastos = new System.Windows.Forms.NumericUpDown();
            this.numGananciaTotal = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngresosPinata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDulces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArtFiesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtrosIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasolina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtrosGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGananciaTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(862, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestor de ganancias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresos por piñatas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Piñatas:";
            // 
            // txt_cantidadPiñatas
            // 
            this.txt_cantidadPiñatas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_cantidadPiñatas.Location = new System.Drawing.Point(743, 154);
            this.txt_cantidadPiñatas.Name = "txt_cantidadPiñatas";
            this.txt_cantidadPiñatas.ReadOnly = true;
            this.txt_cantidadPiñatas.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidadPiñatas.TabIndex = 12;
            this.txt_cantidadPiñatas.TextChanged += new System.EventHandler(this.Num_Editado);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 121);
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
            this.label8.Location = new System.Drawing.Point(615, 328);
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
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(619, 531);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.numOtrosIngresos);
            this.groupBox1.Controls.Add(this.numArtFiesta);
            this.groupBox1.Controls.Add(this.numCompraVenta);
            this.groupBox1.Controls.Add(this.numDulces);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(604, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos adicionales";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.numOtrosGastos);
            this.groupBox2.Controls.Add(this.numGasolina);
            this.groupBox2.Controls.Add(this.numServicios);
            this.groupBox2.Controls.Add(this.numSueldos);
            this.groupBox2.Controls.Add(this.numMateriales);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(604, 357);
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
            // grdIngresosPinata
            // 
            this.grdIngresosPinata.AllowUserToAddRows = false;
            this.grdIngresosPinata.AllowUserToDeleteRows = false;
            this.grdIngresosPinata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdIngresosPinata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdIngresosPinata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIngresosPinata.Location = new System.Drawing.Point(16, 129);
            this.grdIngresosPinata.Name = "grdIngresosPinata";
            this.grdIngresosPinata.ReadOnly = true;
            this.grdIngresosPinata.Size = new System.Drawing.Size(576, 426);
            this.grdIngresosPinata.TabIndex = 60;
            // 
            // numDulces
            // 
            this.numDulces.DecimalPlaces = 2;
            this.numDulces.Location = new System.Drawing.Point(139, 31);
            this.numDulces.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDulces.Name = "numDulces";
            this.numDulces.Size = new System.Drawing.Size(100, 20);
            this.numDulces.TabIndex = 61;
            this.numDulces.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numCompraVenta
            // 
            this.numCompraVenta.DecimalPlaces = 2;
            this.numCompraVenta.Location = new System.Drawing.Point(139, 58);
            this.numCompraVenta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCompraVenta.Name = "numCompraVenta";
            this.numCompraVenta.Size = new System.Drawing.Size(100, 20);
            this.numCompraVenta.TabIndex = 62;
            this.numCompraVenta.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numArtFiesta
            // 
            this.numArtFiesta.DecimalPlaces = 2;
            this.numArtFiesta.Location = new System.Drawing.Point(139, 84);
            this.numArtFiesta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numArtFiesta.Name = "numArtFiesta";
            this.numArtFiesta.Size = new System.Drawing.Size(100, 20);
            this.numArtFiesta.TabIndex = 63;
            this.numArtFiesta.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numOtrosIngresos
            // 
            this.numOtrosIngresos.DecimalPlaces = 2;
            this.numOtrosIngresos.Location = new System.Drawing.Point(139, 110);
            this.numOtrosIngresos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numOtrosIngresos.Name = "numOtrosIngresos";
            this.numOtrosIngresos.Size = new System.Drawing.Size(100, 20);
            this.numOtrosIngresos.TabIndex = 64;
            this.numOtrosIngresos.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numMateriales
            // 
            this.numMateriales.DecimalPlaces = 2;
            this.numMateriales.Location = new System.Drawing.Point(139, 15);
            this.numMateriales.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMateriales.Name = "numMateriales";
            this.numMateriales.Size = new System.Drawing.Size(100, 20);
            this.numMateriales.TabIndex = 65;
            this.numMateriales.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numSueldos
            // 
            this.numSueldos.DecimalPlaces = 2;
            this.numSueldos.Location = new System.Drawing.Point(139, 41);
            this.numSueldos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSueldos.Name = "numSueldos";
            this.numSueldos.Size = new System.Drawing.Size(100, 20);
            this.numSueldos.TabIndex = 66;
            this.numSueldos.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numServicios
            // 
            this.numServicios.DecimalPlaces = 2;
            this.numServicios.Location = new System.Drawing.Point(139, 67);
            this.numServicios.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numServicios.Name = "numServicios";
            this.numServicios.Size = new System.Drawing.Size(100, 20);
            this.numServicios.TabIndex = 67;
            this.numServicios.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numGasolina
            // 
            this.numGasolina.DecimalPlaces = 2;
            this.numGasolina.Location = new System.Drawing.Point(139, 93);
            this.numGasolina.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numGasolina.Name = "numGasolina";
            this.numGasolina.Size = new System.Drawing.Size(100, 20);
            this.numGasolina.TabIndex = 68;
            this.numGasolina.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numOtrosGastos
            // 
            this.numOtrosGastos.DecimalPlaces = 2;
            this.numOtrosGastos.Location = new System.Drawing.Point(139, 119);
            this.numOtrosGastos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numOtrosGastos.Name = "numOtrosGastos";
            this.numOtrosGastos.Size = new System.Drawing.Size(100, 20);
            this.numOtrosGastos.TabIndex = 69;
            this.numOtrosGastos.ValueChanged += new System.EventHandler(this.Num_Editado);
            // 
            // numGananciaTotal
            // 
            this.numGananciaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numGananciaTotal.DecimalPlaces = 2;
            this.numGananciaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGananciaTotal.Location = new System.Drawing.Point(757, 529);
            this.numGananciaTotal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numGananciaTotal.Name = "numGananciaTotal";
            this.numGananciaTotal.ReadOnly = true;
            this.numGananciaTotal.Size = new System.Drawing.Size(100, 26);
            this.numGananciaTotal.TabIndex = 66;
            // 
            // frmGestorGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 583);
            this.Controls.Add(this.numGananciaTotal);
            this.Controls.Add(this.grdIngresosPinata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdIngresosPinata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDulces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompraVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArtFiesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtrosIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGasolina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtrosGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGananciaTotal)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtn_mes;
        private System.Windows.Forms.RadioButton radioBtn_semana;
        private System.Windows.Forms.DataGridView grdIngresosPinata;
        private System.Windows.Forms.NumericUpDown numDulces;
        private System.Windows.Forms.NumericUpDown numOtrosIngresos;
        private System.Windows.Forms.NumericUpDown numArtFiesta;
        private System.Windows.Forms.NumericUpDown numCompraVenta;
        private System.Windows.Forms.NumericUpDown numOtrosGastos;
        private System.Windows.Forms.NumericUpDown numGasolina;
        private System.Windows.Forms.NumericUpDown numServicios;
        private System.Windows.Forms.NumericUpDown numSueldos;
        private System.Windows.Forms.NumericUpDown numMateriales;
        private System.Windows.Forms.NumericUpDown numGananciaTotal;
    }
}