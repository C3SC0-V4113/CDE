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
    public partial class frm_Encargados : Form
    {
        D_Evaluadores encar = new D_Evaluadores();
        private int edit_indice = -1;
        private string CodCargo = null;
        private bool editar = false;

        public void Personalizacion()
        {
            this.BackColor = Color.FromArgb(140, 158, 255);
            grpbx_evaluacion.BackColor = Color.FromArgb(26, 35, 126);
            btn_guardar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 109, 254);
            btn_borrar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 109, 254);
        }

        public frm_Encargados()
        {
            InitializeComponent();
            Personalizacion();
            dgv_evaluadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_evaluadores.AllowUserToAddRows = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frm_Encargados_Load(object sender, EventArgs e)
        {
            MostrarEncargados();
            dgv_evaluadores.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        }

        private void MostrarEncargados()
        {
            D_Evaluadores d_Evaluadores = new D_Evaluadores();
            dgv_evaluadores.DataSource = d_Evaluadores.MostrarEncar();
        }

        private void Limpiar()
        {
            txt_apell.Clear();
            txt_name1.Clear();
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
            if (txt_apell.Text == "")
            {
                validado = false;
            }
            return validado;
        }

        private void btn_guardar1_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    if (validarCampos()==true)
                    {
                        encar.InsertarEncar(txt_name1.Text, txt_apell.Text);
                    }
                    MostrarEncargados();
                    Limpiar();
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
                    encar.Editar(CodCargo, txt_name1.Text, txt_apell.Text);
                    MostrarEncargados();
                    editar = false;
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se insertaron los datos" + ex);
                }
            }
        }

        private void btn_borrar1_Click(object sender, EventArgs e)
        {
            if (dgv_evaluadores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro que deseas borrar este Evaluador? \n Se perderan los datos relacionados a el/ella", "ALTO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CodCargo = dgv_evaluadores.CurrentRow.Cells["CodCargo"].Value.ToString();
                    encar.Eliminar(CodCargo);
                    MostrarEncargados();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void dgv_evaluadores_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgv_evaluadores.SelectedRows[0];
            //almacena en cual fila estoy
            int pos = dgv_evaluadores.Rows.IndexOf(seleccion);
            //copio esa variable en índice editado
            edit_indice = pos;
            if (dgv_evaluadores.SelectedRows.Count > 0)
            {
                editar = true;
                CodCargo = dgv_evaluadores.CurrentRow.Cells["CodCargo"].Value.ToString();
                txt_name1.Text = dgv_evaluadores.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_apell.Text = dgv_evaluadores.CurrentRow.Cells["Apellido"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
