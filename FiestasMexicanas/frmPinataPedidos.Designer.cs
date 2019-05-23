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
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(712, 44);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Catálogo de cotizaciones y pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_guardarCotizacionPedido
            // 
            this.btn_guardarCotizacionPedido.Location = new System.Drawing.Point(645, 56);
            this.btn_guardarCotizacionPedido.Name = "btn_guardarCotizacionPedido";
            this.btn_guardarCotizacionPedido.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarCotizacionPedido.TabIndex = 4;
            this.btn_guardarCotizacionPedido.Text = "Guardar";
            this.btn_guardarCotizacionPedido.UseVisualStyleBackColor = true;
            // 
            // frmPinataPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 425);
            this.Controls.Add(this.btn_guardarCotizacionPedido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmPinataPedidos";
            this.Text = "Catálogo de cotizaciones y pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_guardarCotizacionPedido;
    }
}