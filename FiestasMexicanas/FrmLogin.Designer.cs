namespace FiestasMexicanas
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioAlias = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.lblMarbolERP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.AcceptsReturn = true;
            this.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(121, 98);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(391, 26);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_contraseña_PreviewKeyDown);
            // 
            // lblUsuarioAlias
            // 
            this.lblUsuarioAlias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuarioAlias.AutoSize = true;
            this.lblUsuarioAlias.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAlias.Location = new System.Drawing.Point(41, 99);
            this.lblUsuarioAlias.Name = "lblUsuarioAlias";
            this.lblUsuarioAlias.Size = new System.Drawing.Size(74, 23);
            this.lblUsuarioAlias.TabIndex = 4;
            this.lblUsuarioAlias.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(9, 129);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(106, 23);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AcceptsReturn = true;
            this.txt_contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(121, 129);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(391, 26);
            this.txt_contraseña.TabIndex = 1;
            this.txt_contraseña.UseSystemPasswordChar = true;
            this.txt_contraseña.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txt_contraseña_PreviewKeyDown);
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_iniciarSesion.BackColor = System.Drawing.Color.SlateGray;
            this.btn_iniciarSesion.FlatAppearance.BorderSize = 0;
            this.btn_iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarSesion.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_iniciarSesion.Location = new System.Drawing.Point(343, 172);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(169, 41);
            this.btn_iniciarSesion.TabIndex = 2;
            this.btn_iniciarSesion.Text = "Iniciar sesión";
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.Btn_iniciarSesion_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(484, -2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(45, 31);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 19;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // lblMarbolERP
            // 
            this.lblMarbolERP.AutoSize = true;
            this.lblMarbolERP.BackColor = System.Drawing.Color.Transparent;
            this.lblMarbolERP.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarbolERP.Location = new System.Drawing.Point(115, 62);
            this.lblMarbolERP.Name = "lblMarbolERP";
            this.lblMarbolERP.Size = new System.Drawing.Size(355, 33);
            this.lblMarbolERP.TabIndex = 20;
            this.lblMarbolERP.Text = "LOGIN FIESTAS MEXICANAS";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(528, 258);
            this.ControlBox = false;
            this.Controls.Add(this.lblMarbolERP);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.lblUsuarioAlias);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso General";
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lblUsuarioAlias;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Label lblMarbolERP;
    }
}