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

namespace frm_PantallaInicio
{
    public partial class frm_menu : Form
    {
        private void CargardatosUsuario()
        {
            lbl_nombre.Text = CacheUsuariologeo.nombre+", "+CacheUsuariologeo.apellido;
            lbl_codigo.Text = CacheUsuariologeo.codigo_Usuario.ToString();
        }

        private Form formactivo = null;
        private void abrirFormsHijos(Form hijo)
        {
            if(formactivo !=null)
            {
                formactivo.Close();
            }
            formactivo = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelForm.Controls.Add(hijo);
            panelForm.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        public void Personalizar()
        {
            panel_usuario.BackColor = Color.FromArgb(48, 79, 254);
            panel_MenuLateral.BackColor = Color.FromArgb(48, 79, 254);
            añadirEvaluadorTSMI.BackColor = Color.FromArgb(197, 202, 233);
            AñadirInstiTSMI.BackColor = Color.FromArgb(197, 202, 233);
            AñadirUsuarioTSMI.BackColor = Color.FromArgb(197, 202, 233);
            EditUsuarioTSMI.BackColor = Color.FromArgb(197, 202, 233);
            menuStripEditar.BackColor = Color.FromArgb(140, 158, 255);
            Criterio41TSMI.BackColor = Color.FromArgb(197, 202, 233);
            Criterio42TSMI.BackColor = Color.FromArgb(197, 202, 233);
            Criterio43TSMI.BackColor = Color.FromArgb(197, 202, 233);
        }

        public frm_menu()
        {
            InitializeComponent();
            Personalizar();
            this.WindowState = FormWindowState.Maximized;
            CargardatosUsuario();
            abrirFormsHijos(new frm_Bienvenida());
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas cerrar sesión?", "ALTO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void cRITERIO1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrirFormsHijos(new Logeo.frm_1erestandar());
        }

        private void cRETERIO2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrirFormsHijos(new Estan.frm_estandar2());
        }

        private void cRITERIO3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrirFormsHijos(new Estan.frm_3estandar());
        }

        private void cRITERIO41ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrirFormsHijos(new CONTROL_DE_EXPEDIENTES.frm_estandar4_1());
        }

        private void cRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrirFormsHijos(new CONTROL_DE_EXPEDIENTES.estandar4_2());
        }

        private void criterio43ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrirFormsHijos(new CONTROL_DE_EXPEDIENTES.estandar4_3());
        }

        private void criterioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abrirFormsHijos(new Estan.frm_5estandar());
        }

        private void Creditos_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_Creditos());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_RegistrarIntitucion());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_RegistroUsuario());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_EditarUsuario());
        }

        private void picbx_user_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_Bienvenida());
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_BusquedaInformes());
        }

        private void añadirEvaluadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormsHijos(new frm_Encargados());
        }
    }
}
