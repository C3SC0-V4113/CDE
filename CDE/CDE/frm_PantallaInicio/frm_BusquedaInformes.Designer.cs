namespace frm_PantallaInicio
{
    partial class frm_BusquedaInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BusquedaInformes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dtp_fechainicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechafinal = new System.Windows.Forms.DateTimePicker();
            this.cmb_CodEstandar = new System.Windows.Forms.ComboBox();
            this.lbl_fechaInicial = new System.Windows.Forms.Label();
            this.lbl_fechafinal = new System.Windows.Forms.Label();
            this.lbl_CodEstandar = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.picbx_titulo = new System.Windows.Forms.PictureBox();
            this.dgv_informe = new System.Windows.Forms.DataGridView();
            this.dgv_evaluadosresultados = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evaluadosresultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(511, 66);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(323, 30);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "BUSQUEDA DE EVALUACIONES";
            // 
            // dtp_fechainicial
            // 
            this.dtp_fechainicial.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dtp_fechainicial.Location = new System.Drawing.Point(213, 171);
            this.dtp_fechainicial.Name = "dtp_fechainicial";
            this.dtp_fechainicial.Size = new System.Drawing.Size(246, 25);
            this.dtp_fechainicial.TabIndex = 3;
            // 
            // dtp_fechafinal
            // 
            this.dtp_fechafinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dtp_fechafinal.Location = new System.Drawing.Point(575, 171);
            this.dtp_fechafinal.Name = "dtp_fechafinal";
            this.dtp_fechafinal.Size = new System.Drawing.Size(246, 25);
            this.dtp_fechafinal.TabIndex = 4;
            // 
            // cmb_CodEstandar
            // 
            this.cmb_CodEstandar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_CodEstandar.FormattingEnabled = true;
            this.cmb_CodEstandar.Location = new System.Drawing.Point(932, 169);
            this.cmb_CodEstandar.Name = "cmb_CodEstandar";
            this.cmb_CodEstandar.Size = new System.Drawing.Size(121, 25);
            this.cmb_CodEstandar.TabIndex = 5;
            // 
            // lbl_fechaInicial
            // 
            this.lbl_fechaInicial.AutoSize = true;
            this.lbl_fechaInicial.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_fechaInicial.ForeColor = System.Drawing.Color.White;
            this.lbl_fechaInicial.Location = new System.Drawing.Point(87, 177);
            this.lbl_fechaInicial.Name = "lbl_fechaInicial";
            this.lbl_fechaInicial.Size = new System.Drawing.Size(87, 19);
            this.lbl_fechaInicial.TabIndex = 6;
            this.lbl_fechaInicial.Text = "Fecha Inicial";
            // 
            // lbl_fechafinal
            // 
            this.lbl_fechafinal.AutoSize = true;
            this.lbl_fechafinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_fechafinal.ForeColor = System.Drawing.Color.White;
            this.lbl_fechafinal.Location = new System.Drawing.Point(480, 171);
            this.lbl_fechafinal.Name = "lbl_fechafinal";
            this.lbl_fechafinal.Size = new System.Drawing.Size(79, 19);
            this.lbl_fechafinal.TabIndex = 7;
            this.lbl_fechafinal.Text = "Fecha Final";
            // 
            // lbl_CodEstandar
            // 
            this.lbl_CodEstandar.AutoSize = true;
            this.lbl_CodEstandar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_CodEstandar.ForeColor = System.Drawing.Color.White;
            this.lbl_CodEstandar.Location = new System.Drawing.Point(864, 169);
            this.lbl_CodEstandar.Name = "lbl_CodEstandar";
            this.lbl_CodEstandar.Size = new System.Drawing.Size(62, 19);
            this.lbl_CodEstandar.TabIndex = 8;
            this.lbl_CodEstandar.Text = "Estandar";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(903, 104);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(150, 35);
            this.btn_buscar.TabIndex = 25;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // picbx_titulo
            // 
            this.picbx_titulo.Image = ((System.Drawing.Image)(resources.GetObject("picbx_titulo.Image")));
            this.picbx_titulo.Location = new System.Drawing.Point(395, 29);
            this.picbx_titulo.Name = "picbx_titulo";
            this.picbx_titulo.Size = new System.Drawing.Size(110, 110);
            this.picbx_titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_titulo.TabIndex = 28;
            this.picbx_titulo.TabStop = false;
            // 
            // dgv_informe
            // 
            this.dgv_informe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_informe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_informe.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_informe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_informe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_informe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_informe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_informe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_informe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_informe.EnableHeadersVisualStyles = false;
            this.dgv_informe.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_informe.Location = new System.Drawing.Point(0, 0);
            this.dgv_informe.Name = "dgv_informe";
            this.dgv_informe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_informe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_informe.RowHeadersVisible = false;
            this.dgv_informe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_informe.Size = new System.Drawing.Size(369, 508);
            this.dgv_informe.TabIndex = 48;
            this.dgv_informe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_informe_CellClick);
            // 
            // dgv_evaluadosresultados
            // 
            this.dgv_evaluadosresultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_evaluadosresultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_evaluadosresultados.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_evaluadosresultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_evaluadosresultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_evaluadosresultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_evaluadosresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_evaluadosresultados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_evaluadosresultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_evaluadosresultados.EnableHeadersVisualStyles = false;
            this.dgv_evaluadosresultados.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_evaluadosresultados.Location = new System.Drawing.Point(0, 0);
            this.dgv_evaluadosresultados.Name = "dgv_evaluadosresultados";
            this.dgv_evaluadosresultados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_evaluadosresultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_evaluadosresultados.RowHeadersVisible = false;
            this.dgv_evaluadosresultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_evaluadosresultados.Size = new System.Drawing.Size(739, 508);
            this.dgv_evaluadosresultados.TabIndex = 49;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.picbx_titulo);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_titulo);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_fechainicial);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_fechafinal);
            this.splitContainer1.Panel1.Controls.Add(this.btn_buscar);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_CodEstandar);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_CodEstandar);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_fechaInicial);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_fechafinal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 749);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 50;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv_informe);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgv_evaluadosresultados);
            this.splitContainer2.Size = new System.Drawing.Size(1120, 512);
            this.splitContainer2.SplitterDistance = 373;
            this.splitContainer2.TabIndex = 50;
            // 
            // frm_BusquedaInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1120, 749);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_BusquedaInformes";
            this.Text = "frm_BusquedaInformes";
            this.Load += new System.EventHandler(this.frm_BusquedaInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evaluadosresultados)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DateTimePicker dtp_fechainicial;
        private System.Windows.Forms.DateTimePicker dtp_fechafinal;
        private System.Windows.Forms.ComboBox cmb_CodEstandar;
        private System.Windows.Forms.Label lbl_fechaInicial;
        private System.Windows.Forms.Label lbl_fechafinal;
        private System.Windows.Forms.Label lbl_CodEstandar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.PictureBox picbx_titulo;
        private System.Windows.Forms.DataGridView dgv_informe;
        private System.Windows.Forms.DataGridView dgv_evaluadosresultados;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}