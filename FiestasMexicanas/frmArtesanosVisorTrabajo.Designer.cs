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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.radioBtn_espera = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_terminada = new System.Windows.Forms.RadioButton();
            this.radioBtn_forrando = new System.Windows.Forms.RadioButton();
            this.radioBtn_armando = new System.Windows.Forms.RadioButton();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(781, 44);
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
            // frmArtesanosVisorTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 504);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmArtesanosVisorTrabajo";
            this.Text = "Visor de carga de trabajo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}