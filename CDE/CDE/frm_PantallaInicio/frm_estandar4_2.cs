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

namespace CONTROL_DE_EXPEDIENTES
{
    public partial class estandar4_2 : Form
    {
        D_Evaluaciones evaluacionesD = new D_Evaluaciones();
        D_Resultados resultadosD = new D_Resultados();

        int count = 0;
        int total = 0;
        string CodEvaluacion = null;
        string CodEstandar = "4.2";

        private void limpiar()
        {
            //Como su nombre lo dice, este metodo sirve para que todo lo que estaba seleccionado
            //Vuelva a su estado inicial
            //Ya que es un metodo lo invoco cuando quiera
            //Estos son todos los radiobutton, al ponerlos en false significa que los deselecciono
            rbtn1.Checked = false;
            rbtn2.Checked = false;
            rbtn3.Checked = false;
            rbtn4.Checked = false;
            rbtn5.Checked = false;
            rbtn6.Checked = false;
            rbtn7.Checked = false;
            rbtn8.Checked = false;
            rbtn9.Checked = false;
            rbtn10.Checked = false;
            rbtn11.Checked = false;

            //Estos con los CheckListBox, al tratarlos como un "for" paso por cada Item
            //Y hago que quede desellecionado
            for (int i = 0; i < clb_1.Items.Count; i++)
            {
                clb_1.SetItemChecked(i, false);
                clb_1.SelectedIndex = -1;
            }
            for (int i = 0; i < clb_2.Items.Count; i++)
            {
                clb_2.SetItemChecked(i, false);
                clb_2.SelectedIndex = -1;
            }
            for (int i = 0; i < clb_3.Items.Count; i++)
            {
                clb_3.SetItemChecked(i, false);
                clb_3.SelectedIndex = -1;
            }

            for (int i = 0; i < clb_4.Items.Count; i++)
            {
                clb_4.SetItemChecked(i, false);
                clb_4.SelectedIndex = -1;
            }
            tabct_estan4_2.SelectedTab = tabPage1;
        }

        private void Personalizar()
        {
            this.BackColor = Color.FromArgb(83, 109, 254);
            tabPage1.BackColor = Color.FromArgb(140, 158, 255);
            tabPage2.BackColor = Color.FromArgb(140, 158, 255);
            tabPage3.BackColor = Color.FromArgb(140, 158, 255);
            tabPage4.BackColor = Color.FromArgb(140, 158, 255);
            tabPage5.BackColor = Color.FromArgb(140, 158, 255);
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            btn_borrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 158, 255);
            groupBox1.BackColor = Color.FromArgb(232, 234, 246);
            groupBox10.BackColor = Color.FromArgb(232, 234, 246);
            groupBox11.BackColor = Color.FromArgb(232, 234, 246);
            groupBox12.BackColor = Color.FromArgb(232, 234, 246);
            groupBox13.BackColor = Color.FromArgb(232, 234, 246);
            groupBox14.BackColor = Color.FromArgb(232, 234, 246);
            groupBox15.BackColor = Color.FromArgb(232, 234, 246);
            groupBox2.BackColor = Color.FromArgb(232, 234, 246);
            groupBox3.BackColor = Color.FromArgb(232, 234, 246);
            groupBox4.BackColor = Color.FromArgb(232, 234, 246);
            groupBox5.BackColor = Color.FromArgb(232, 234, 246);
            groupBox6.BackColor = Color.FromArgb(232, 234, 246);
            groupBox7.BackColor = Color.FromArgb(232, 234, 246);
            groupBox8.BackColor = Color.FromArgb(232, 234, 246);
            groupBox9.BackColor = Color.FromArgb(232, 234, 246);
            clb_1.BackColor = Color.FromArgb(197, 202, 233);
            clb_2.BackColor = Color.FromArgb(197, 202, 233);
            clb_3.BackColor = Color.FromArgb(197, 202, 233);
            clb_4.BackColor = Color.FromArgb(197, 202, 233);
            btnllenar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btnllenar1.FlatStyle = FlatStyle.Flat;
            btnllenar2.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btnllenar2.FlatStyle = FlatStyle.Flat;
            btnllenar3.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btnllenar3.FlatStyle = FlatStyle.Flat;
            btnllenar4.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btnllenar4.FlatStyle = FlatStyle.Flat;
            splitContainer1.BackColor = Color.FromArgb(48, 79, 254);
            splitContainer1.Panel1.BackColor = Color.FromArgb(83, 109, 254);
            splitContainer1.Panel2.BackColor = Color.FromArgb(83, 109, 254);
        }

