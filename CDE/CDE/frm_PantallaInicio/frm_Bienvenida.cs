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
    public partial class frm_Bienvenida : Form
    {
        public frm_Bienvenida()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(140, 158, 255);
            lbl_nombre.Text = (CacheUsuariologeo.nombre + " " + CacheUsuariologeo.apellido);
        }
    }
}
