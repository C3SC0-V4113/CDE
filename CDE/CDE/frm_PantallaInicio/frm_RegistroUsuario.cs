using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace frm_PantallaInicio
{
    public partial class frm_RegistroUsuario : Form
    {
        D_Usuarios objetosuss = new D_Usuarios();

        public void Personalizacion()
        {
            this.BackColor = Color.FromArgb(140, 158, 255);
            grpbx_usuario.BackColor = Color.FromArgb(26, 35, 126);
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 109, 254);
        }

        public frm_RegistroUsuario()
        {
            InitializeComponent();
            Personalizacion();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_name.Focus();
        }

        private void MostrarEstablecimientos()
        {
            try
            {
                D_Instituciones esto = new D_Instituciones();
                cmb_codEst.DataSource = esto.ListarIns();
                cmb_codEst.DisplayMember = "Nombre";
                cmb_codEst.ValueMember = "CodIntitución";
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo cargar la base de datos, reinicie porfavor");
            }
        }

        private void frm_RegistroUsuario_Load(object sender, EventArgs e)
        {
            MostrarEstablecimientos();

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool ValidarCodigo(string id)
        {
            string exp = "[U]{1}[S]{1}[0-9]{4}";
            MatchCollection encontrado = Regex.Matches(id, exp);
            if (Regex.IsMatch(id, exp))
            {
                //verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(id, exp, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txt_cod_Leave(object sender, EventArgs e)
        {

        }

        private void txt_contra_Leave(object sender, EventArgs e)
        {
            int count = 0;
            foreach(char letra in txt_contra.Text)
            {
                count++;
            }
            if(count<=10)
            {

            }
            else
            {
                MessageBox.Show("No se permiten contraseñas de más de 10 caracteres");
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números             
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace             
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio             
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar            
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   
        }

        private void txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números             
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace             
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio             
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar            
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Limpiar()
        {
            txt_contra.Text = null;
            txt_contraconfig.Clear();
            txt_lname.Text = null;
            txt_name.Text = null;
            txt_user.Text = null;
            cmb_codEst.SelectedIndex = -1;
            txt_user.Focus();
        }

        private bool validarCampos()
        {
            //variable que verifica si algo ha sido validado
            bool validado = true;
            if (txt_name.Text == "") //vefica que no quede vacío el campo
            {
                validado = false; //si está vacío validado es falso
            }
            //verifico la casilla de apellido
            if (txt_lname.Text == "")
            {
                validado = false;
            }
            return validado;
        }

        private void btn_selec_Click(object sender, EventArgs e)
        {
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_contra.Text == txt_contraconfig.Text)
            {
                try
                {
                    objetosuss.InsertUsers(txt_user.Text, txt_contra.Text, txt_name.Text, txt_lname.Text, cmb_codEst.SelectedValue.ToString());
                    MessageBox.Show("Usuario agregado");
                    Limpiar();
                }
                catch (Exception EX)
                {
                    MessageBox.Show("No se pudieron guardar los datos.\n" + EX.Message);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no concuerdan");
            }
        }

        private void picbx_user_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
