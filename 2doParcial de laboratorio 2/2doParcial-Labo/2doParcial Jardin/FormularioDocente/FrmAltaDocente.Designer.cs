namespace FormularioDocente
{
    partial class FrmSerializable
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerializable));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.btnArchivoTexto = new System.Windows.Forms.Button();
            this.btnAgregarBD = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deserializarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLLamaAlumnos = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(149, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(149, 92);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(149, 118);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(149, 145);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(149, 199);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 226);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(13, 47);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 10;
            this.lblnombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(13, 99);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(13, 124);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "Dni";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(13, 152);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(13, 206);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(12, 273);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(110, 47);
            this.btnAgregarDocente.TabIndex = 18;
            this.btnAgregarDocente.Text = "Agregar Docente";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // btnArchivoTexto
            // 
            this.btnArchivoTexto.Location = new System.Drawing.Point(137, 273);
            this.btnArchivoTexto.Name = "btnArchivoTexto";
            this.btnArchivoTexto.Size = new System.Drawing.Size(113, 47);
            this.btnArchivoTexto.TabIndex = 24;
            this.btnArchivoTexto.Text = "Archivo de Texto";
            this.btnArchivoTexto.UseVisualStyleBackColor = true;
            this.btnArchivoTexto.Click += new System.EventHandler(this.btnGuardarArchivoTexto_Click);
            // 
            // btnAgregarBD
            // 
            this.btnAgregarBD.Location = new System.Drawing.Point(12, 335);
            this.btnAgregarBD.Name = "btnAgregarBD";
            this.btnAgregarBD.Size = new System.Drawing.Size(105, 47);
            this.btnAgregarBD.TabIndex = 26;
            this.btnAgregarBD.Text = "Agregar a Base de Datos";
            this.btnAgregarBD.UseVisualStyleBackColor = true;
            this.btnAgregarBD.Click += new System.EventHandler(this.btnAgregarBD_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(472, 35);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 25);
            this.lblTiempo.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deserializarAlumnosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deserializarAlumnosToolStripMenuItem
            // 
            this.deserializarAlumnosToolStripMenuItem.Name = "deserializarAlumnosToolStripMenuItem";
            this.deserializarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.deserializarAlumnosToolStripMenuItem.Text = "DeserializarAlumnos";
            this.deserializarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.deserializarAlumnosToolStripMenuItem_Click);
            // 
            // btnLLamaAlumnos
            // 
            this.btnLLamaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLLamaAlumnos.Location = new System.Drawing.Point(137, 335);
            this.btnLLamaAlumnos.Name = "btnLLamaAlumnos";
            this.btnLLamaAlumnos.Size = new System.Drawing.Size(112, 47);
            this.btnLLamaAlumnos.TabIndex = 29;
            this.btnLLamaAlumnos.Text = "Evaluar Alumnos";
            this.btnLLamaAlumnos.UseVisualStyleBackColor = true;
            this.btnLLamaAlumnos.Click += new System.EventHandler(this.btnLLamaAlumnos_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\frann\\Desktop\\Componentes Graficos Vb2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\MS" +
    "N\\MSN.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 179);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 172);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            // 
            // FrmSerializable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 462);
            this.Controls.Add(this.btnLLamaAlumnos);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnAgregarBD);
            this.Controls.Add(this.btnArchivoTexto);
            this.Controls.Add(this.btnAgregarDocente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSerializable";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmSerializable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.Button btnArchivoTexto;
        private System.Windows.Forms.Button btnAgregarBD;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deserializarAlumnosToolStripMenuItem;
        private System.Windows.Forms.Button btnLLamaAlumnos;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
    }
}