        public estandar4_2()
        {
            InitializeComponent();
            clb_1.CheckOnClick = true;
            clb_2.CheckOnClick = true;
            clb_3.CheckOnClick = true;
            clb_4.CheckOnClick = true;
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
            if (clb_1.CheckedItems.Count == 5)
            {
                resultadosD.CrearRes(53, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(53, false, CodEvaluacion);
            }
            if (clb_2.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(58, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(58, false, CodEvaluacion);
            }
            if (clb_3.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(64, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(64, false, CodEvaluacion);
            }
            if (clb_4.CheckedItems.Count == 3)
            {
                resultadosD.CrearRes(65, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(65, false, CodEvaluacion);
            }
            if (rbtn1.Checked == true)
            {
                resultadosD.CrearRes(54, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(54, false, CodEvaluacion);
            }
            if (rbtn2.Checked == true)
            {
                resultadosD.CrearRes(55, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(55, false, CodEvaluacion);
            }
            if (rbtn3.Checked == true)
            {
                resultadosD.CrearRes(56, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(56, false, CodEvaluacion);
            }
            if (rbtn4.Checked == true)
            {
                resultadosD.CrearRes(57, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(57, false, CodEvaluacion);
            }

            if (rbtn5.Checked == true)
            {
                resultadosD.CrearRes(59, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(59, false, CodEvaluacion);
            }
            if (rbtn6.Checked == true)
            {
                resultadosD.CrearRes(60, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(60, false, CodEvaluacion);
            }
            if (rbtn7.Checked == true)
            {
                resultadosD.CrearRes(61, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(61, false, CodEvaluacion);
            }
            if (rbtn8.Checked == true)
            {
                resultadosD.CrearRes(62, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(62, false, CodEvaluacion);
            }
            if (rbtn9.Checked == true)
            {
                resultadosD.CrearRes(63, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(63, false, CodEvaluacion);
            }
            if (rbtn10.Checked == true)
            {
                resultadosD.CrearRes(66, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(66, false, CodEvaluacion);
            }
            if (rbtn11.Checked == true)
            {
                resultadosD.CrearRes(67, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(67, false, CodEvaluacion);
            }
            count++;
        }

        private void MostrarEvaluado()
        {
            //Se limpia el dgv y se pone la nueva lectura
            dgv_estandar1.DataSource = null;
            dgv_estandar1.DataSource = resultadosD.LeerRes(CodEvaluacion);
        }

        private void btnllenar2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_2.Items.Count; i++)
            {
                clb_2.SetItemChecked(i, true);
                clb_2.SelectedIndex = -1;
            }
        }
        private void btnllenar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_1.Items.Count; i++)
            {
                clb_1.SetItemChecked(i, true);
                clb_1.SelectedIndex = -1;
            }
        }

        private void btnllenar3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_3.Items.Count; i++)
            {
                clb_3.SetItemChecked(i, true);
                clb_3.SelectedIndex = -1;
            }
        }

        private void btnllenar4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_4.Items.Count; i++)
            {
                clb_4.SetItemChecked(i, true);
                clb_4.SelectedIndex = -1;
            }
        }

        private void estandar4_2_Load(object sender, EventArgs e)
        {
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
    }
}