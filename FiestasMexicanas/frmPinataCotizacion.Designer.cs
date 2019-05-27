namespace FiestasMexicanas
{
    partial class frmPinataCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPinataCotizacion));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpoTamaño = new System.Windows.Forms.GroupBox();
            this.select_tamano = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_detallada = new System.Windows.Forms.RadioButton();
            this.radioBtn_sencilla = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_metrosAprox = new System.Windows.Forms.NumericUpDown();
            this.btn_estimarCosto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_fechaEntrega = new System.Windows.Forms.Label();
            this.dateFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txt_descripcionPinata = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label14 = new System.Windows.Forms.Label();
            this.btn_guardarPedido = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.select_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.check_existeMolde = new System.Windows.Forms.CheckBox();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.num_PrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.check_LlevaEstructuraAlambre = new System.Windows.Forms.CheckBox();
            this.gpoTamaño.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_metrosAprox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PrecioVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(530, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cotización";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // gpoTamaño
            // 
            this.gpoTamaño.Controls.Add(this.select_tamano);
            this.gpoTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoTamaño.Location = new System.Drawing.Point(15, 115);
            this.gpoTamaño.Name = "gpoTamaño";
            this.gpoTamaño.Size = new System.Drawing.Size(345, 55);
            this.gpoTamaño.TabIndex = 3;
            this.gpoTamaño.TabStop = false;
            this.gpoTamaño.Text = "Tamaño";
            // 
            // select_tamano
            // 
            this.select_tamano.DisplayMember = "ctampCodigo";
            this.select_tamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_tamano.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.select_tamano.FormattingEnabled = true;
            this.select_tamano.Location = new System.Drawing.Point(10, 21);
            this.select_tamano.Name = "select_tamano";
            this.select_tamano.Size = new System.Drawing.Size(328, 24);
            this.select_tamano.TabIndex = 1;
            this.select_tamano.TabStop = false;
            this.select_tamano.ValueMember = "ctampCodigo";
            this.select_tamano.SelectedIndexChanged += new System.EventHandler(this.Select_tamano_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_detallada);
            this.groupBox1.Controls.Add(this.radioBtn_sencilla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel de detalle";
            // 
            // radioBtn_detallada
            // 
            this.radioBtn_detallada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioBtn_detallada.AutoSize = true;
            this.radioBtn_detallada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_detallada.Location = new System.Drawing.Point(109, 25);
            this.radioBtn_detallada.Name = "radioBtn_detallada";
            this.radioBtn_detallada.Size = new System.Drawing.Size(78, 19);
            this.radioBtn_detallada.TabIndex = 3;
            this.radioBtn_detallada.TabStop = true;
            this.radioBtn_detallada.Text = "Detallada";
            this.radioBtn_detallada.UseVisualStyleBackColor = true;
            // 
            // radioBtn_sencilla
            // 
            this.radioBtn_sencilla.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioBtn_sencilla.AutoSize = true;
            this.radioBtn_sencilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_sencilla.Location = new System.Drawing.Point(11, 25);
            this.radioBtn_sencilla.Name = "radioBtn_sencilla";
            this.radioBtn_sencilla.Size = new System.Drawing.Size(69, 19);
            this.radioBtn_sencilla.TabIndex = 2;
            this.radioBtn_sencilla.TabStop = true;
            this.radioBtn_sencilla.Text = "Sencilla";
            this.radioBtn_sencilla.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_LlevaEstructuraAlambre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.num_metrosAprox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Molde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Metros aprox.";
            // 
            // num_metrosAprox
            // 
            this.num_metrosAprox.Enabled = false;
            this.num_metrosAprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_metrosAprox.Location = new System.Drawing.Point(272, 25);
            this.num_metrosAprox.Name = "num_metrosAprox";
            this.num_metrosAprox.Size = new System.Drawing.Size(67, 22);
            this.num_metrosAprox.TabIndex = 4;
            // 
            // btn_estimarCosto
            // 
            this.btn_estimarCosto.Location = new System.Drawing.Point(15, 326);
            this.btn_estimarCosto.Name = "btn_estimarCosto";
            this.btn_estimarCosto.Size = new System.Drawing.Size(120, 23);
            this.btn_estimarCosto.TabIndex = 8;
            this.btn_estimarCosto.Text = "Estimar costo";
            this.btn_estimarCosto.UseVisualStyleBackColor = true;
            this.btn_estimarCosto.Click += new System.EventHandler(this.Btn_estimarCosto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Precio de venta";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(280, 319);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(103, 29);
            this.lbl_precio.TabIndex = 11;
            this.lbl_precio.Text = "M.X.N*.";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_nombres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombres.Location = new System.Drawing.Point(83, 19);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(117, 20);
            this.txt_nombres.TabIndex = 13;
            this.txt_nombres.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_AutoCompletadoLlenar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombres";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lbl_fechaEntrega);
            this.groupBox4.Controls.Add(this.dateFechaEntrega);
            this.groupBox4.Controls.Add(this.txt_descripcionPinata);
            this.groupBox4.Controls.Add(this.label16);
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
            this.groupBox4.Location = new System.Drawing.Point(14, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 284);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del cliente";
            // 
            // lbl_fechaEntrega
            // 
            this.lbl_fechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fechaEntrega.AutoSize = true;
            this.lbl_fechaEntrega.Location = new System.Drawing.Point(288, 153);
            this.lbl_fechaEntrega.Name = "lbl_fechaEntrega";
            this.lbl_fechaEntrega.Size = new System.Drawing.Size(94, 13);
            this.lbl_fechaEntrega.TabIndex = 35;
            this.lbl_fechaEntrega.Text = "Fecha de entrega:";
            // 
            // dateFechaEntrega
            // 
            this.dateFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaEntrega.Location = new System.Drawing.Point(388, 150);
            this.dateFechaEntrega.Name = "dateFechaEntrega";
            this.dateFechaEntrega.Size = new System.Drawing.Size(99, 20);
            this.dateFechaEntrega.TabIndex = 34;
            // 
            // txt_descripcionPinata
            // 
            this.txt_descripcionPinata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcionPinata.Location = new System.Drawing.Point(10, 189);
            this.txt_descripcionPinata.Name = "txt_descripcionPinata";
            this.txt_descripcionPinata.Size = new System.Drawing.Size(504, 87);
            this.txt_descripcionPinata.TabIndex = 32;
            this.txt_descripcionPinata.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Descripción de piñata";
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_razonSocial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_razonSocial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_razonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_razonSocial.Location = new System.Drawing.Point(83, 45);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(404, 20);
            this.txt_razonSocial.TabIndex = 31;
            this.txt_razonSocial.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_AutoCompletadoLlenar);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Razon Social";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "País";
            // 
            // select_pais
            // 
            this.select_pais.FormattingEnabled = true;
            this.select_pais.Location = new System.Drawing.Point(83, 97);
            this.select_pais.Name = "select_pais";
            this.select_pais.Size = new System.Drawing.Size(89, 21);
            this.select_pais.TabIndex = 28;
            this.select_pais.Tag = "-1";
            this.select_pais.SelectedIndexChanged += new System.EventHandler(this.Select_pais_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Estado";
            // 
            // select_estado
            // 
            this.select_estado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.select_estado.FormattingEnabled = true;
            this.select_estado.Location = new System.Drawing.Point(250, 97);
            this.select_estado.Name = "select_estado";
            this.select_estado.Size = new System.Drawing.Size(89, 21);
            this.select_estado.TabIndex = 26;
            this.select_estado.Tag = "-1";
            this.select_estado.SelectedIndexChanged += new System.EventHandler(this.Select_estado_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ciudad";
            // 
            // select_ciudad
            // 
            this.select_ciudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.select_ciudad.FormattingEnabled = true;
            this.select_ciudad.Location = new System.Drawing.Point(398, 97);
            this.select_ciudad.Name = "select_ciudad";
            this.select_ciudad.Size = new System.Drawing.Size(89, 21);
            this.select_ciudad.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cel.";
            // 
            // txt_cel
            // 
            this.txt_cel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_cel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cel.Location = new System.Drawing.Point(250, 124);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(117, 20);
            this.txt_cel.TabIndex = 22;
            this.txt_cel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_AutoCompletadoLlenar);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tel.";
            // 
            // txt_email
            // 
            this.txt_email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_email.Location = new System.Drawing.Point(83, 150);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(176, 20);
            this.txt_email.TabIndex = 20;
            this.txt_email.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_AutoCompletadoLlenar);
            // 
            // txt_tel
            // 
            this.txt_tel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_tel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_tel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tel.Location = new System.Drawing.Point(83, 124);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(117, 20);
            this.txt_tel.TabIndex = 20;
            this.txt_tel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_AutoCompletadoLlenar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dirección";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_direccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion.Location = new System.Drawing.Point(83, 71);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(404, 20);
            this.txt_direccion.TabIndex = 18;
            this.txt_direccion.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_AutoCompletadoLlenar);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apellidos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_apellidos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_apellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_apellidos.Location = new System.Drawing.Point(263, 19);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(224, 20);
            this.txt_apellidos.TabIndex = 17;
            this.txt_apellidos.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_AutoCompletadoLlenar);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellidos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cantidad";
            // 
            // btn_guardarPedido
            // 
            this.btn_guardarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardarPedido.Location = new System.Drawing.Point(413, 655);
            this.btn_guardarPedido.Name = "btn_guardarPedido";
            this.btn_guardarPedido.Size = new System.Drawing.Size(122, 23);
            this.btn_guardarPedido.TabIndex = 32;
            this.btn_guardarPedido.Text = "Guardar como pedido";
            this.btn_guardarPedido.UseVisualStyleBackColor = true;
            this.btn_guardarPedido.Click += new System.EventHandler(this.Btn_guardarPedido_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.select_tipo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 55);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // select_tipo
            // 
            this.select_tipo.DisplayMember = "ctpinCodigo";
            this.select_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_tipo.FormattingEnabled = true;
            this.select_tipo.Location = new System.Drawing.Point(11, 21);
            this.select_tipo.Name = "select_tipo";
            this.select_tipo.Size = new System.Drawing.Size(328, 24);
            this.select_tipo.TabIndex = 0;
            this.select_tipo.TabStop = false;
            this.select_tipo.ValueMember = "ctpinCodigo";
            this.select_tipo.SelectedIndexChanged += new System.EventHandler(this.Select_tipo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 665);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "* El precio final depende del vendedor y puede o no coincidir con éste. ";
            // 
            // check_existeMolde
            // 
            this.check_existeMolde.AutoCheck = false;
            this.check_existeMolde.AutoSize = true;
            this.check_existeMolde.Location = new System.Drawing.Point(378, 265);
            this.check_existeMolde.Name = "check_existeMolde";
            this.check_existeMolde.Size = new System.Drawing.Size(85, 17);
            this.check_existeMolde.TabIndex = 33;
            this.check_existeMolde.Text = "Existe molde";
            this.check_existeMolde.UseVisualStyleBackColor = true;
            // 
            // num_cantidad
            // 
            this.num_cantidad.Location = new System.Drawing.Point(67, 300);
            this.num_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.ReadOnly = true;
            this.num_cantidad.Size = new System.Drawing.Size(50, 20);
            this.num_cantidad.TabIndex = 34;
            this.num_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_PrecioVenta
            // 
            this.num_PrecioVenta.DecimalPlaces = 2;
            this.num_PrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_PrecioVenta.Location = new System.Drawing.Point(178, 317);
            this.num_PrecioVenta.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_PrecioVenta.Name = "num_PrecioVenta";
            this.num_PrecioVenta.Size = new System.Drawing.Size(96, 35);
            this.num_PrecioVenta.TabIndex = 35;
            // 
            // check_LlevaEstructuraAlambre
            // 
            this.check_LlevaEstructuraAlambre.AutoSize = true;
            this.check_LlevaEstructuraAlambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_LlevaEstructuraAlambre.Location = new System.Drawing.Point(12, 28);
            this.check_LlevaEstructuraAlambre.Name = "check_LlevaEstructuraAlambre";
            this.check_LlevaEstructuraAlambre.Size = new System.Drawing.Size(157, 17);
            this.check_LlevaEstructuraAlambre.TabIndex = 36;
            this.check_LlevaEstructuraAlambre.Text = "Lleva estructura de alambre";
            this.check_LlevaEstructuraAlambre.UseVisualStyleBackColor = true;
            this.check_LlevaEstructuraAlambre.CheckedChanged += new System.EventHandler(this.Check_LlevaEstructuraAlambre_CheckedChanged);
            // 
            // frmPinataCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 682);
            this.Controls.Add(this.num_PrecioVenta);
            this.Controls.Add(this.num_cantidad);
            this.Controls.Add(this.check_existeMolde);
            this.Controls.Add(this.btn_guardarPedido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_estimarCosto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpoTamaño);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPinataCotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            this.gpoTamaño.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_metrosAprox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PrecioVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpoTamaño;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_detallada;
        private System.Windows.Forms.RadioButton radioBtn_sencilla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_estimarCosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox select_pais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox select_estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox select_ciudad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_razonSocial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txt_descripcionPinata;
        private System.Windows.Forms.Button btn_guardarPedido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check_existeMolde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_metrosAprox;
        private System.Windows.Forms.ComboBox select_tamano;
        private System.Windows.Forms.ComboBox select_tipo;
        private System.Windows.Forms.NumericUpDown num_cantidad;
        private System.Windows.Forms.NumericUpDown num_PrecioVenta;
        private System.Windows.Forms.Label lbl_fechaEntrega;
        private System.Windows.Forms.DateTimePicker dateFechaEntrega;
        private System.Windows.Forms.CheckBox check_LlevaEstructuraAlambre;
    }
}