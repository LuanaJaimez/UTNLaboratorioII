namespace Clifton.Manuel
{
    partial class FrmListadoPadres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPadres));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPadres = new System.Windows.Forms.Panel();
            this.Lb_ListadoPadres = new System.Windows.Forms.Label();
            this.Lb_turno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbAulas = new System.Windows.Forms.ComboBox();
            this.Lb_Aula = new System.Windows.Forms.Label();
            this.dataGridResponsable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelPadres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridResponsable);
            this.panel1.Controls.Add(this.panelPadres);
            this.panel1.Location = new System.Drawing.Point(62, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 375);
            this.panel1.TabIndex = 0;
            // 
            // panelPadres
            // 
            this.panelPadres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPadres.Controls.Add(this.Lb_ListadoPadres);
            this.panelPadres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPadres.Location = new System.Drawing.Point(0, 0);
            this.panelPadres.Name = "panelPadres";
            this.panelPadres.Size = new System.Drawing.Size(651, 43);
            this.panelPadres.TabIndex = 0;
            // 
            // Lb_ListadoPadres
            // 
            this.Lb_ListadoPadres.AutoSize = true;
            this.Lb_ListadoPadres.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ListadoPadres.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_ListadoPadres.Location = new System.Drawing.Point(242, 9);
            this.Lb_ListadoPadres.Name = "Lb_ListadoPadres";
            this.Lb_ListadoPadres.Size = new System.Drawing.Size(171, 22);
            this.Lb_ListadoPadres.TabIndex = 1;
            this.Lb_ListadoPadres.Text = "Listado de Padres";
            // 
            // Lb_turno
            // 
            this.Lb_turno.AutoSize = true;
            this.Lb_turno.Enabled = false;
            this.Lb_turno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_turno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_turno.Location = new System.Drawing.Point(343, 19);
            this.Lb_turno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_turno.Name = "Lb_turno";
            this.Lb_turno.Size = new System.Drawing.Size(115, 17);
            this.Lb_turno.TabIndex = 19;
            this.Lb_turno.Text = "Seleccione Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbTurno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(466, 13);
            this.cmbTurno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(151, 28);
            this.cmbTurno.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(692, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 28);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbAulas
            // 
            this.cmbAulas.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbAulas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAulas.FormattingEnabled = true;
            this.cmbAulas.Items.AddRange(new object[] {
            "Naranja",
            "Rojo",
            "Amarillo",
            "Verde"});
            this.cmbAulas.Location = new System.Drawing.Point(148, 13);
            this.cmbAulas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAulas.Name = "cmbAulas";
            this.cmbAulas.Size = new System.Drawing.Size(154, 28);
            this.cmbAulas.TabIndex = 15;
            // 
            // Lb_Aula
            // 
            this.Lb_Aula.AutoSize = true;
            this.Lb_Aula.Enabled = false;
            this.Lb_Aula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Aula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Aula.Location = new System.Drawing.Point(30, 19);
            this.Lb_Aula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Aula.Name = "Lb_Aula";
            this.Lb_Aula.Size = new System.Drawing.Size(110, 17);
            this.Lb_Aula.TabIndex = 14;
            this.Lb_Aula.Text = "Seleccione Aula";
            // 
            // dataGridResponsable
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridResponsable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResponsable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResponsable.BackgroundColor = System.Drawing.Color.White;
            this.dataGridResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridResponsable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridResponsable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResponsable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResponsable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridResponsable.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridResponsable.EnableHeadersVisualStyles = false;
            this.dataGridResponsable.GridColor = System.Drawing.Color.White;
            this.dataGridResponsable.Location = new System.Drawing.Point(0, 34);
            this.dataGridResponsable.Name = "dataGridResponsable";
            this.dataGridResponsable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResponsable.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.dataGridResponsable.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridResponsable.Size = new System.Drawing.Size(653, 341);
            this.dataGridResponsable.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefono";
            this.Column6.Name = "Column6";
            // 
            // FrmListadoPadres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(803, 451);
            this.Controls.Add(this.Lb_turno);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbAulas);
            this.Controls.Add(this.Lb_Aula);
            this.Controls.Add(this.panel1);
            this.Name = "FrmListadoPadres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Padres por Aula";
            this.Load += new System.EventHandler(this.FrmListadoPadres_Load);
            this.panel1.ResumeLayout(false);
            this.panelPadres.ResumeLayout(false);
            this.panelPadres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResponsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPadres;
        private System.Windows.Forms.Label Lb_ListadoPadres;
        private System.Windows.Forms.Label Lb_turno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbAulas;
        private System.Windows.Forms.Label Lb_Aula;
        private System.Windows.Forms.DataGridView dataGridResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}