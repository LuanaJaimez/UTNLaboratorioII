namespace Clifton.Manuel
{
    partial class FrmAlumnosPorAula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlumnosPorAula));
            this.panelData = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lb_ProfesorACargo = new System.Windows.Forms.Label();
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lb_Aula = new System.Windows.Forms.Label();
            this.cmbAulas = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.Lb_RecaudacionPorAula = new System.Windows.Forms.Label();
            this.Lb_turno = new System.Windows.Forms.Label();
            this.panelData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.Controls.Add(this.panel1);
            this.panelData.Controls.Add(this.dataGridAlumnos);
            this.panelData.Location = new System.Drawing.Point(81, 54);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(639, 342);
            this.panelData.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 38);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.Lb_ProfesorACargo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.panel2.Size = new System.Drawing.Size(639, 38);
            this.panel2.TabIndex = 23;
            // 
            // Lb_ProfesorACargo
            // 
            this.Lb_ProfesorACargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_ProfesorACargo.AutoSize = true;
            this.Lb_ProfesorACargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ProfesorACargo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_ProfesorACargo.Location = new System.Drawing.Point(185, 11);
            this.Lb_ProfesorACargo.Name = "Lb_ProfesorACargo";
            this.Lb_ProfesorACargo.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.Lb_ProfesorACargo.Size = new System.Drawing.Size(15, 21);
            this.Lb_ProfesorACargo.TabIndex = 0;
            // 
            // dataGridAlumnos
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAlumnos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridAlumnos.EnableHeadersVisualStyles = false;
            this.dataGridAlumnos.GridColor = System.Drawing.Color.White;
            this.dataGridAlumnos.Location = new System.Drawing.Point(0, 35);
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.dataGridAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridAlumnos.Size = new System.Drawing.Size(639, 307);
            this.dataGridAlumnos.TabIndex = 0;
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
            // Column3
            // 
            this.Column3.HeaderText = "DNI";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sexo";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cuota";
            this.Column7.Name = "Column7";
            // 
            // Lb_Aula
            // 
            this.Lb_Aula.AutoSize = true;
            this.Lb_Aula.Enabled = false;
            this.Lb_Aula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Aula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Aula.Location = new System.Drawing.Point(55, 9);
            this.Lb_Aula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Aula.Name = "Lb_Aula";
            this.Lb_Aula.Size = new System.Drawing.Size(110, 17);
            this.Lb_Aula.TabIndex = 6;
            this.Lb_Aula.Text = "Seleccione Aula";
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
            this.cmbAulas.Location = new System.Drawing.Point(173, 3);
            this.cmbAulas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAulas.Name = "cmbAulas";
            this.cmbAulas.Size = new System.Drawing.Size(154, 28);
            this.cmbAulas.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(717, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 28);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(717, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbTurno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cmbTurno.Location = new System.Drawing.Point(491, 3);
            this.cmbTurno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(151, 28);
            this.cmbTurno.TabIndex = 11;
            // 
            // Lb_RecaudacionPorAula
            // 
            this.Lb_RecaudacionPorAula.AutoSize = true;
            this.Lb_RecaudacionPorAula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_RecaudacionPorAula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_RecaudacionPorAula.Location = new System.Drawing.Point(116, 420);
            this.Lb_RecaudacionPorAula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_RecaudacionPorAula.Name = "Lb_RecaudacionPorAula";
            this.Lb_RecaudacionPorAula.Size = new System.Drawing.Size(124, 21);
            this.Lb_RecaudacionPorAula.TabIndex = 12;
            this.Lb_RecaudacionPorAula.Text = "Recaudación: ";
            // 
            // Lb_turno
            // 
            this.Lb_turno.AutoSize = true;
            this.Lb_turno.Enabled = false;
            this.Lb_turno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_turno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_turno.Location = new System.Drawing.Point(368, 9);
            this.Lb_turno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_turno.Name = "Lb_turno";
            this.Lb_turno.Size = new System.Drawing.Size(115, 17);
            this.Lb_turno.TabIndex = 13;
            this.Lb_turno.Text = "Seleccione Turno";
            // 
            // FrmAlumnosPorAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lb_turno);
            this.Controls.Add(this.Lb_RecaudacionPorAula);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbAulas);
            this.Controls.Add(this.Lb_Aula);
            this.Controls.Add(this.panelData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAlumnosPorAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos por Aula Seleccionada";
            this.Load += new System.EventHandler(this.FrmAlumnosPorAula_Load);
            this.panelData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lb_ProfesorACargo;
        private System.Windows.Forms.Label Lb_Aula;
        private System.Windows.Forms.ComboBox cmbAulas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label Lb_RecaudacionPorAula;
        private System.Windows.Forms.Label Lb_turno;
    }
}