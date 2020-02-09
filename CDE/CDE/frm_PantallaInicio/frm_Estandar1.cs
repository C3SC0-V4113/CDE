using CapaComun.cacheUsuario;
using frm_PantallaInicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;

namespace Logeo
{    
    public partial class frm_1erestandar : Form
    {
        //Llamamos a las clases que usaremos
        D_Evaluaciones evaluacionesD = new D_Evaluaciones();
        D_Resultados resultadosD = new D_Resultados();

        //Contadores necesarios, el de CodEvaluacion es el que permite que la insercion sea dinamica
        int count = 0;
        int total = 0;
        string CodEvaluacion = null;
        string CodEstandar = "1";

        //Metodo que imprime la consulta de SQL en DGV Invisible, esta consulta lo que hace es buscar
        //La ultima evaluacion creada

        private void limpiar()
        {
            //Todo este metodo sirve para regresar el Formulario al estado neutral inicial
            rbtn_data31.Checked = false;
            rbtn_data32.Checked = false;
            rbtn_data41.Checked = false;
            rbtn_data42.Checked = false;
            rbtn_data51.Checked = false;
            rbtn_data52.Checked = false;
            rbtn_data53.Checked = false;
            rbtn_data54.Checked = false;
            rbtn_data55.Checked = false;
            rbtn_data61.Checked = false;
            rbtn_data62.Checked = false;
            rbtn_data63.Checked = false;
            for (int i = 0; i < checklistbx_data1.Items.Count; i++)
            {
                checklistbx_data1.SetItemChecked(i, false);
                checklistbx_data1.SelectedIndex = -1;
            }
            for (int i = 0; i < checklistbx_data2.Items.Count; i++)
            {
                checklistbx_data2.SetItemChecked(i, false);
                checklistbx_data2.SelectedIndex = -1;
            }
            tabcontrol_criterios.SelectedTab = tabPage1;
        }

        private void ValidarCampos()
        {
            if ((txt_codigo1.Text.Length==4) && (txt_codigo2.Text.Length==2))
            {
                var validCod = evaluacionesD.Comprobar(txt_codigo1.Text + "-" + txt_codigo2.Text);
                if (validCod == true)
                {

                }
                else
                {
                    errorProvider1.SetError(txt_codigo2, "Codigo actualmente en uso");
                }
            }
            else
            {
                errorProvider1.SetError(txt_codigo2, "Seleccione un codigo válido");
            }
        }

        private void Personalizacion()
        {
            this.BackColor = Color.FromArgb(83, 109, 254);
            tabPage1.BackColor = Color.FromArgb(140, 158, 255);
            tabPage2.BackColor = Color.FromArgb(140, 158, 255);
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            btn_borrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            grpbx_data1.BackColor = Color.FromArgb(232, 234, 246);
            grpbx_data2.BackColor = Color.FromArgb(232, 234, 246);
            grpbx_data3.BackColor = Color.FromArgb(232, 234, 246);
            grpbx_data4.BackColor = Color.FromArgb(232, 234, 246);
            grpbx_data5.BackColor = Color.FromArgb(232, 234, 246);
            grpbx_data6.BackColor = Color.FromArgb(232, 234, 246);
            checklistbx_data1.BackColor = Color.FromArgb(197, 202, 233);
            checklistbx_data2.BackColor = Color.FromArgb(197, 202, 233);
            btn_llenar.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btn_llenar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            split_dgv_criterios.BackColor = Color.FromArgb(48, 79, 254);
            split_dgv_criterios.Panel1.BackColor= Color.FromArgb(83, 109, 254);
            split_dgv_criterios.Panel2.BackColor = Color.FromArgb(83, 109, 254);
        }

