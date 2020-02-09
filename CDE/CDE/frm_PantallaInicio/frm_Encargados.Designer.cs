namespace frm_PantallaInicio
{
    partial class frm_Encargados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Encargados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picbx_titulo = new System.Windows.Forms.PictureBox();
            this.grpbx_evaluacion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name1 = new System.Windows.Forms.TextBox();
            this.txt_apell = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_borrar1 = new System.Windows.Forms.Button();
            this.btn_guardar1 = new System.Windows.Forms.Button();
            this.dgv_evaluadores = new System.Windows.Forms.DataGridView();
            this.lbl_indicación = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_titulo)).BeginInit();
            this.grpbx_evaluacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evaluadores)).BeginInit();
            this.SuspendLayout();
            // 
            // picbx_titulo
            // 
            this.picbx_titulo.Image = ((System.Drawing.Image)(resources.GetObject("picbx_titulo.Image")));
            this.picbx_titulo.Location = new System.Drawing.Point(342, 12);
            this.picbx_titulo.Name = "picbx_titulo";
            this.picbx_titulo.Size = new System.Drawing.Size(110, 110);
            this.picbx_titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_titulo.TabIndex = 34;
            this.picbx_titulo.TabStop = false;
            // 
            // grpbx_evaluacion
            // 
            this.grpbx_evaluacion.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpbx_evaluacion.Controls.Add(this.label3);
            this.grpbx_evaluacion.Controls.Add(this.label2);
            this.grpbx_evaluacion.Controls.Add(this.txt_name1);
            this.grpbx_evaluacion.Controls.Add(this.txt_apell);
            this.grpbx_evaluacion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grpbx_evaluacion.ForeColor = System.Drawing.Color.White;
            this.grpbx_evaluacion.Location = new System.Drawing.Point(571, 167);
            this.grpbx_evaluacion.Name = "grpbx_evaluacion";
            this.grpbx_evaluacion.Size = new System.Drawing.Size(462, 245);
            this.grpbx_evaluacion.TabIndex = 33;
            this.grpbx_evaluacion.TabStop = false;
            this.grpbx_evaluacion.Text = "EVALUADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // txt_name1
            // 
            this.txt_name1.Location = new System.Drawing.Point(188, 71);
            this.txt_name1.Name = "txt_name1";
            this.txt_name1.Size = new System.Drawing.Size(216, 27);
            this.txt_name1.TabIndex = 2;
            // 
            // txt_apell
            // 
            this.txt_apell.Location = new System.Drawing.Point(188, 127);
            this.txt_apell.Name = "txt_apell";
            this.txt_apell.Size = new System.Drawing.Size(216, 27);
            this.txt_apell.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Location = new System.Drawing.Point(458, 56);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(422, 30);
            this.lbl_titulo.TabIndex = 32;
            this.lbl_titulo.Text = "CREACIÓN Y EDICIÓN DE EVALUADORES";
            // 
            // btn_borrar1
            // 
            this.btn_borrar1.BackColor = System.Drawing.Color.Transparent;
            this.btn_borrar1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_borrar1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_borrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_borrar1.Location = new System.Drawing.Point(176, 591);
            this.btn_borrar1.Name = "btn_borrar1";
            this.btn_borrar1.Size = new System.Drawing.Size(359, 35);
            this.btn_borrar1.TabIndex = 31;
            this.btn_borrar1.Text = "BORRAR";
            this.btn_borrar1.UseVisualStyleBackColor = false;
            this.btn_borrar1.Click += new System.EventHandler(this.btn_borrar1_Click);
            // 
            // btn_guardar1
            // 
            this.btn_guardar1.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardar1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guardar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_guardar1.Location = new System.Drawing.Point(571, 429);
            this.btn_guardar1.Name = "btn_guardar1";
            this.btn_guardar1.Size = new System.Drawing.Size(462, 35);
            this.btn_guardar1.TabIndex = 29;
            this.btn_guardar1.Text = "GUARDAR";
            this.btn_guardar1.UseVisualStyleBackColor = false;
            this.btn_guardar1.Click += new System.EventHandler(this.btn_guardar1_Click);
            // 
            // dgv_evaluadores
            // 
            this.dgv_evaluadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_evaluadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_evaluadores.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_evaluadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_evaluadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_evaluadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_evaluadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_evaluadores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_evaluadores.EnableHeadersVisualStyles = false;
            this.dgv_evaluadores.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_evaluadores.Location = new System.Drawing.Point(176, 167);
            this.dgv_evaluadores.Name = "dgv_evaluadores";
            this.dgv_evaluadores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_evaluadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_evaluadores.RowHeadersVisible = false;
            this.dgv_evaluadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_evaluadores.Size = new System.Drawing.Size(359, 377);
            this.dgv_evaluadores.TabIndex = 28;
            this.dgv_evaluadores.DoubleClick += new System.EventHandler(this.dgv_evaluadores_DoubleClick);
            // 
            // lbl_indicación
            // 
            this.lbl_indicación.AutoSize = true;
            this.lbl_indicación.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_indicación.Location = new System.Drawing.Point(172, 559);
            this.lbl_indicación.Name = "lbl_indicación";
            this.lbl_indicación.Size = new System.Drawing.Size(167, 20);
            this.lbl_indicación.TabIndex = 35;
            this.lbl_indicación.Text = "*doble click para editar";
            // 
            // frm_Encargados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1120, 749);
            this.Controls.Add(this.lbl_indicación);
            this.Controls.Add(this.picbx_titulo);
            this.Controls.Add(this.grpbx_evaluacion);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_borrar1);
            this.Controls.Add(this.btn_guardar1);
            this.Controls.Add(this.dgv_evaluadores);
            this.Name = "frm_Encargados";
            this.Text = "frm_Encargados";
            this.Load += new System.EventHandler(this.frm_Encargados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_titulo)).EndInit();
            this.grpbx_evaluacion.ResumeLayout(false);
            this.grpbx_evaluacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evaluadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_titulo;
        private System.Windows.Forms.GroupBox grpbx_evaluacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name1;
        private System.Windows.Forms.TextBox txt_apell;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_borrar1;
        private System.Windows.Forms.Button btn_guardar1;
        private System.Windows.Forms.DataGridView dgv_evaluadores;
        private System.Windows.Forms.Label lbl_indicación;
    }
}