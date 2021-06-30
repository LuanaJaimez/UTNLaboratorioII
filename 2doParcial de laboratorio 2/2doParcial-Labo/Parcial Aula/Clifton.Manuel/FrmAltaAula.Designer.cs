namespace Clifton.Manuel
{
    partial class FrmAltaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaAula));
            this.Lb_Color = new System.Windows.Forms.Label();
            this.Lb_Docente = new System.Windows.Forms.Label();
            this.Lb_Turno = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.cmbDocetes = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.panelAltaAula = new System.Windows.Forms.Panel();
            this.Lb_FormAlta = new System.Windows.Forms.Label();
            this.pictureSalir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lb_AlumnosEnSala = new System.Windows.Forms.Label();
            this.listAlumnosEnSala = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lb_AlumnosSinAula = new System.Windows.Forms.Label();
            this.listAlumnosSinSala = new System.Windows.Forms.ListBox();
            this.btnAceptarAula = new System.Windows.Forms.Button();
            this.panelAltaAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Color
            // 
            this.Lb_Color.AutoSize = true;
            this.Lb_Color.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Color.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Color.Location = new System.Drawing.Point(44, 78);
            this.Lb_Color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Color.Name = "Lb_Color";
            this.Lb_Color.Size = new System.Drawing.Size(44, 17);
            this.Lb_Color.TabIndex = 0;
            this.Lb_Color.Text = "Color";
            // 
            // Lb_Docente
            // 
            this.Lb_Docente.AutoSize = true;
            this.Lb_Docente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Docente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Docente.Location = new System.Drawing.Point(653, 78);
            this.Lb_Docente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Docente.Name = "Lb_Docente";
            this.Lb_Docente.Size = new System.Drawing.Size(64, 17);
            this.Lb_Docente.TabIndex = 1;
            this.Lb_Docente.Text = "Docente";
            // 
            // Lb_Turno
            // 
            this.Lb_Turno.AutoSize = true;
            this.Lb_Turno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Turno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Turno.Location = new System.Drawing.Point(365, 78);
            this.Lb_Turno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Turno.Name = "Lb_Turno";
            this.Lb_Turno.Size = new System.Drawing.Size(42, 17);
            this.Lb_Turno.TabIndex = 2;
            this.Lb_Turno.Text = "Turno";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(58, 467);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(919, 467);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 43);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar / Editar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbColores
            // 
            this.cmbColores.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbColores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Items.AddRange(new object[] {
            "Naranja",
            "Rojo",
            "Amarillo",
            "Verde"});
            this.cmbColores.Location = new System.Drawing.Point(96, 72);
            this.cmbColores.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(199, 28);
            this.cmbColores.TabIndex = 6;
            this.cmbColores.SelectedIndexChanged += new System.EventHandler(this.cmbColores_SelectedIndexChanged);
            // 
            // cmbDocetes
            // 
            this.cmbDocetes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbDocetes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocetes.FormattingEnabled = true;
            this.cmbDocetes.Location = new System.Drawing.Point(735, 72);
            this.cmbDocetes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDocetes.Name = "cmbDocetes";
            this.cmbDocetes.Size = new System.Drawing.Size(199, 28);
            this.cmbDocetes.TabIndex = 7;
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbTurno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(415, 72);
            this.cmbTurno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(199, 28);
            this.cmbTurno.TabIndex = 8;
            // 
            // panelAltaAula
            // 
            this.panelAltaAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelAltaAula.Controls.Add(this.Lb_FormAlta);
            this.panelAltaAula.Controls.Add(this.pictureSalir);
            this.panelAltaAula.Location = new System.Drawing.Point(0, 0);
            this.panelAltaAula.Margin = new System.Windows.Forms.Padding(4);
            this.panelAltaAula.Name = "panelAltaAula";
            this.panelAltaAula.Size = new System.Drawing.Size(1082, 48);
            this.panelAltaAula.TabIndex = 9;
            // 
            // Lb_FormAlta
            // 
            this.Lb_FormAlta.AutoSize = true;
            this.Lb_FormAlta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FormAlta.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_FormAlta.Location = new System.Drawing.Point(411, 9);
            this.Lb_FormAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_FormAlta.Name = "Lb_FormAlta";
            this.Lb_FormAlta.Size = new System.Drawing.Size(147, 21);
            this.Lb_FormAlta.TabIndex = 1;
            this.Lb_FormAlta.Text = "Alta/Editar - Aula";
            this.Lb_FormAlta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureSalir
            // 
            this.pictureSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureSalir.Image")));
            this.pictureSalir.Location = new System.Drawing.Point(1004, 4);
            this.pictureSalir.Margin = new System.Windows.Forms.Padding(4);
            this.pictureSalir.Name = "pictureSalir";
            this.pictureSalir.Size = new System.Drawing.Size(64, 41);
            this.pictureSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSalir.TabIndex = 0;
            this.pictureSalir.TabStop = false;
            this.pictureSalir.Click += new System.EventHandler(this.pictureSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listAlumnosEnSala);
            this.panel1.Location = new System.Drawing.Point(28, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 327);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.Lb_AlumnosEnSala);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 16);
            this.panel2.TabIndex = 1;
            // 
            // Lb_AlumnosEnSala
            // 
            this.Lb_AlumnosEnSala.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_AlumnosEnSala.Location = new System.Drawing.Point(103, 0);
            this.Lb_AlumnosEnSala.Name = "Lb_AlumnosEnSala";
            this.Lb_AlumnosEnSala.Size = new System.Drawing.Size(197, 13);
            this.Lb_AlumnosEnSala.TabIndex = 0;
            this.Lb_AlumnosEnSala.Text = "Alumnos en Sala";
            this.Lb_AlumnosEnSala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listAlumnosEnSala
            // 
            this.listAlumnosEnSala.AllowDrop = true;
            this.listAlumnosEnSala.FormattingEnabled = true;
            this.listAlumnosEnSala.ItemHeight = 17;
            this.listAlumnosEnSala.Location = new System.Drawing.Point(-1, 16);
            this.listAlumnosEnSala.Name = "listAlumnosEnSala";
            this.listAlumnosEnSala.Size = new System.Drawing.Size(423, 310);
            this.listAlumnosEnSala.TabIndex = 0;
            this.listAlumnosEnSala.DragEnter += new System.Windows.Forms.DragEventHandler(this.listAlumnosEnSala_DragEnter);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.listAlumnosSinSala);
            this.panel3.Location = new System.Drawing.Point(496, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 327);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel4.Controls.Add(this.Lb_AlumnosSinAula);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(421, 16);
            this.panel4.TabIndex = 1;
            // 
            // Lb_AlumnosSinAula
            // 
            this.Lb_AlumnosSinAula.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_AlumnosSinAula.Location = new System.Drawing.Point(103, 0);
            this.Lb_AlumnosSinAula.Name = "Lb_AlumnosSinAula";
            this.Lb_AlumnosSinAula.Size = new System.Drawing.Size(197, 13);
            this.Lb_AlumnosSinAula.TabIndex = 0;
            this.Lb_AlumnosSinAula.Text = "Alumnos Sin Sala";
            this.Lb_AlumnosSinAula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listAlumnosSinSala
            // 
            this.listAlumnosSinSala.AllowDrop = true;
            this.listAlumnosSinSala.FormattingEnabled = true;
            this.listAlumnosSinSala.ItemHeight = 17;
            this.listAlumnosSinSala.Location = new System.Drawing.Point(-2, 15);
            this.listAlumnosSinSala.Name = "listAlumnosSinSala";
            this.listAlumnosSinSala.Size = new System.Drawing.Size(423, 310);
            this.listAlumnosSinSala.TabIndex = 0;
            this.listAlumnosSinSala.DragDrop += new System.Windows.Forms.DragEventHandler(this.listAlumnosSinSala_DragDrop);
            this.listAlumnosSinSala.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listAlumnosSinSala_MouseDown);
            // 
            // btnAceptarAula
            // 
            this.btnAceptarAula.Location = new System.Drawing.Point(970, 75);
            this.btnAceptarAula.Name = "btnAceptarAula";
            this.btnAceptarAula.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAula.TabIndex = 12;
            this.btnAceptarAula.Text = "Aceptar";
            this.btnAceptarAula.UseVisualStyleBackColor = true;
            this.btnAceptarAula.Click += new System.EventHandler(this.btnAceptarAula_Click);
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1081, 533);
            this.Controls.Add(this.btnAceptarAula);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lb_Docente);
            this.Controls.Add(this.panelAltaAula);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbDocetes);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.Lb_Turno);
            this.Controls.Add(this.Lb_Color);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Aula";
            this.Load += new System.EventHandler(this.FrmAltaAula_Load);
            this.panelAltaAula.ResumeLayout(false);
            this.panelAltaAula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Color;
        private System.Windows.Forms.Label Lb_Docente;
        private System.Windows.Forms.Label Lb_Turno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.ComboBox cmbDocetes;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Panel panelAltaAula;
        private System.Windows.Forms.Label Lb_FormAlta;
        private System.Windows.Forms.PictureBox pictureSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lb_AlumnosEnSala;
        private System.Windows.Forms.ListBox listAlumnosEnSala;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lb_AlumnosSinAula;
        private System.Windows.Forms.ListBox listAlumnosSinSala;
        private System.Windows.Forms.Button btnAceptarAula;
    }
}