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
    public partial class estandar4_3 : Form
    {
        D_Evaluaciones evaluacionesD = new D_Evaluaciones();
        D_Resultados resultadosD = new D_Resultados();

        int count = 0;
        int total = 0;
        string CodEvaluacion = null;
        string CodEstandar = "4.3";

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
            //Estos con los CheckListBox, al tratarlos como un "for" paso por cada Item
            //Y hago que quede desellecionado
            //pagina1
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
            for (int i = 0; i < clb_5.Items.Count; i++)
            {
                clb_5.SetItemChecked(i, false);
                clb_5.SelectedIndex = -1;
            }
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(i, false);
                clb.SelectedIndex = -1;
            }
            for (int i = 0; i < clb_6.Items.Count; i++)
            {
                clb_6.SetItemChecked(i, false);
                clb_6.SelectedIndex = -1;
            }
            for (int i = 0; i < clb_7.Items.Count; i++)
            {
                clb_7.SetItemChecked(i, false);
                clb_7.SelectedIndex = -1;
            }
            for (int i = 0; i < clb_8.Items.Count; i++)
            {
                clb_8.SetItemChecked(i, false);
                clb_8.SelectedIndex = -1;
            }
            tabctr1_estan4.SelectedTab = tabPage1;
        }

        private void Personalizar()
        {
            this.BackColor = Color.FromArgb(83, 109, 254);
            tabPage1.BackColor = Color.FromArgb(140, 158, 255);
            tabPage2.BackColor = Color.FromArgb(140, 158, 255);
            tabPage3.BackColor = Color.FromArgb(140, 158, 255);
            tabPage4.BackColor = Color.FromArgb(140, 158, 255);
            tabPage5.BackColor = Color.FromArgb(140, 158, 255);
            tabPage6.BackColor = Color.FromArgb(140, 158, 255);
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
            groupBox16.BackColor = Color.FromArgb(232, 234, 246);
            groupBox17.BackColor = Color.FromArgb(232, 234, 246);
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
            clb_5.BackColor = Color.FromArgb(197, 202, 233);
            clb_6.BackColor = Color.FromArgb(197, 202, 233);
            clb_7.BackColor = Color.FromArgb(197, 202, 233);
            clb_8.BackColor = Color.FromArgb(197, 202, 233);
            clb.BackColor = Color.FromArgb(197, 202, 233);
            btnllenar1.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btnllenar1.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btn.FlatStyle = FlatStyle.Flat;
            btn2.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btn2.FlatStyle = FlatStyle.Flat;
            btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btn3.FlatStyle = FlatStyle.Flat;
            btn4.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btn4.FlatStyle = FlatStyle.Flat;
            btn5.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btn5.FlatStyle = FlatStyle.Flat;
            btn7.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btn7.FlatStyle = FlatStyle.Flat;
            btn8.FlatAppearance.MouseOverBackColor = Color.FromArgb(159, 168, 218);
            btn8.FlatStyle = FlatStyle.Flat;
            splitContainer1.BackColor = Color.FromArgb(48, 79, 254);
            splitContainer1.Panel1.BackColor = Color.FromArgb(83, 109, 254);
            splitContainer1.Panel2.BackColor = Color.FromArgb(83, 109, 254);
        }

        public estandar4_3()
        {
            InitializeComponent();
            clb_1.CheckOnClick = true;
            clb_2.CheckOnClick = true;
            clb_3.CheckOnClick = true;
            clb_4.CheckOnClick = true;
            clb_5.CheckOnClick = true;
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

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_4.Items.Count; i++)
            {
                clb_4.SetItemChecked(i, true);
                clb_4.SelectedIndex = -1;
            }
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_6.Items.Count; i++)
            {
                clb_6.SetItemChecked(i, true);
                clb_6.SelectedIndex = -1;
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

        private void btn2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_2.Items.Count; i++)
            {
                clb_2.SetItemChecked(i, true);
                clb_2.SelectedIndex = -1;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_3.Items.Count; i++)
            {
                clb_3.SetItemChecked(i, true);
                clb_3.SelectedIndex = -1;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_5.Items.Count; i++)
            {
                clb_5.SetItemChecked(i, true);
                clb_5.SelectedIndex = -1;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(i, true);
                clb.SelectedIndex = -1;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_7.Items.Count; i++)
            {
                clb_7.SetItemChecked(i, true);
                clb_7.SelectedIndex = -1;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_8.Items.Count; i++)
            {
                clb_8.SetItemChecked(i, true);
                clb_8.SelectedIndex = -1;
            }
        }

        private void HacerResultados()
        {
            if (clb_1.CheckedItems.Count == 5)
            {
                resultadosD.CrearRes(68, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(68, false, CodEvaluacion);
            }
            if (clb_2.CheckedItems.Count == 4)
            {
                resultadosD.CrearRes(69, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(69, false, CodEvaluacion);
            }
            if (clb_3.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(70, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(70, false, CodEvaluacion);
            }
            if (clb_4.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(73, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(73, false, CodEvaluacion);
            }
            if (clb_5.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(74, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(74, false, CodEvaluacion);
            }
            if (clb.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(75, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(75, false, CodEvaluacion);
            }
            if (clb_6.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(76, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(76, false, CodEvaluacion);
            }
            if (clb_7.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(81, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(81, false, CodEvaluacion);
            }
            if (clb_8.CheckedItems.Count == 2)
            {
                resultadosD.CrearRes(83, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(83, false, CodEvaluacion);
            }
            if ((rbtn1.Checked == true))
            {
                resultadosD.CrearRes(71, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(71, false, CodEvaluacion);
            }
            if ((rbtn2.Checked == true))
            {
                resultadosD.CrearRes(72, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(72, false, CodEvaluacion);
            }
            if ((rbtn3.Checked == true))
            {
                resultadosD.CrearRes(77, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(77, false, CodEvaluacion);
            }
            if ((rbtn4.Checked == true))
            {
                resultadosD.CrearRes(78, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(78, false, CodEvaluacion);
            }
            if ((rbtn5.Checked == true))
            {
                resultadosD.CrearRes(79, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(79, false, CodEvaluacion);
            }
            if ((rbtn6.Checked == true))
            {
                resultadosD.CrearRes(80, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(80, false, CodEvaluacion);
            }
            if ((rbtn7.Checked == true))
            {
                resultadosD.CrearRes(82, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(82, false, CodEvaluacion);
            }
            if ((rbtn8.Checked == true))
            {
                resultadosD.CrearRes(84, true, CodEvaluacion);
            }
            else
            {
                resultadosD.CrearRes(84, false, CodEvaluacion);
            }
            count++;
        }

        private void MostrarEvaluado()
        {
            //Se limpia el dgv y se pone la nueva lectura
            dgv_estandar1.DataSource = null;
            dgv_estandar1.DataSource = resultadosD.LeerRes(CodEvaluacion);
        }

        private void estandar4_3_Load(object sender, EventArgs e)
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
    
            
        
