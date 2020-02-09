using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;


namespace frm_PantallaInicio
{
    public partial class frm_IniciodeSesion : Form
    { 
        public void limpiar()
        {
            txt_usuario.Clear();
            txt_contraseña.Clear();
            txt_usuario.Focus();
        }

        public void Personalizacion()
        {
            this.BackColor = Color.FromArgb(140, 158, 255);
            panel_ingreso.BackColor = Color.FromArgb(83, 109, 254);
            btn_iniciosesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            btn_salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
        }
        
        public frm_IniciodeSesion()
        {
            InitializeComponent();
            Personalizacion();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void btn_iniciosesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usuario.Text != "")
                {

                }
                else
                {
                    MessageBox.Show("Inserte su nombre de usuario");
                }
                if (txt_contraseña.Text != "")
                {
                    D_Usuarios user = new D_Usuarios();
                    var validLogin = user.LoginUser(txt_usuario.Text, txt_contraseña.Text);
                    if (validLogin == true)
                    {
                        frm_menu menu = new frm_menu();
                        menu.Show();
                        menu.FormClosed += LogOut;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de Usuario o Contraseña incorrecto\nIntentelo otra vez");
                        limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Inserte su contraseña");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void LogOut(object sender,FormClosedEventArgs e)
        {
            limpiar();
            this.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_ver.Checked == true)
            {
                if (txt_contraseña.PasswordChar == '*')
                {
                    txt_contraseña.PasswordChar = '\0';
                }
            }
            else
            {
                txt_contraseña.PasswordChar = '*';
            }
        }
    }
}
