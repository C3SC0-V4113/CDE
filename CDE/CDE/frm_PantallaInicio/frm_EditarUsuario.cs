using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.cacheUsuario;
using Dominio;

namespace frm_PantallaInicio
{
    public partial class frm_EditarUsuario : Form
    {
        D_Usuarios objetoUs = new D_Usuarios();
        private string CodUsuario = null;

        public frm_EditarUsuario()
        {
            InitializeComponent();
            Personalizacion();
        }

        public void Personalizacion()
        {
            this.BackColor = Color.FromArgb(140, 158, 255);
            grpbx_usuario.BackColor = Color.FromArgb(26, 35, 126);
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 109, 254);
        }

        private void MostrarEstablecimientos()
        {
            D_Instituciones esto = new D_Instituciones();
            cmb_codEst.DataSource = esto.ListarIns();
            cmb_codEst.DisplayMember = "Nombre";
            cmb_codEst.ValueMember = "CodIntitución";
        }

        private void MostrarUsuario()
        {
            txt_user.Text = CacheUsuariologeo.usuarioID;
            txt_contra.Text = CacheUsuariologeo.contraseña;
            txt_name.Text = CacheUsuariologeo.nombre;
            txt_lname.Text = CacheUsuariologeo.apellido;
            cmb_codEst.SelectedValue = CacheUsuariologeo.codigo_Establecimiento;
        }

        private void frm_EditarUsuario_Load(object sender, EventArgs e)
        {
            MostrarEstablecimientos();
            MostrarUsuario();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                CodUsuario = CacheUsuariologeo.codigo_Usuario.ToString();
                objetoUs.Editar(CodUsuario, txt_user.Text, txt_contra.Text, txt_name.Text, txt_lname.Text, cmb_codEst.SelectedValue.ToString());
                MessageBox.Show("Se edito el usuario correctamente");
                CacheUsuariologeo.codigo_Usuario = int.Parse(CodUsuario);
                CacheUsuariologeo.usuarioID = txt_user.Text;
                CacheUsuariologeo.contraseña = txt_contra.Text;
                CacheUsuariologeo.nombre = txt_name.Text;
                CacheUsuariologeo.apellido = txt_lname.Text;
                CacheUsuariologeo.codigo_Establecimiento = int.Parse(cmb_codEst.SelectedValue.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido editar el usuario");
            }
        }
    }
}
