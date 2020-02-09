using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_PantallaInicio
{
    public partial class frm_PantallaInicio : Form
    {
        TimeSpan time;
        public frm_PantallaInicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_temporizadorinvisible.Visible = false;
        }

        private void frm_PantallaInicio_Load(object sender, EventArgs e)
        {
            time = TimeSpan.Parse("00:04:00");

            Timer timer = new Timer();
            timer.Start();
            timer.Interval = 1;

            timer.Tick += (a, b) =>
            {
                time = time.Subtract(new TimeSpan(0, 0, 1));
                txt_temporizadorinvisible.Text = time.ToString();

                if ((time.Seconds == 0)&&(time.Minutes == 0))
                {
                    timer.Stop();
                    frm_IniciodeSesion frm2 = new frm_IniciodeSesion();
                    frm2.Show();
                    this.Hide();
                return;
                }
            };
        }

        private void picbx_logo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_desarrollo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_derechos_Click(object sender, EventArgs e)
        {

        }

        private void lbl_equipo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ana_Click(object sender, EventArgs e)
        {

        }

        private void lbl_karla_Click(object sender, EventArgs e)
        {

        }

        private void lbl_iveth_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cesco_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_william_Click(object sender, EventArgs e)
        {

        }

        private void lbl_materia2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_materia1_Click(object sender, EventArgs e)
        {

        }
    }
}
