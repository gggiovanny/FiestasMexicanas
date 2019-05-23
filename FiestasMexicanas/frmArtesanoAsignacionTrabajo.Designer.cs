namespace FiestasMexicanas
{
    partial class frmArtesanoAsignacionTrabajo
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
            this.btn_artesanoPedido = new System.Windows.Forms.Button();
            this.btn_pedidoArtesano = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(999, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Asignacion de carga de trabajo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_artesanoPedido
            // 
            this.btn_artesanoPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_artesanoPedido.Location = new System.Drawing.Point(472, 265);
            this.btn_artesanoPedido.Name = "btn_artesanoPedido";
            this.btn_artesanoPedido.Size = new System.Drawing.Size(24, 23);
            this.btn_artesanoPedido.TabIndex = 4;
            this.btn_artesanoPedido.Text = "->";
            this.btn_artesanoPedido.UseVisualStyleBackColor = true;
            // 
            // btn_pedidoArtesano
            // 
            this.btn_pedidoArtesano.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_pedidoArtesano.Location = new System.Drawing.Point(472, 236);
            this.btn_pedidoArtesano.Name = "btn_pedidoArtesano";
            this.btn_pedidoArtesano.Size = new System.Drawing.Size(24, 23);
            this.btn_pedidoArtesano.TabIndex = 5;
            this.btn_pedidoArtesano.Text = "<-";
            this.btn_pedidoArtesano.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artesanos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pedidos en espera";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmArtesanoAsignacionTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pedidoArtesano);
            this.Controls.Add(this.btn_artesanoPedido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmArtesanoAsignacionTrabajo";
            this.Text = "Asignacion de carga de trabajo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_artesanoPedido;
        private System.Windows.Forms.Button btn_pedidoArtesano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}