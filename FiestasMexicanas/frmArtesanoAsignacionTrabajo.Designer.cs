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
            this.btn_QuitarUltimoPedido = new System.Windows.Forms.Button();
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.grdArtesanos = new System.Windows.Forms.DataGridView();
            this.grdPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdArtesanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1444, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Asignacion de carga de trabajo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_QuitarUltimoPedido
            // 
            this.btn_QuitarUltimoPedido.Location = new System.Drawing.Point(566, 306);
            this.btn_QuitarUltimoPedido.Name = "btn_QuitarUltimoPedido";
            this.btn_QuitarUltimoPedido.Size = new System.Drawing.Size(24, 23);
            this.btn_QuitarUltimoPedido.TabIndex = 4;
            this.btn_QuitarUltimoPedido.Text = "->";
            this.btn_QuitarUltimoPedido.UseVisualStyleBackColor = true;
            this.btn_QuitarUltimoPedido.Click += new System.EventHandler(this.Btn_QuitarUltimoPedido_Click);
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.Location = new System.Drawing.Point(566, 277);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(24, 23);
            this.btn_AgregarPedido.TabIndex = 5;
            this.btn_AgregarPedido.Text = "<-";
            this.btn_AgregarPedido.UseVisualStyleBackColor = true;
            this.btn_AgregarPedido.Click += new System.EventHandler(this.Btn_AgregarPedido_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artesanos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(838, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pedidos en espera";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(541, 494);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(71, 35);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // grdArtesanos
            // 
            this.grdArtesanos.AllowUserToAddRows = false;
            this.grdArtesanos.AllowUserToDeleteRows = false;
            this.grdArtesanos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArtesanos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdArtesanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArtesanos.Location = new System.Drawing.Point(12, 126);
            this.grdArtesanos.Name = "grdArtesanos";
            this.grdArtesanos.ReadOnly = true;
            this.grdArtesanos.Size = new System.Drawing.Size(523, 411);
            this.grdArtesanos.TabIndex = 10;
            // 
            // grdPedidos
            // 
            this.grdPedidos.AllowUserToAddRows = false;
            this.grdPedidos.AllowUserToDeleteRows = false;
            this.grdPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidos.Location = new System.Drawing.Point(618, 126);
            this.grdPedidos.Name = "grdPedidos";
            this.grdPedidos.ReadOnly = true;
            this.grdPedidos.Size = new System.Drawing.Size(838, 411);
            this.grdPedidos.TabIndex = 11;
            // 
            // frmArtesanoAsignacionTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 549);
            this.Controls.Add(this.grdPedidos);
            this.Controls.Add(this.grdArtesanos);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AgregarPedido);
            this.Controls.Add(this.btn_QuitarUltimoPedido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmArtesanoAsignacionTrabajo";
            this.Text = "Asignacion de carga de trabajo";
            this.Load += new System.EventHandler(this.FrmArtesanoAsignacionTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArtesanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_QuitarUltimoPedido;
        private System.Windows.Forms.Button btn_AgregarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView grdArtesanos;
        private System.Windows.Forms.DataGridView grdPedidos;
    }
}