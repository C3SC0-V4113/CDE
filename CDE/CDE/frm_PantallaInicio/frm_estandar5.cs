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
using CapaComun.cacheUsuario;

namespace Estan
{
    public partial class frm_5estandar : Form
    {
        D_Evaluaciones evaluacionesD = new D_Evaluaciones();
        D_Resultados resultadosD = new D_Resultados();

        int count = 0;
        int total = 0;
        string CodEvaluacion = null;
        string CodEstandar = "5";

        private void limpiar()
        {
            rbtn_data1.Checked = false;
            rbtn_data2.Checked = false;
            rbtn_data3.Checked = false;
            rbtn_data4.Checked = false;
            rbtn_data5.Checked = false;
            rbtn_data6.Checked = false;
            rbtn_data7.Checked = false;
            for (int i = 0; i < clb_data1.Items.Count; i++)
            {
                clb_data1.SetItemChecked(i, false);
                clb_data1.SelectedIndex = -1;
            }
            tabctrl_estan5.SelectedTab = tabPage1;
            for (int i = 0; i < clb_data2.Items.Count; i++)
            {
                clb_data2.SetItemChecked(i, false);
                clb_data2.SelectedIndex = -1;
            }
            for (int i = 0; i < clb_data3.Items.Count; i++)
            {
                clb_data3.SetItemChecked(i, false);
                clb_data3.SelectedIndex = -1;
            }
        }

        private void Personalizar()
        {
            this.BackColor = Color.FromArgb(83, 109, 254);
            tabPage1.BackColor = Color.FromArgb(140, 158, 255);
            tabPage2.BackColor = Color.FromArgb(140, 158, 255);
            tabPage3.BackColor = Color.FromArgb(140, 158, 255);
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            btn_borrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            groupBox1.BackColor = Color.FromArgb(232, 234, 246);
            groupBox10.BackColor = Color.FromArgb(232, 234, 246);
            groupBox2.BackColor = Color.FromArgb(232, 234, 246);
            groupBox3.BackColor = Color.FromArgb(232, 234, 246);
            groupBox4.BackColor = Color.FromArgb(232, 234, 246);
            groupBox5.BackColor = Color.FromArgb(232, 234, 246);
            groupBox6.BackColor = Color.FromArgb(232, 234, 246);
            groupBox7.BackColor = Color.FromArgb(232, 234, 246);
            groupBox8.BackColor = Color.FromArgb(232, 234, 246);
            groupBox9.BackColor = Color.FromArgb(232, 234, 246);
            clb_data1.BackColor = Color.FromArgb(197, 202, 233);
            clb_data2.BackColor = Color.FromArgb(197, 202, 233);
            clb_data3.BackColor = Color.FromArgb(197, 202, 233);
            btnllenar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btnllenar1.FlatStyle = FlatStyle.Flat;
            btnllenar2.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btnllenar2.FlatStyle = FlatStyle.Flat;
            btnllenar3.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btnllenar3.FlatStyle = FlatStyle.Flat;
            splitContainer1.BackColor = Color.FromArgb(48, 79, 254);
            splitContainer1.Panel1.BackColor = Color.FromArgb(83, 109, 254);
            splitContainer1.Panel2.BackColor = Color.FromArgb(83, 109, 254);
        }

        public frm_5estandar()
        {
            InitializeComponent();
            clb_data1.CheckOnClick = true;
            clb_data2.CheckOnClick = true;
            clb_data3.CheckOnClick = true;
            this.WindowState = FormWindowState.Maximized;
            dgv_estandar1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_estandar1.AllowUserToAddRows = false;
            Personalizar();
            dtp_fecha.MaxDate = DateTime.Now;
            dgv_estandar1.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            txt_codigo1.MaxLength = 4;
            txt_codigo2.MaxLength = 2;
            MostrarEvaluadores();
            btn_guardar.Enabled = false;
        }

        private void HacerResultados()
        {
            if (clb_data1.CheckedItems.Count == 8)
            {
                resultadosD.CrearRes(87, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(87, false, CodEvaluacion);
            }
            if (clb_data2.CheckedItems.Count == 9)
            {
                resultadosD.CrearRes(91, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(91, false, CodEvaluacion);
            }
            if (clb_data3.CheckedItems.Count == 3)
            {
                resultadosD.CrearRes(94, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(94, false, CodEvaluacion);
            }
            if ((rbtn_data1.Checked == true))
            {
                resultadosD.CrearRes(85, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(85, false, CodEvaluacion);
            }
            if ((rbtn_data2.Checked == true))
            {
                resultadosD.CrearRes(86, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(86, false, CodEvaluacion);
            }
            if ((rbtn_data3.Checked == true))
            {
                resultadosD.CrearRes(88, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(88, false, CodEvaluacion);
            }
            if ((rbtn_data4.Checked == true))
            {
                resultadosD.CrearRes(89, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(89, false, CodEvaluacion);
            }
            if ((rbtn_data5.Checked == true))
            {
                resultadosD.CrearRes(90, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(90, false, CodEvaluacion);
            }
            if ((rbtn_data6.Checked == true))
            {
                resultadosD.CrearRes(92, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(92, false, CodEvaluacion);
            }
            if ((rbtn_data7.Checked == true))
            {
                resultadosD.CrearRes(93, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(93, false, CodEvaluacion);
            }
            count++;
        }

        private void MostrarEvaluado()
        {
            //Se limpia el dgv y se pone la nueva lectura
            dgv_estandar1.DataSource = null;
            dgv_estandar1.DataSource = resultadosD.LeerRes(CodEvaluacion);
        }

        private void btnllenar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_data1.Items.Count; i++)
            {
                clb_data1.SetItemChecked(i, true);
                clb_data1.SelectedIndex = -1;
            }
        }

        private void btnllenar2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_data2.Items.Count; i++)
            {
                clb_data2.SetItemChecked(i, true);
                clb_data2.SelectedIndex = -1;
            }
        }

        private void btnllenar3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_data3.Items.Count; i++)
            {
                clb_data3.SetItemChecked(i, true);
                clb_data3.SelectedIndex = -1;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
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
                                HacerResultados();
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
                        HacerResultados();
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

        private void MostrarEvaluadores()
        {
            D_Evaluadores d_Evaluadores = new D_Evaluadores();
            cmb_codEvaluador.DataSource = d_Evaluadores.ListarEncar();
            cmb_codEvaluador.DisplayMember = "Nombre";
            cmb_codEvaluador.ValueMember = "CodCargo";
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

        private void frm_5estandar_Load(object sender, EventArgs e)
        {

        }

        private void txt_codigo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_codigo1.Text.Length == 3)
            {
                txt_codigo2.Focus();
            }
            else
            {

            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
