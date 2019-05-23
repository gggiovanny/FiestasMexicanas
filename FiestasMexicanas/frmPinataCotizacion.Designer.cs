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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.radioBtn_grande = new System.Windows.Forms.RadioButton();
            this.gpoTamaño = new System.Windows.Forms.GroupBox();
            this.radioBtn_mediana = new System.Windows.Forms.RadioButton();
            this.radioBtn_chica = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_detallada = new System.Windows.Forms.RadioButton();
            this.radioBtn_sencilla = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.select_metrosAprox = new System.Windows.Forms.NumericUpDown();
            this.radioBtn_estructuraAlambre = new System.Windows.Forms.RadioButton();
            this.btn_estimarCosto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_precioVenta = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.select_cantidad = new System.Windows.Forms.ComboBox();
            this.btn_guardarPedido = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.select_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_existeMolde = new System.Windows.Forms.CheckBox();
            this.gpoTamaño.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_metrosAprox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(523, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cotización";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // radioBtn_grande
            // 
            this.radioBtn_grande.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioBtn_grande.AutoSize = true;
            this.radioBtn_grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_grande.Location = new System.Drawing.Point(6, 21);
            this.radioBtn_grande.Name = "radioBtn_grande";
            this.radioBtn_grande.Size = new System.Drawing.Size(66, 19);
            this.radioBtn_grande.TabIndex = 2;
            this.radioBtn_grande.TabStop = true;
            this.radioBtn_grande.Text = "Grande";
            this.radioBtn_grande.UseVisualStyleBackColor = true;
            // 
            // gpoTamaño
            // 
            this.gpoTamaño.Controls.Add(this.radioBtn_mediana);
            this.gpoTamaño.Controls.Add(this.radioBtn_chica);
            this.gpoTamaño.Controls.Add(this.radioBtn_grande);
            this.gpoTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoTamaño.Location = new System.Drawing.Point(15, 115);
            this.gpoTamaño.Name = "gpoTamaño";
            this.gpoTamaño.Size = new System.Drawing.Size(345, 55);
            this.gpoTamaño.TabIndex = 3;
            this.gpoTamaño.TabStop = false;
            this.gpoTamaño.Text = "Tamaño";
            // 
            // radioBtn_mediana
            // 
            this.radioBtn_mediana.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioBtn_mediana.AutoSize = true;
            this.radioBtn_mediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_mediana.Location = new System.Drawing.Point(241, 21);
            this.radioBtn_mediana.Name = "radioBtn_mediana";
            this.radioBtn_mediana.Size = new System.Drawing.Size(74, 19);
            this.radioBtn_mediana.TabIndex = 4;
            this.radioBtn_mediana.TabStop = true;
            this.radioBtn_mediana.Text = "Mediana";
            this.radioBtn_mediana.UseVisualStyleBackColor = true;
            // 
            // radioBtn_chica
            // 
            this.radioBtn_chica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioBtn_chica.AutoSize = true;
            this.radioBtn_chica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_chica.Location = new System.Drawing.Point(120, 21);
            this.radioBtn_chica.Name = "radioBtn_chica";
            this.radioBtn_chica.Size = new System.Drawing.Size(56, 19);
            this.radioBtn_chica.TabIndex = 3;
            this.radioBtn_chica.TabStop = true;
            this.radioBtn_chica.Text = "Chica";
            this.radioBtn_chica.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_detallada);
            this.groupBox1.Controls.Add(this.radioBtn_sencilla);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.radioBtn_detallada.Location = new System.Drawing.Point(120, 25);
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
            this.radioBtn_sencilla.Location = new System.Drawing.Point(6, 21);
            this.radioBtn_sencilla.Name = "radioBtn_sencilla";
            this.radioBtn_sencilla.Size = new System.Drawing.Size(69, 19);
            this.radioBtn_sencilla.TabIndex = 2;
            this.radioBtn_sencilla.TabStop = true;
            this.radioBtn_sencilla.Text = "Sencilla";
            this.radioBtn_sencilla.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.select_metrosAprox);
            this.groupBox2.Controls.Add(this.radioBtn_estructuraAlambre);
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Metros aprox.";
            // 
            // select_metrosAprox
            // 
            this.select_metrosAprox.Enabled = false;
            this.select_metrosAprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_metrosAprox.Location = new System.Drawing.Point(272, 25);
            this.select_metrosAprox.Name = "select_metrosAprox";
            this.select_metrosAprox.Size = new System.Drawing.Size(67, 22);
            this.select_metrosAprox.TabIndex = 4;
            // 
            // radioBtn_estructuraAlambre
            // 
            this.radioBtn_estructuraAlambre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioBtn_estructuraAlambre.AutoSize = true;
            this.radioBtn_estructuraAlambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_estructuraAlambre.Location = new System.Drawing.Point(10, 25);
            this.radioBtn_estructuraAlambre.Name = "radioBtn_estructuraAlambre";
            this.radioBtn_estructuraAlambre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtn_estructuraAlambre.Size = new System.Drawing.Size(177, 19);
            this.radioBtn_estructuraAlambre.TabIndex = 3;
            this.radioBtn_estructuraAlambre.TabStop = true;
            this.radioBtn_estructuraAlambre.Text = "Lleva estructura de alambre";
            this.radioBtn_estructuraAlambre.UseVisualStyleBackColor = true;
            // 
            // btn_estimarCosto
            // 
            this.btn_estimarCosto.Location = new System.Drawing.Point(15, 326);
            this.btn_estimarCosto.Name = "btn_estimarCosto";
            this.btn_estimarCosto.Size = new System.Drawing.Size(120, 23);
            this.btn_estimarCosto.TabIndex = 8;
            this.btn_estimarCosto.Text = "Estimar costo";
            this.btn_estimarCosto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Precio de venta";
            // 
            // lbl_precioVenta
            // 
            this.lbl_precioVenta.AutoSize = true;
            this.lbl_precioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioVenta.Location = new System.Drawing.Point(191, 320);
            this.lbl_precioVenta.Name = "lbl_precioVenta";
            this.lbl_precioVenta.Size = new System.Drawing.Size(180, 29);
            this.lbl_precioVenta.TabIndex = 11;
            this.lbl_precioVenta.Text = "$ 0.00 M.X.N*.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(18, 415);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Marcar para pedido";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(83, 19);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(117, 20);
            this.txt_nombres.TabIndex = 13;
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
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.groupBox4.Location = new System.Drawing.Point(12, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 233);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del cliente";
            // 
            // txt_descripcionPinata
            // 
            this.txt_descripcionPinata.Location = new System.Drawing.Point(10, 189);
            this.txt_descripcionPinata.Name = "txt_descripcionPinata";
            this.txt_descripcionPinata.Size = new System.Drawing.Size(504, 36);
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
            this.txt_razonSocial.Location = new System.Drawing.Point(83, 45);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(404, 20);
            this.txt_razonSocial.TabIndex = 31;
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
            this.label12.Location = new System.Drawing.Point(363, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "País";
            // 
            // select_pais
            // 
            this.select_pais.FormattingEnabled = true;
            this.select_pais.Location = new System.Drawing.Point(398, 97);
            this.select_pais.Name = "select_pais";
            this.select_pais.Size = new System.Drawing.Size(89, 21);
            this.select_pais.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Estado";
            // 
            // select_estado
            // 
            this.select_estado.FormattingEnabled = true;
            this.select_estado.Location = new System.Drawing.Point(250, 97);
            this.select_estado.Name = "select_estado";
            this.select_estado.Size = new System.Drawing.Size(89, 21);
            this.select_estado.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ciudad";
            // 
            // select_ciudad
            // 
            this.select_ciudad.FormattingEnabled = true;
            this.select_ciudad.Location = new System.Drawing.Point(83, 97);
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
            this.txt_cel.Location = new System.Drawing.Point(250, 124);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(117, 20);
            this.txt_cel.TabIndex = 22;
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
            this.txt_email.Location = new System.Drawing.Point(83, 150);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(176, 20);
            this.txt_email.TabIndex = 20;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(83, 124);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(117, 20);
            this.txt_tel.TabIndex = 20;
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
            this.txt_direccion.Location = new System.Drawing.Point(83, 71);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(404, 20);
            this.txt_direccion.TabIndex = 18;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(263, 19);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(224, 20);
            this.txt_apellidos.TabIndex = 17;
            // 
            // label4
            // 
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
            // select_cantidad
            // 
            this.select_cantidad.FormattingEnabled = true;
            this.select_cantidad.Location = new System.Drawing.Point(71, 298);
            this.select_cantidad.Name = "select_cantidad";
            this.select_cantidad.Size = new System.Drawing.Size(64, 21);
            this.select_cantidad.TabIndex = 30;
            // 
            // btn_guardarPedido
            // 
            this.btn_guardarPedido.Location = new System.Drawing.Point(413, 604);
            this.btn_guardarPedido.Name = "btn_guardarPedido";
            this.btn_guardarPedido.Size = new System.Drawing.Size(122, 23);
            this.btn_guardarPedido.TabIndex = 32;
            this.btn_guardarPedido.Text = "Guardar como pedido";
            this.btn_guardarPedido.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.select_tipo.FormattingEnabled = true;
            this.select_tipo.Location = new System.Drawing.Point(10, 22);
            this.select_tipo.Name = "select_tipo";
            this.select_tipo.Size = new System.Drawing.Size(328, 24);
            this.select_tipo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "* El precio final depende del vendedor y puede o no coincidir con éste. ";
            // 
            // checkBox_existeMolde
            // 
            this.checkBox_existeMolde.AutoCheck = false;
            this.checkBox_existeMolde.AutoSize = true;
            this.checkBox_existeMolde.Location = new System.Drawing.Point(378, 265);
            this.checkBox_existeMolde.Name = "checkBox_existeMolde";
            this.checkBox_existeMolde.Size = new System.Drawing.Size(85, 17);
            this.checkBox_existeMolde.TabIndex = 33;
            this.checkBox_existeMolde.Text = "Existe molde";
            this.checkBox_existeMolde.UseVisualStyleBackColor = true;
            // 
            // frmPinataCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 631);
            this.Controls.Add(this.checkBox_existeMolde);
            this.Controls.Add(this.btn_guardarPedido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.select_cantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_precioVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_estimarCosto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpoTamaño);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPinataCotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            this.gpoTamaño.ResumeLayout(false);
            this.gpoTamaño.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_metrosAprox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton radioBtn_grande;
        private System.Windows.Forms.GroupBox gpoTamaño;
        private System.Windows.Forms.RadioButton radioBtn_mediana;
        private System.Windows.Forms.RadioButton radioBtn_chica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_detallada;
        private System.Windows.Forms.RadioButton radioBtn_sencilla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtn_estructuraAlambre;
        private System.Windows.Forms.Button btn_estimarCosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_precioVenta;
        private System.Windows.Forms.CheckBox checkBox1;
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
        private System.Windows.Forms.ComboBox select_cantidad;
        private System.Windows.Forms.TextBox txt_razonSocial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txt_descripcionPinata;
        private System.Windows.Forms.Button btn_guardarPedido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox select_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_existeMolde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown select_metrosAprox;
    }
}