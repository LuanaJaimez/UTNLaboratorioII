namespace Clifton.Manuel
{
    partial class FrmEditarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_Editar = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.La_CAMBIAR = new System.Windows.Forms.Label();
            this.Lb_Responsable1 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.Lb_importe = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lb_Responsable2 = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarAlumno = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Lb_Dni = new System.Windows.Forms.Label();
            this.Lb_Apellido = new System.Windows.Forms.Label();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lb_Editar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 40);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1110, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lb_Editar
            // 
            this.Lb_Editar.AutoSize = true;
            this.Lb_Editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Editar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_Editar.Location = new System.Drawing.Point(476, 9);
            this.Lb_Editar.Name = "Lb_Editar";
            this.Lb_Editar.Size = new System.Drawing.Size(172, 21);
            this.Lb_Editar.TabIndex = 0;
            this.Lb_Editar.Text = "Tipo de Modificación";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.panel.Controls.Add(this.La_CAMBIAR);
            this.panel.Controls.Add(this.Lb_Responsable1);
            this.panel.Controls.Add(this.txtResponsable);
            this.panel.Controls.Add(this.txtImporte);
            this.panel.Controls.Add(this.Lb_importe);
            this.panel.Controls.Add(this.panelData);
            this.panel.Controls.Add(this.Lb_Responsable2);
            this.panel.Controls.Add(this.cmbResponsable);
            this.panel.Controls.Add(this.txtDni);
            this.panel.Controls.Add(this.btnCancelar);
            this.panel.Controls.Add(this.btnEditarAlumno);
            this.panel.Controls.Add(this.txtApellido);
            this.panel.Controls.Add(this.txtNombre);
            this.panel.Controls.Add(this.Lb_Dni);
            this.panel.Controls.Add(this.Lb_Apellido);
            this.panel.Controls.Add(this.Lb_Nombre);
            this.panel.Location = new System.Drawing.Point(0, 42);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1170, 348);
            this.panel.TabIndex = 35;
            // 
            // La_CAMBIAR
            // 
            this.La_CAMBIAR.AutoSize = true;
            this.La_CAMBIAR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.La_CAMBIAR.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.La_CAMBIAR.Location = new System.Drawing.Point(20, 223);
            this.La_CAMBIAR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.La_CAMBIAR.Name = "La_CAMBIAR";
            this.La_CAMBIAR.Size = new System.Drawing.Size(66, 17);
            this.La_CAMBIAR.TabIndex = 18;
            this.La_CAMBIAR.Text = "Cambiar";
            // 
            // Lb_Responsable1
            // 
            this.Lb_Responsable1.AutoSize = true;
            this.Lb_Responsable1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Responsable1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Responsable1.Location = new System.Drawing.Point(10, 178);
            this.Lb_Responsable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Responsable1.Name = "Lb_Responsable1";
            this.Lb_Responsable1.Size = new System.Drawing.Size(89, 17);
            this.Lb_Responsable1.TabIndex = 17;
            this.Lb_Responsable1.Text = "Responsable";
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtResponsable.Location = new System.Drawing.Point(112, 175);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(296, 20);
            this.txtResponsable.TabIndex = 16;
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtImporte.Location = new System.Drawing.Point(112, 135);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(296, 20);
            this.txtImporte.TabIndex = 13;
            // 
            // Lb_importe
            // 
            this.Lb_importe.AutoSize = true;
            this.Lb_importe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_importe.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_importe.Location = new System.Drawing.Point(13, 138);
            this.Lb_importe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_importe.Name = "Lb_importe";
            this.Lb_importe.Size = new System.Drawing.Size(59, 17);
            this.Lb_importe.TabIndex = 12;
            this.Lb_importe.Text = "Importe";
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.dataGridAlumnos);
            this.panelData.Location = new System.Drawing.Point(441, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(719, 332);
            this.panelData.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(249, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alumnos";
            // 
            // dataGridAlumnos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridAlumnos.EnableHeadersVisualStyles = false;
            this.dataGridAlumnos.GridColor = System.Drawing.Color.White;
            this.dataGridAlumnos.Location = new System.Drawing.Point(3, 20);
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.dataGridAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridAlumnos.Size = new System.Drawing.Size(713, 309);
            this.dataGridAlumnos.TabIndex = 0;
            this.dataGridAlumnos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridAlumnos_RowHeaderMouseClick);
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
            // Column5
            // 
            this.Column5.HeaderText = "Salita";
            this.Column5.Name = "Column5";
            // 
            // Lb_Responsable2
            // 
            this.Lb_Responsable2.AutoSize = true;
            this.Lb_Responsable2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Responsable2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Responsable2.Location = new System.Drawing.Point(10, 240);
            this.Lb_Responsable2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Responsable2.Name = "Lb_Responsable2";
            this.Lb_Responsable2.Size = new System.Drawing.Size(89, 17);
            this.Lb_Responsable2.TabIndex = 10;
            this.Lb_Responsable2.Text = "Responsable";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(112, 224);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(296, 21);
            this.cmbResponsable.TabIndex = 9;
            this.cmbResponsable.SelectedIndexChanged += new System.EventHandler(this.cmbResponsable_SelectedIndexChanged);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDni.Location = new System.Drawing.Point(112, 94);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(296, 20);
            this.txtDni.TabIndex = 3;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(25, 284);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditarAlumno
            // 
            this.btnEditarAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarAlumno.Location = new System.Drawing.Point(232, 284);
            this.btnEditarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarAlumno.Name = "btnEditarAlumno";
            this.btnEditarAlumno.Size = new System.Drawing.Size(187, 42);
            this.btnEditarAlumno.TabIndex = 7;
            this.btnEditarAlumno.Text = "Editar Alumno";
            this.btnEditarAlumno.UseVisualStyleBackColor = true;
            this.btnEditarAlumno.Click += new System.EventHandler(this.btnEditarAlumno_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtApellido.Location = new System.Drawing.Point(112, 54);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(296, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombre.Location = new System.Drawing.Point(112, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // Lb_Dni
            // 
            this.Lb_Dni.AutoSize = true;
            this.Lb_Dni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Dni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Dni.Location = new System.Drawing.Point(20, 97);
            this.Lb_Dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Dni.Name = "Lb_Dni";
            this.Lb_Dni.Size = new System.Drawing.Size(31, 17);
            this.Lb_Dni.TabIndex = 2;
            this.Lb_Dni.Text = "DNI";
            // 
            // Lb_Apellido
            // 
            this.Lb_Apellido.AutoSize = true;
            this.Lb_Apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Apellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Apellido.Location = new System.Drawing.Point(10, 54);
            this.Lb_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Apellido.Name = "Lb_Apellido";
            this.Lb_Apellido.Size = new System.Drawing.Size(61, 17);
            this.Lb_Apellido.TabIndex = 1;
            this.Lb_Apellido.Text = "Apellido";
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Nombre.Location = new System.Drawing.Point(10, 18);
            this.Lb_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(61, 17);
            this.Lb_Nombre.TabIndex = 0;
            this.Lb_Nombre.Text = "Nombre";
            // 
            // FrmEditarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1170, 393);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarAlumno";
            this.Text = "FrmEditar";
            this.Load += new System.EventHandler(this.FrmEditar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_Editar;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label Lb_Responsable2;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarAlumno;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Lb_Dni;
        private System.Windows.Forms.Label Lb_Apellido;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label Lb_importe;
        private System.Windows.Forms.Label La_CAMBIAR;
        private System.Windows.Forms.Label Lb_Responsable1;
        private System.Windows.Forms.TextBox txtResponsable;
    }
}