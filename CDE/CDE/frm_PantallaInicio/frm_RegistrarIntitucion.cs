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
    public partial class frm_RegistrarIntitucion : Form
    {
        D_Instituciones est = new D_Instituciones();
        private int edit_indice = -1;
        private string CodInstitucion = null;

        public void Personalizacion()
        {
            this.BackColor = Color.FromArgb(140, 158, 255);
            grpbx_institucion.BackColor = Color.FromArgb(26, 35, 126);
            btn_guardar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 109, 254);
            btn_borrar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 109, 254);
        }

        public frm_RegistrarIntitucion()
        {
            InitializeComponent();
            Personalizacion();
            dgv_lugares1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_lugares1.AllowUserToAddRows = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_name1.Focus();
        }

        private bool validarCampos()
        {
            //variable que verifica si algo ha sido validado
            bool validado = true;
            if (txt_name1.Text == "") //vefica que no quede vacío el campo
            {
                validado = false; //si está vacío validado es falso
            }
            //verifico la casilla de apellido
            if (txt_local1.Text == "")
            {
                validado = false;
            }
            return validado;
        }

        private void limpiar()
        {
            txt_local1.Clear();
            txt_name1.Clear();
        }

        private void frm_RegistrarEstablecimiento_Load(object sender, EventArgs e)
        {
            MostrarEstablecimientos();
            dgv_lugares1.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        }

        private void MostrarEstablecimientos()
        {
            D_Instituciones esto = new D_Instituciones();
            dgv_lugares1.DataSource = esto.MostrarEst();
        }

        private bool editar = false;

        private void btn_guardar1_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    if (validarCampos())
                    {
                        est.InsertarEst(txt_name1.Text, txt_local1.Text);
                    }
                    MostrarEstablecimientos();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se insertaron los datos" + ex);
                }
            }
            else
            {
                try
                {
                    est.Editar(CodInstitucion, txt_name1.Text, txt_local1.Text);
                    MostrarEstablecimientos();
                    editar = false;
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se insertaron los datos" + ex);
                }
            }
        }

        private void btn_borrar1_Click(object sender, EventArgs e)
        {
            if (dgv_lugares1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro que deseas borrar esta Institucion? \n Se perderan los datos relacionados a ella", "ALTO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CodInstitucion = dgv_lugares1.CurrentRow.Cells["CodIntitución"].Value.ToString();
                    est.Eliminar(CodInstitucion);
                    MostrarEstablecimientos();
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void dgv_lugares1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgv_lugares1.SelectedRows[0];
            //almacena en cual fila estoy
            int pos = dgv_lugares1.Rows.IndexOf(seleccion);
            //copio esa variable en índice editado
            edit_indice = pos;
            if (dgv_lugares1.SelectedRows.Count > 0)
            {
                editar = true;
                CodInstitucion = dgv_lugares1.CurrentRow.Cells["CodIntitución"].Value.ToString();
                txt_name1.Text = dgv_lugares1.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_local1.Text = dgv_lugares1.CurrentRow.Cells["Ubicación"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
