namespace FormularioJardin
{
    partial class AltaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAula));
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblALumnosConAula = new System.Windows.Forms.Label();
            this.lblAlumnosSinAula = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstboxAlumConAula = new System.Windows.Forms.ListBox();
            this.lstBoxAlumSinAula = new System.Windows.Forms.ListBox();
            this.lblProfeSelecionado = new System.Windows.Forms.Label();
            this.lblNombreDelProfe = new System.Windows.Forms.Label();
            this.btmPasoAAlula = new System.Windows.Forms.Button();
            this.btnPasoASinAula = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(12, 34);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(69, 17);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "ColorSala";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(206, 34);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 17);
            this.lblTurno.TabIndex = 1;
            this.lblTurno.Text = "Turno";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(374, 34);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(62, 17);
            this.lblProfesor.TabIndex = 2;
            this.lblProfesor.Text = "Profesor";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Verde"});
            this.cmbColor.Location = new System.Drawing.Point(87, 30);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(110, 21);
            this.cmbColor.TabIndex = 3;
            this.cmbColor.Text = "Seleccione color";
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(258, 30);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(110, 21);
            this.cmbTurno.TabIndex = 3;
            this.cmbTurno.Text = "Seleccione turno";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(442, 30);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(110, 21);
            this.cmbProfesor.TabIndex = 3;
            this.cmbProfesor.Text = "Seleccione Prof";
            // 
            // lblALumnosConAula
            // 
            this.lblALumnosConAula.AutoSize = true;
            this.lblALumnosConAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALumnosConAula.Location = new System.Drawing.Point(31, 112);
            this.lblALumnosConAula.Name = "lblALumnosConAula";
            this.lblALumnosConAula.Size = new System.Drawing.Size(123, 17);
            this.lblALumnosConAula.TabIndex = 5;
            this.lblALumnosConAula.Text = "Alumnos Con Aula";
            // 
            // lblAlumnosSinAula
            // 
            this.lblAlumnosSinAula.AutoSize = true;
            this.lblAlumnosSinAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosSinAula.Location = new System.Drawing.Point(320, 112);
            this.lblAlumnosSinAula.Name = "lblAlumnosSinAula";
            this.lblAlumnosSinAula.Size = new System.Drawing.Size(118, 17);
            this.lblAlumnosSinAula.TabIndex = 6;
            this.lblAlumnosSinAula.Text = "Alumnos Sin Aula";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(31, 423);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(452, 422);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstboxAlumConAula
            // 
            this.lstboxAlumConAula.FormattingEnabled = true;
            this.lstboxAlumConAula.Location = new System.Drawing.Point(34, 132);
            this.lstboxAlumConAula.Name = "lstboxAlumConAula";
            this.lstboxAlumConAula.Size = new System.Drawing.Size(163, 238);
            this.lstboxAlumConAula.TabIndex = 9;
            // 
            // lstBoxAlumSinAula
            // 
            this.lstBoxAlumSinAula.FormattingEnabled = true;
            this.lstBoxAlumSinAula.Location = new System.Drawing.Point(323, 132);
            this.lstBoxAlumSinAula.Name = "lstBoxAlumSinAula";
            this.lstBoxAlumSinAula.Size = new System.Drawing.Size(163, 238);
            this.lstBoxAlumSinAula.TabIndex = 10;
            // 
            // lblProfeSelecionado
            // 
            this.lblProfeSelecionado.AutoSize = true;
            this.lblProfeSelecionado.Location = new System.Drawing.Point(34, 81);
            this.lblProfeSelecionado.Name = "lblProfeSelecionado";
            this.lblProfeSelecionado.Size = new System.Drawing.Size(49, 13);
            this.lblProfeSelecionado.TabIndex = 11;
            this.lblProfeSelecionado.Text = "Profesor:";
            // 
            // lblNombreDelProfe
            // 
            this.lblNombreDelProfe.AutoSize = true;
            this.lblNombreDelProfe.Location = new System.Drawing.Point(90, 81);
            this.lblNombreDelProfe.Name = "lblNombreDelProfe";
            this.lblNombreDelProfe.Size = new System.Drawing.Size(0, 13);
            this.lblNombreDelProfe.TabIndex = 12;
            // 
            // btmPasoAAlula
            // 
            this.btmPasoAAlula.Location = new System.Drawing.Point(220, 188);
            this.btmPasoAAlula.Name = "btmPasoAAlula";
            this.btmPasoAAlula.Size = new System.Drawing.Size(75, 23);
            this.btmPasoAAlula.TabIndex = 13;
            this.btmPasoAAlula.Text = "<<<";
            this.btmPasoAAlula.UseVisualStyleBackColor = true;
            this.btmPasoAAlula.Click += new System.EventHandler(this.btmPasoAAlula_Click);
            // 
            // btnPasoASinAula
            // 
            this.btnPasoASinAula.Location = new System.Drawing.Point(220, 272);
            this.btnPasoASinAula.Name = "btnPasoASinAula";
            this.btnPasoASinAula.Size = new System.Drawing.Size(75, 23);
            this.btnPasoASinAula.TabIndex = 13;
            this.btnPasoASinAula.Text = ">>>";
            this.btnPasoASinAula.UseVisualStyleBackColor = true;
            this.btnPasoASinAula.Click += new System.EventHandler(this.btnPasoASinAula_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\walte\\Desktop\\Componentes Graficos Vb2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\Ma" +
    "cOS\\MacOS.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // AltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 461);
            this.Controls.Add(this.btnPasoASinAula);
            this.Controls.Add(this.btmPasoAAlula);
            this.Controls.Add(this.lblNombreDelProfe);
            this.Controls.Add(this.lblProfeSelecionado);
            this.Controls.Add(this.lstBoxAlumSinAula);
            this.Controls.Add(this.lstboxAlumConAula);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAlumnosSinAula);
            this.Controls.Add(this.lblALumnosConAula);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblColor);
            this.MaximumSize = new System.Drawing.Size(580, 500);
            this.MinimumSize = new System.Drawing.Size(580, 500);
            this.Name = "AltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaAula";
            this.Load += new System.EventHandler(this.AltaAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label lblALumnosConAula;
        private System.Windows.Forms.Label lblAlumnosSinAula;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstboxAlumConAula;
        private System.Windows.Forms.ListBox lstBoxAlumSinAula;
        private System.Windows.Forms.Label lblProfeSelecionado;
        private System.Windows.Forms.Label lblNombreDelProfe;
        private System.Windows.Forms.Button btmPasoAAlula;
        private System.Windows.Forms.Button btnPasoASinAula;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}