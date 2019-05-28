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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btn_guardarCotizacionPedido = new System.Windows.Forms.Button();
            this.grdCotizacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1022, 44);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Catálogo de cotizaciones y pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_guardarCotizacionPedido
            // 
            this.btn_guardarCotizacionPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardarCotizacionPedido.Location = new System.Drawing.Point(959, 56);
            this.btn_guardarCotizacionPedido.Name = "btn_guardarCotizacionPedido";
            this.btn_guardarCotizacionPedido.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarCotizacionPedido.TabIndex = 4;
            this.btn_guardarCotizacionPedido.Text = "Guardar";
            this.btn_guardarCotizacionPedido.UseVisualStyleBackColor = true;
            this.btn_guardarCotizacionPedido.Click += new System.EventHandler(this.Btn_guardarCotizacionPedido_Click);
            // 
            // grdCotizacion
            // 
            this.grdCotizacion.AllowUserToAddRows = false;
            this.grdCotizacion.AllowUserToDeleteRows = false;
            this.grdCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCotizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCotizacion.Location = new System.Drawing.Point(12, 85);
            this.grdCotizacion.Name = "grdCotizacion";
            this.grdCotizacion.Size = new System.Drawing.Size(1022, 328);
            this.grdCotizacion.TabIndex = 5;
            this.grdCotizacion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCotizacion_CellValueChanged);
            // 
            // frmPinataPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 425);
            this.Controls.Add(this.grdCotizacion);
            this.Controls.Add(this.btn_guardarCotizacionPedido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPinataPedidos";
            this.Text = "Catálogo de cotizaciones y pedidos";
            this.Load += new System.EventHandler(this.FrmPinataPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCotizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_guardarCotizacionPedido;
        private System.Windows.Forms.DataGridView grdCotizacion;
    }
}