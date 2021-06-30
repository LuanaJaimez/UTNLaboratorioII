namespace FormularioJardin
{
    partial class FrmAltaGenerica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaGenerica));
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.cmbColorSala = new System.Windows.Forms.ComboBox();
            this.lblPrecioDeCouta = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblColorDeSala = new System.Windows.Forms.Label();
            this.lblGeneroAlumno = new System.Windows.Forms.Label();
            this.rbtfemeninoAlumno = new System.Windows.Forms.RadioButton();
            this.rbtMasculinoAlumno = new System.Windows.Forms.RadioButton();
            this.lblDniAlumno = new System.Windows.Forms.Label();
            this.lblApellidoAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.cmbPrecioCuota = new System.Windows.Forms.ComboBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHEntradaDocente = new System.Windows.Forms.Label();
            this.lblHsalidaDocente = new System.Windows.Forms.Label();
            this.cmbHoraEntrada = new System.Windows.Forms.ComboBox();
            this.cmbHSalida = new System.Windows.Forms.ComboBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(327, 394);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(95, 39);
            this.btnGuardarAlumno.TabIndex = 33;
            this.btnGuardarAlumno.Text = "Guardar";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(151, 394);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(95, 39);
            this.btnCancelarAlta.TabIndex = 32;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(164, 110);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(139, 20);
            this.txtDniAlumno.TabIndex = 2;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(164, 69);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(139, 20);
            this.txtApellidoAlumno.TabIndex = 1;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(164, 31);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(139, 20);
            this.txtNombreAlumno.TabIndex = 0;
            // 
            // cmbColorSala
            // 
            this.cmbColorSala.FormattingEnabled = true;
            this.cmbColorSala.Items.AddRange(new object[] {
            "Roja",
            "Amarilla",
            "Celeste",
            "Verde"});
            this.cmbColorSala.Location = new System.Drawing.Point(46, 259);
            this.cmbColorSala.Name = "cmbColorSala";
            this.cmbColorSala.Size = new System.Drawing.Size(121, 21);
            this.cmbColorSala.TabIndex = 5;
            // 
            // lblPrecioDeCouta
            // 
            this.lblPrecioDeCouta.AutoSize = true;
            this.lblPrecioDeCouta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDeCouta.Location = new System.Drawing.Point(43, 312);
            this.lblPrecioDeCouta.Name = "lblPrecioDeCouta";
            this.lblPrecioDeCouta.Size = new System.Drawing.Size(109, 17);
            this.lblPrecioDeCouta.TabIndex = 25;
            this.lblPrecioDeCouta.Text = "Precio de Cuota";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(200, 230);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(78, 17);
            this.lblLegajo.TabIndex = 24;
            this.lblLegajo.Text = "Nro Legajo";
            // 
            // lblColorDeSala
            // 
            this.lblColorDeSala.AutoSize = true;
            this.lblColorDeSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorDeSala.Location = new System.Drawing.Point(43, 230);
            this.lblColorDeSala.Name = "lblColorDeSala";
            this.lblColorDeSala.Size = new System.Drawing.Size(93, 17);
            this.lblColorDeSala.TabIndex = 23;
            this.lblColorDeSala.Text = "Color de Sala";
            // 
            // lblGeneroAlumno
            // 
            this.lblGeneroAlumno.AutoSize = true;
            this.lblGeneroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroAlumno.Location = new System.Drawing.Point(43, 161);
            this.lblGeneroAlumno.Name = "lblGeneroAlumno";
            this.lblGeneroAlumno.Size = new System.Drawing.Size(56, 17);
            this.lblGeneroAlumno.TabIndex = 22;
            this.lblGeneroAlumno.Text = "Genero";
            // 
            // rbtfemeninoAlumno
            // 
            this.rbtfemeninoAlumno.AutoSize = true;
            this.rbtfemeninoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtfemeninoAlumno.Location = new System.Drawing.Point(151, 192);
            this.rbtfemeninoAlumno.Name = "rbtfemeninoAlumno";
            this.rbtfemeninoAlumno.Size = new System.Drawing.Size(81, 19);
            this.rbtfemeninoAlumno.TabIndex = 4;
            this.rbtfemeninoAlumno.TabStop = true;
            this.rbtfemeninoAlumno.Text = "Femenino";
            this.rbtfemeninoAlumno.UseVisualStyleBackColor = true;
            // 
            // rbtMasculinoAlumno
            // 
            this.rbtMasculinoAlumno.AutoSize = true;
            this.rbtMasculinoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculinoAlumno.Location = new System.Drawing.Point(46, 192);
            this.rbtMasculinoAlumno.Name = "rbtMasculinoAlumno";
            this.rbtMasculinoAlumno.Size = new System.Drawing.Size(82, 19);
            this.rbtMasculinoAlumno.TabIndex = 3;
            this.rbtMasculinoAlumno.TabStop = true;
            this.rbtMasculinoAlumno.Text = "Masculino";
            this.rbtMasculinoAlumno.UseVisualStyleBackColor = true;
            // 
            // lblDniAlumno
            // 
            this.lblDniAlumno.AutoSize = true;
            this.lblDniAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniAlumno.Location = new System.Drawing.Point(43, 110);
            this.lblDniAlumno.Name = "lblDniAlumno";
            this.lblDniAlumno.Size = new System.Drawing.Size(29, 17);
            this.lblDniAlumno.TabIndex = 19;
            this.lblDniAlumno.Text = "Dni";
            // 
            // lblApellidoAlumno
            // 
            this.lblApellidoAlumno.AutoSize = true;
            this.lblApellidoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoAlumno.Location = new System.Drawing.Point(43, 69);
            this.lblApellidoAlumno.Name = "lblApellidoAlumno";
            this.lblApellidoAlumno.Size = new System.Drawing.Size(58, 17);
            this.lblApellidoAlumno.TabIndex = 18;
            this.lblApellidoAlumno.Text = "Apellido";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.Location = new System.Drawing.Point(43, 31);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(58, 17);
            this.lblNombreAlumno.TabIndex = 17;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(203, 260);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 6;
            // 
            // cmbPrecioCuota
            // 
            this.cmbPrecioCuota.FormattingEnabled = true;
            this.cmbPrecioCuota.Items.AddRange(new object[] {
            "2500",
            "3000",
            "3500"});
            this.cmbPrecioCuota.Location = new System.Drawing.Point(46, 341);
            this.cmbPrecioCuota.Name = "cmbPrecioCuota";
            this.cmbPrecioCuota.Size = new System.Drawing.Size(121, 21);
            this.cmbPrecioCuota.TabIndex = 8;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(355, 260);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(100, 20);
            this.txtResponsable.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Responsable";
            // 
            // lblHEntradaDocente
            // 
            this.lblHEntradaDocente.AutoSize = true;
            this.lblHEntradaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEntradaDocente.Location = new System.Drawing.Point(198, 312);
            this.lblHEntradaDocente.Name = "lblHEntradaDocente";
            this.lblHEntradaDocente.Size = new System.Drawing.Size(129, 17);
            this.lblHEntradaDocente.TabIndex = 6;
            this.lblHEntradaDocente.Text = "Horario de Entrada";
            // 
            // lblHsalidaDocente
            // 
            this.lblHsalidaDocente.AutoSize = true;
            this.lblHsalidaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsalidaDocente.Location = new System.Drawing.Point(352, 312);
            this.lblHsalidaDocente.Name = "lblHsalidaDocente";
            this.lblHsalidaDocente.Size = new System.Drawing.Size(118, 17);
            this.lblHsalidaDocente.TabIndex = 7;
            this.lblHsalidaDocente.Text = "Horario de Salida";
            // 
            // cmbHoraEntrada
            // 
            this.cmbHoraEntrada.FormattingEnabled = true;
            this.cmbHoraEntrada.Items.AddRange(new object[] {
            "08:00",
            "13:00"});
            this.cmbHoraEntrada.Location = new System.Drawing.Point(201, 341);
            this.cmbHoraEntrada.Name = "cmbHoraEntrada";
            this.cmbHoraEntrada.Size = new System.Drawing.Size(114, 21);
            this.cmbHoraEntrada.TabIndex = 9;
            // 
            // cmbHSalida
            // 
            this.cmbHSalida.FormattingEnabled = true;
            this.cmbHSalida.Items.AddRange(new object[] {
            "13:00",
            "18:00"});
            this.cmbHSalida.Location = new System.Drawing.Point(355, 341);
            this.cmbHSalida.Name = "cmbHSalida";
            this.cmbHSalida.Size = new System.Drawing.Size(114, 21);
            this.cmbHSalida.TabIndex = 10;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\walte\\Desktop\\Componentes Graficos Vb2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\Ma" +
    "cOS\\MacOS.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // FrmAltaGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.cmbPrecioCuota);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.cmbHSalida);
            this.Controls.Add(this.txtDniAlumno);
            this.Controls.Add(this.cmbHoraEntrada);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.lblHsalidaDocente);
            this.Controls.Add(this.cmbColorSala);
            this.Controls.Add(this.lblHEntradaDocente);
            this.Controls.Add(this.lblPrecioDeCouta);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblColorDeSala);
            this.Controls.Add(this.lblGeneroAlumno);
            this.Controls.Add(this.rbtfemeninoAlumno);
            this.Controls.Add(this.rbtMasculinoAlumno);
            this.Controls.Add(this.lblDniAlumno);
            this.Controls.Add(this.lblApellidoAlumno);
            this.Controls.Add(this.lblNombreAlumno);
            this.MaximumSize = new System.Drawing.Size(580, 500);
            this.MinimumSize = new System.Drawing.Size(580, 500);
            this.Name = "FrmAltaGenerica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Alumno";
            this.Load += new System.EventHandler(this.AltaAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.ComboBox cmbColorSala;
        private System.Windows.Forms.Label lblPrecioDeCouta;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblColorDeSala;
        private System.Windows.Forms.Label lblGeneroAlumno;
        private System.Windows.Forms.RadioButton rbtfemeninoAlumno;
        private System.Windows.Forms.RadioButton rbtMasculinoAlumno;
        private System.Windows.Forms.Label lblDniAlumno;
        private System.Windows.Forms.Label lblApellidoAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.ComboBox cmbPrecioCuota;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHEntradaDocente;
        private System.Windows.Forms.Label lblHsalidaDocente;
        private System.Windows.Forms.ComboBox cmbHoraEntrada;
        private System.Windows.Forms.ComboBox cmbHSalida;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}