namespace FiestasMexicanas
{
    partial class frmPinataPreciosCotizaciones
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
            this.btn_guardarPrecios = new System.Windows.Forms.Button();
            this.grdPrecios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(851, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Administración de precios";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_guardarPrecios
            // 
            this.btn_guardarPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardarPrecios.Location = new System.Drawing.Point(788, 82);
            this.btn_guardarPrecios.Name = "btn_guardarPrecios";
            this.btn_guardarPrecios.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarPrecios.TabIndex = 5;
            this.btn_guardarPrecios.Text = "Guardar";
            this.btn_guardarPrecios.UseVisualStyleBackColor = true;
            this.btn_guardarPrecios.Click += new System.EventHandler(this.Btn_guardarPrecios_Click);
            // 
            // grdPrecios
            // 
            this.grdPrecios.AllowUserToAddRows = false;
            this.grdPrecios.AllowUserToDeleteRows = false;
            this.grdPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrecios.Location = new System.Drawing.Point(12, 111);
            this.grdPrecios.Name = "grdPrecios";
            this.grdPrecios.Size = new System.Drawing.Size(851, 375);
            this.grdPrecios.TabIndex = 35;
            this.grdPrecios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPrecios_CellValueChanged);
            // 
            // frmPinataPreciosCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 498);
            this.Controls.Add(this.grdPrecios);
            this.Controls.Add(this.btn_guardarPrecios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPinataPreciosCotizaciones";
            this.Text = "Administración de precios";
            this.Load += new System.EventHandler(this.FrmPinataPreciosCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_guardarPrecios;
        private System.Windows.Forms.DataGridView grdPrecios;
    }
}