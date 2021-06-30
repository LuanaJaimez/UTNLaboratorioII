namespace Clifton.Manuel
{
    partial class FrmAltaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaAlumno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_TipoDeAlta = new System.Windows.Forms.Label();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.Lb_Apellido = new System.Windows.Forms.Label();
            this.Lb_Dni = new System.Windows.Forms.Label();
            this.Lb_Sexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.panelListaResponsables = new System.Windows.Forms.Panel();
            this.listBoxResponsables = new System.Windows.Forms.ListBox();
            this.panelNombreLista = new System.Windows.Forms.Panel();
            this.Lb_ListaResponsables = new System.Windows.Forms.Label();
            this.Lb_precio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.panelListaResponsables.SuspendLayout();
            this.panelNombreLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lb_TipoDeAlta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 40);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(959, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lb_TipoDeAlta
            // 
            this.Lb_TipoDeAlta.AutoSize = true;
            this.Lb_TipoDeAlta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TipoDeAlta.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_TipoDeAlta.Location = new System.Drawing.Point(381, 9);
            this.Lb_TipoDeAlta.Name = "Lb_TipoDeAlta";
            this.Lb_TipoDeAlta.Size = new System.Drawing.Size(134, 21);
            this.Lb_TipoDeAlta.TabIndex = 0;
            this.Lb_TipoDeAlta.Text = "Alta de Alumno";
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Nombre.Location = new System.Drawing.Point(57, 38);
            this.Lb_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(61, 17);
            this.Lb_Nombre.TabIndex = 0;
            this.Lb_Nombre.Text = "Nombre";
            // 
            // Lb_Apellido
            // 
            this.Lb_Apellido.AutoSize = true;
            this.Lb_Apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Apellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Apellido.Location = new System.Drawing.Point(57, 86);
            this.Lb_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Apellido.Name = "Lb_Apellido";
            this.Lb_Apellido.Size = new System.Drawing.Size(61, 17);
            this.Lb_Apellido.TabIndex = 1;
            this.Lb_Apellido.Text = "Apellido";
            // 
            // Lb_Dni
            // 
            this.Lb_Dni.AutoSize = true;
            this.Lb_Dni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Dni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Dni.Location = new System.Drawing.Point(64, 139);
            this.Lb_Dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Dni.Name = "Lb_Dni";
            this.Lb_Dni.Size = new System.Drawing.Size(31, 17);
            this.Lb_Dni.TabIndex = 2;
            this.Lb_Dni.Text = "DNI";
            // 
            // Lb_Sexo
            // 
            this.Lb_Sexo.AutoSize = true;
            this.Lb_Sexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Sexo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Sexo.Location = new System.Drawing.Point(64, 190);
            this.Lb_Sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Sexo.Name = "Lb_Sexo";
            this.Lb_Sexo.Size = new System.Drawing.Size(37, 17);
            this.Lb_Sexo.TabIndex = 3;
            this.Lb_Sexo.Text = "Sexo";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombre.Location = new System.Drawing.Point(157, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(368, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtApellido.Location = new System.Drawing.Point(157, 83);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(368, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(568, 376);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(214, 58);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(289, 377);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 57);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDni.Location = new System.Drawing.Point(157, 136);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(368, 20);
            this.txtDni.TabIndex = 3;
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(157, 186);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(368, 21);
            this.cmbSexo.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numPrecio);
            this.panel2.Controls.Add(this.panelListaResponsables);
            this.panel2.Controls.Add(this.Lb_precio);
            this.panel2.Controls.Add(this.cmbSexo);
            this.panel2.Controls.Add(this.txtDni);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.Lb_Sexo);
            this.panel2.Controls.Add(this.Lb_Dni);
            this.panel2.Controls.Add(this.Lb_Apellido);
            this.panel2.Controls.Add(this.Lb_Nombre);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 446);
            this.panel2.TabIndex = 33;
            // 
            // numPrecio
            // 
            this.numPrecio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.numPrecio.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPrecio.Location = new System.Drawing.Point(157, 246);
            this.numPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(368, 20);
            this.numPrecio.TabIndex = 5;
            this.numPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelListaResponsables
            // 
            this.panelListaResponsables.Controls.Add(this.listBoxResponsables);
            this.panelListaResponsables.Controls.Add(this.panelNombreLista);
            this.panelListaResponsables.Location = new System.Drawing.Point(601, 30);
            this.panelListaResponsables.Name = "panelListaResponsables";
            this.panelListaResponsables.Size = new System.Drawing.Size(341, 290);
            this.panelListaResponsables.TabIndex = 24;
            // 
            // listBoxResponsables
            // 
            this.listBoxResponsables.FormattingEnabled = true;
            this.listBoxResponsables.Location = new System.Drawing.Point(0, 26);
            this.listBoxResponsables.Name = "listBoxResponsables";
            this.listBoxResponsables.Size = new System.Drawing.Size(341, 264);
            this.listBoxResponsables.TabIndex = 6;
            // 
            // panelNombreLista
            // 
            this.panelNombreLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelNombreLista.Controls.Add(this.Lb_ListaResponsables);
            this.panelNombreLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNombreLista.Location = new System.Drawing.Point(0, 0);
            this.panelNombreLista.Name = "panelNombreLista";
            this.panelNombreLista.Size = new System.Drawing.Size(341, 25);
            this.panelNombreLista.TabIndex = 0;
            // 
            // Lb_ListaResponsables
            // 
            this.Lb_ListaResponsables.AutoSize = true;
            this.Lb_ListaResponsables.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ListaResponsables.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_ListaResponsables.Location = new System.Drawing.Point(63, 2);
            this.Lb_ListaResponsables.Name = "Lb_ListaResponsables";
            this.Lb_ListaResponsables.Size = new System.Drawing.Size(226, 21);
            this.Lb_ListaResponsables.TabIndex = 1;
            this.Lb_ListaResponsables.Text = "Seleccionar un Responsable";
            // 
            // Lb_precio
            // 
            this.Lb_precio.AutoSize = true;
            this.Lb_precio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_precio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_precio.Location = new System.Drawing.Point(70, 246);
            this.Lb_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_precio.Name = "Lb_precio";
            this.Lb_precio.Size = new System.Drawing.Size(48, 17);
            this.Lb_precio.TabIndex = 22;
            this.Lb_precio.Text = "Precio";
            // 
            // FrmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1008, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaAlumno";
            this.Load += new System.EventHandler(this.FrmAltaAlumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.panelListaResponsables.ResumeLayout(false);
            this.panelNombreLista.ResumeLayout(false);
            this.panelNombreLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_TipoDeAlta;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Label Lb_Apellido;
        private System.Windows.Forms.Label Lb_Dni;
        private System.Windows.Forms.Label Lb_Sexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lb_precio;
        private System.Windows.Forms.Panel panelListaResponsables;
        private System.Windows.Forms.ListBox listBoxResponsables;
        private System.Windows.Forms.Panel panelNombreLista;
        private System.Windows.Forms.Label Lb_ListaResponsables;
        private System.Windows.Forms.NumericUpDown numPrecio;
    }
}