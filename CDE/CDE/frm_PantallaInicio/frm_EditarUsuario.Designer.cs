namespace frm_PantallaInicio
{
    partial class frm_EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditarUsuario));
            this.picbx_user = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.grpbx_usuario = new System.Windows.Forms.GroupBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.cmb_codEst = new System.Windows.Forms.ComboBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.lbl_codest = new System.Windows.Forms.Label();
            this.lbl_contra = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_user)).BeginInit();
            this.grpbx_usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbx_user
            // 
            this.picbx_user.Image = ((System.Drawing.Image)(resources.GetObject("picbx_user.Image")));
            this.picbx_user.Location = new System.Drawing.Point(425, 48);
            this.picbx_user.Name = "picbx_user";
            this.picbx_user.Size = new System.Drawing.Size(110, 110);
            this.picbx_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_user.TabIndex = 25;
            this.picbx_user.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Location = new System.Drawing.Point(576, 85);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(217, 30);
            this.lbl_titulo.TabIndex = 24;
            this.lbl_titulo.Text = "EDITAR MI USUARIO";
            // 
            // grpbx_usuario
            // 
            this.grpbx_usuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpbx_usuario.Controls.Add(this.lbl_usuario);
            this.grpbx_usuario.Controls.Add(this.cmb_codEst);
            this.grpbx_usuario.Controls.Add(this.lbl_nombre);
            this.grpbx_usuario.Controls.Add(this.lbl_apellido);
            this.grpbx_usuario.Controls.Add(this.txt_contra);
            this.grpbx_usuario.Controls.Add(this.lbl_codest);
            this.grpbx_usuario.Controls.Add(this.lbl_contra);
            this.grpbx_usuario.Controls.Add(this.txt_lname);
            this.grpbx_usuario.Controls.Add(this.txt_user);
            this.grpbx_usuario.Controls.Add(this.txt_name);
            this.grpbx_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpbx_usuario.ForeColor = System.Drawing.Color.White;
            this.grpbx_usuario.Location = new System.Drawing.Point(325, 192);
            this.grpbx_usuario.Name = "grpbx_usuario";
            this.grpbx_usuario.Size = new System.Drawing.Size(589, 310);
            this.grpbx_usuario.TabIndex = 28;
            this.grpbx_usuario.TabStop = false;
            this.grpbx_usuario.Text = "USUARIO";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario.Location = new System.Drawing.Point(112, 62);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(62, 20);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario";
            // 
            // cmb_codEst
            // 
            this.cmb_codEst.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmb_codEst.FormattingEnabled = true;
            this.cmb_codEst.Location = new System.Drawing.Point(299, 241);
            this.cmb_codEst.Name = "cmb_codEst";
            this.cmb_codEst.Size = new System.Drawing.Size(187, 28);
            this.cmb_codEst.TabIndex = 24;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_nombre.Location = new System.Drawing.Point(112, 148);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(66, 20);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_apellido.Location = new System.Drawing.Point(109, 199);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(66, 20);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_contra.Location = new System.Drawing.Point(299, 98);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(187, 27);
            this.txt_contra.TabIndex = 16;
            // 
            // lbl_codest
            // 
            this.lbl_codest.AutoSize = true;
            this.lbl_codest.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_codest.Location = new System.Drawing.Point(112, 250);
            this.lbl_codest.Name = "lbl_codest";
            this.lbl_codest.Size = new System.Drawing.Size(169, 20);
            this.lbl_codest.TabIndex = 5;
            this.lbl_codest.Text = "Codigo Establecimiento";
            // 
            // lbl_contra
            // 
            this.lbl_contra.AutoSize = true;
            this.lbl_contra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_contra.Location = new System.Drawing.Point(112, 98);
            this.lbl_contra.Name = "lbl_contra";
            this.lbl_contra.Size = new System.Drawing.Size(86, 20);
            this.lbl_contra.TabIndex = 15;
            this.lbl_contra.Text = "Contraseña";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_lname.Location = new System.Drawing.Point(299, 191);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(187, 27);
            this.txt_lname.TabIndex = 9;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_user.Location = new System.Drawing.Point(299, 54);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(187, 27);
            this.txt_user.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_name.Location = new System.Drawing.Point(299, 148);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(187, 27);
            this.txt_name.TabIndex = 8;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_agregar.Location = new System.Drawing.Point(581, 527);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(124, 40);
            this.btn_agregar.TabIndex = 29;
            this.btn_agregar.Text = "EDITAR";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // frm_EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1120, 749);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.grpbx_usuario);
            this.Controls.Add(this.picbx_user);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_EditarUsuario";
            this.Text = "frm_EditarUsuario";
            this.Load += new System.EventHandler(this.frm_EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_user)).EndInit();
            this.grpbx_usuario.ResumeLayout(false);
            this.grpbx_usuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_user;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.GroupBox grpbx_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.ComboBox cmb_codEst;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Label lbl_codest;
        private System.Windows.Forms.Label lbl_contra;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_agregar;
    }
}