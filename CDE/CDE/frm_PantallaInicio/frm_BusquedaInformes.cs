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
    public partial class frm_BusquedaInformes : Form
    {
        D_Resultados res = new D_Resultados();
        private int edit_indice = -1;

        private void Personalizar()
        {
            this.BackColor = Color.FromArgb(83, 109, 254);
            splitContainer1.BackColor = Color.FromArgb(48, 79, 254);
            splitContainer2.BackColor = Color.FromArgb(48, 79, 254);
            splitContainer1.Panel1.BackColor = Color.FromArgb(83, 109, 254);
            splitContainer1.Panel2.BackColor = Color.FromArgb(83, 109, 254);
            splitContainer2.Panel1.BackColor = Color.FromArgb(83, 109, 254);
            splitContainer2.Panel2.BackColor = Color.FromArgb(83, 109, 254);
            btn_buscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
        }

        public frm_BusquedaInformes()
        {
            InitializeComponent();
            Personalizar();
            dtp_fechafinal.MaxDate = DateTime.Now;
            dtp_fechainicial.MaxDate = DateTime.Now;
            MostrarEstandares();
            dgv_informe.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dgv_evaluadosresultados.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dgv_evaluadosresultados.AllowUserToAddRows = false;
            dgv_informe.AllowUserToAddRows = false;
        }

        private void frm_BusquedaInformes_Load(object sender, EventArgs e)
        {

        }

        private void MostrarEstandares()
        {
            D_Estandares esta = new D_Estandares();
            cmb_CodEstandar.DataSource = esta.ListarEst();
            cmb_CodEstandar.DisplayMember = "CodEstandar";
            cmb_CodEstandar.ValueMember = "CodEstandar";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_informe.DataSource=res.LeerFecha(dtp_fechainicial.Value, dtp_fechafinal.Value, cmb_CodEstandar.SelectedValue.ToString());
        }

        private void dgv_informe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string CodigoEvaluacion = null;
            DataGridViewRow seleccion = dgv_informe.SelectedRows[0];
            //almacena en cual fila estoy
            int pos = dgv_informe.Rows.IndexOf(seleccion);
            //copio esa variable en índice editado
            edit_indice = pos;
            if (dgv_informe.SelectedRows.Count > 0)
            {
                CodigoEvaluacion = dgv_informe.CurrentRow.Cells["Codigo de Evaluacion"].Value.ToString();
                dgv_evaluadosresultados.DataSource= res.LeerRes(CodigoEvaluacion);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
