namespace frm_PantallaInicio
{
    partial class frm_IniciodeSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IniciodeSesion));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_iniciosesion = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel_ingreso = new System.Windows.Forms.Panel();
            this.check_ver = new System.Windows.Forms.CheckBox();
            this.picbx_pass = new System.Windows.Forms.PictureBox();
            this.picbx_user = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ingreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Location = new System.Drawing.Point(152, 64);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(196, 20);
            this.lbl_titulo.TabIndex = 13;
            this.lbl_titulo.Text = "CONTROL DE EXPEDIENTES";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario.Location = new System.Drawing.Point(118, 48);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(62, 20);
            this.lbl_usuario.TabIndex = 14;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_contraseña.Location = new System.Drawing.Point(118, 117);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(86, 20);
            this.lbl_contraseña.TabIndex = 15;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_usuario.Location = new System.Drawing.Point(121, 71);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(240, 27);
            this.txt_usuario.TabIndex = 16;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_contraseña.Location = new System.Drawing.Point(121, 140);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(240, 27);
            this.txt_contraseña.TabIndex = 17;
            // 
            // btn_iniciosesion
            // 
            this.btn_iniciosesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_iniciosesion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_iniciosesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciosesion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_iniciosesion.Location = new System.Drawing.Point(156, 233);
            this.btn_iniciosesion.Name = "btn_iniciosesion";
            this.btn_iniciosesion.Size = new System.Drawing.Size(147, 33);
            this.btn_iniciosesion.TabIndex = 18;
            this.btn_iniciosesion.Text = "Inicio de Sesión";
            this.btn_iniciosesion.UseVisualStyleBackColor = true;
            this.btn_iniciosesion.Click += new System.EventHandler(this.btn_iniciosesion_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_salir.Location = new System.Drawing.Point(156, 288);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(147, 33);
            this.btn_salir.TabIndex = 21;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel_ingreso
            // 
            this.panel_ingreso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_ingreso.Controls.Add(this.check_ver);
            this.panel_ingreso.Controls.Add(this.picbx_pass);
            this.panel_ingreso.Controls.Add(this.picbx_user);
            this.panel_ingreso.Controls.Add(this.btn_salir);
            this.panel_ingreso.Controls.Add(this.btn_iniciosesion);
            this.panel_ingreso.Controls.Add(this.txt_contraseña);
            this.panel_ingreso.Controls.Add(this.txt_usuario);
            this.panel_ingreso.Controls.Add(this.lbl_contraseña);
            this.panel_ingreso.Controls.Add(this.lbl_usuario);
            this.panel_ingreso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ingreso.Location = new System.Drawing.Point(0, 174);
            this.panel_ingreso.Name = "panel_ingreso";
            this.panel_ingreso.Size = new System.Drawing.Size(484, 387);
            this.panel_ingreso.TabIndex = 22;
            // 
            // check_ver
            // 
            this.check_ver.AutoSize = true;
            this.check_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_ver.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.check_ver.Location = new System.Drawing.Point(139, 188);
            this.check_ver.Name = "check_ver";
            this.check_ver.Size = new System.Drawing.Size(185, 24);
            this.check_ver.TabIndex = 24;
            this.check_ver.Text = "Ver/Ocultar Contraseña";
            this.check_ver.UseVisualStyleBackColor = true;
            this.check_ver.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picbx_pass
            // 
            this.picbx_pass.Image = ((System.Drawing.Image)(resources.GetObject("picbx_pass.Image")));
            this.picbx_pass.Location = new System.Drawing.Point(72, 127);
            this.picbx_pass.Name = "picbx_pass";
            this.picbx_pass.Size = new System.Drawing.Size(40, 40);
            this.picbx_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_pass.TabIndex = 23;
            this.picbx_pass.TabStop = false;
            // 
            // picbx_user
            // 
            this.picbx_user.Image = ((System.Drawing.Image)(resources.GetObject("picbx_user.Image")));
            this.picbx_user.Location = new System.Drawing.Point(72, 58);
            this.picbx_user.Name = "picbx_user";
            this.picbx_user.Size = new System.Drawing.Size(40, 40);
            this.picbx_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_user.TabIndex = 22;
            this.picbx_user.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frm_IniciodeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_ingreso);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_IniciodeSesion";
            this.Text = "Inicio de Sesion";
            this.panel_ingreso.ResumeLayout(false);
            this.panel_ingreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_iniciosesion;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel_ingreso;
        private System.Windows.Forms.PictureBox picbx_user;
        private System.Windows.Forms.PictureBox picbx_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox check_ver;
    }
}