        public frm_1erestandar()
        {
            InitializeComponent();
            Personalizacion();
            //Este sirve para que cuando el usuario toque el DataGridView, seleccione toda la fila
            //No solo una celda
            dgv_estandar1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Por defecto los CheckListBox vienen que debes clickearlos dos veces para seleccionar
            //Para que no sea cansado, aplico esto para que solo un click sea suficiente
            checklistbx_data1.CheckOnClick = true;
            checklistbx_data2.CheckOnClick = true;
            //Se agrega el boton guardar, pero de base este estara inhabilitado
            //Se habilitara hasta que hayan registros
            btn_guardar.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
            //Esto elimina la molesta fila del final
            dgv_estandar1.AllowUserToAddRows = false;
            //Esto valida el DateTimePicker para que no se tomen fechas futuras, solo la actual y pasadas
            dtp_fecha.MaxDate = DateTime.Now;
            txt_codigo1.MaxLength = 4;
            txt_codigo2.MaxLength = 2;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CodEvaluacion = txt_codigo1.Text + "-" + txt_codigo2.Text;
            if (txt_codigo2.Enabled == true)
            {
                if ((txt_codigo1.Text.Length == 4) && (txt_codigo2.Text.Length == 2))
                {
                    var validCod = evaluacionesD.Comprobar(CodEvaluacion);
                    if (validCod == true)
                    {
                        try
                        {
                            if (count == 0)
                            {
                                try
                                {
                                    evaluacionesD.CrearEva(CodEvaluacion, total, CodEstandar, int.Parse(CacheUsuariologeo.codigo_Usuario.ToString()), dtp_fecha.Value, int.Parse(cmb_codEvaluador.SelectedValue.ToString()));
                                    MessageBox.Show("Se creo la Evaluacion\n" + CodEvaluacion);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("No se creo la Evaluacion" + ex);
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            try
                            {
                                HacerEvaluacion();
                                MostrarEvaluado();
                                limpiar();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            if (dgv_estandar1.Rows.Count > 0)
                            {
                                //Si hay mas de cero filas en el dgv, el boton siguiente se activa
                                btn_guardar.Enabled = true;
                            }
                            cmb_codEvaluador.Enabled = false;
                            dtp_fecha.Enabled = false;
                            txt_codigo1.Enabled = false;
                            txt_codigo2.Enabled = false;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txt_codigo2, "Codigo actualmente en uso");
                    }
                }
                else
                {
                    errorProvider1.SetError(txt_codigo2, "Seleccione un codigo válido");
                }
            }
            else
            {
                try
                {
                    if (count == 0)
                    {
                        try
                        {
                            evaluacionesD.CrearEva(CodEvaluacion, total, CodEstandar, int.Parse(CacheUsuariologeo.codigo_Usuario.ToString()), dtp_fecha.Value, int.Parse(cmb_codEvaluador.SelectedValue.ToString()));
                            MessageBox.Show("Se creo la Evaluacion\n" + CodEvaluacion);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se creo la Evaluacion" + ex);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    try
                    {
                        HacerEvaluacion();
                        MostrarEvaluado();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    if (dgv_estandar1.Rows.Count > 0)
                    {
                        //Si hay mas de cero filas en el dgv, el boton siguiente se activa
                        btn_guardar.Enabled = true;
                    }
                    cmb_codEvaluador.Enabled = false;
                    dtp_fecha.Enabled = false;
                    txt_codigo1.Enabled = false;
                    txt_codigo2.Enabled = false;
                }
            }
        }

        private void HacerEvaluacion()
        {
            //Se hace la evaluacion segun si esta marcado o no
            if (checklistbx_data1.CheckedItems.Count == 5)
            {
                resultadosD.CrearRes(1, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(1, false, CodEvaluacion);
            }
            if (checklistbx_data2.CheckedItems.Count == 5)
            {
                resultadosD.CrearRes(2, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(2, false, CodEvaluacion);
            }
            if ((rbtn_data31.Checked == true) || (rbtn_data32.Checked == true))
            {
                resultadosD.CrearRes(3, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(3, false, CodEvaluacion);
            }
            if ((rbtn_data41.Checked == true) || (rbtn_data42.Checked == true))
            {
                resultadosD.CrearRes(4, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(4, false, CodEvaluacion);
            }
            if ((rbtn_data51.Checked == true) || (rbtn_data52.Checked == true) || (rbtn_data53.Checked == true) || (rbtn_data54.Checked == true) || (rbtn_data55.Checked == true))
            {
                resultadosD.CrearRes(5, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(5, false, CodEvaluacion);
            }
            if ((rbtn_data61.Checked == true) || (rbtn_data62.Checked == true) || (rbtn_data63.Checked == true))
            {
                resultadosD.CrearRes(6, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(6, false, CodEvaluacion);
            }
            //El contador suma, asi la proxima vez que de a siguiente, no se creara una nueva evaluacion
            count++;
        }
        
        private void frm_1erestandar_Load(object sender, EventArgs e)
        {
            //Se hace invisible el dgv que lee la evaluacion y se cambia la fuente al dgv
            dgv_estandar1.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            MostrarEvaluadores();
        }

        private void MostrarEvaluado()
        {
            //Se limpia el dgv y se pone la nueva lectura
            dgv_estandar1.DataSource = null;
            dgv_estandar1.DataSource = resultadosD.LeerRes(CodEvaluacion);
        }

        private void MostrarEvaluadores()
        {
            D_Evaluadores d_Evaluadores = new D_Evaluadores();
            cmb_codEvaluador.DataSource = d_Evaluadores.ListarEncar();
            cmb_codEvaluador.DisplayMember = "Nombre";
            cmb_codEvaluador.ValueMember = "CodCargo";
        }

        //Estas dos funciones son de los botones "LLENAR", si, de ambos
        //Lo que hacen es lo contrario que hacian en limpiar, ya que clickear 5 veces si sabes que todo
        //esta bien puede ser cansado, pues ya esta, los 5 items llenos
        private void btn_llenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checklistbx_data1.Items.Count; i++)
            {
                checklistbx_data1.SetItemChecked(i, true);
                checklistbx_data1.SelectedIndex = -1;
            }
        }
        private void btn_llenar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checklistbx_data2.Items.Count; i++)
            {
                checklistbx_data2.SetItemChecked(i, true);
                checklistbx_data2.SelectedIndex = -1;
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            //Se muestra un mensaje si esta seguro de borrar toda la evaluacion
            if (MessageBox.Show("¿Seguro que deseas eliminar estos datos? Se eliminaran todos los datos en esta tabla", "ALTO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                resultadosD.EliminarRes(CodEvaluacion);
                if (dgv_estandar1.Rows.Count > 0)
                {
                    btn_guardar.Enabled = true;
                }
                //Se actualiza el dgv
                MostrarEvaluado();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            count = 0;
            limpiar();
            cmb_codEvaluador.Enabled = true;
            dtp_fecha.Enabled = true;
            txt_codigo1.Enabled = true;
            txt_codigo2.Enabled = true;
            dtp_fecha.Value = DateTime.Today;
            cmb_codEvaluador.SelectedIndex = -1;
            txt_codigo1.Clear();
            txt_codigo2.Clear();
            dgv_estandar1.DataSource = null;
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_codigo1.Text.Length == 3)
            {
                txt_codigo2.Focus();
            }
            else
            {

            }
        }
    }
}
