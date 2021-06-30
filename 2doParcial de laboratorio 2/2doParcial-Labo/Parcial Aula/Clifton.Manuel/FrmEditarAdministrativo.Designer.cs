namespace Clifton.Manuel
{
    partial class FrmEditarAdministrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarAdministrativo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_Editar = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.dateTimeHrSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHrEntrada = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Lb_Sexo = new System.Windows.Forms.Label();
            this.Lb_Dni = new System.Windows.Forms.Label();
            this.Lb_Apellido = new System.Windows.Forms.Label();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.Lb_HE = new System.Windows.Forms.Label();
            this.Lb_HS = new System.Windows.Forms.Label();
            this.Lb_Cargo = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridNoDocente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNoDocente)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1104, 40);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1044, 7);
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
            this.Lb_Editar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Editar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_Editar.Location = new System.Drawing.Point(456, 9);
            this.Lb_Editar.Name = "Lb_Editar";
            this.Lb_Editar.Size = new System.Drawing.Size(67, 22);
            this.Lb_Editar.TabIndex = 0;
            this.Lb_Editar.Text = "Editar ";
            // 
            // cmbCargo
            // 
            this.cmbCargo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(155, 325);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(368, 21);
            this.cmbCargo.TabIndex = 42;
            this.cmbCargo.TextChanged += new System.EventHandler(this.cmbCargo_TextChanged);
            // 
            // dateTimeHrSalida
            // 
            this.dateTimeHrSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHrSalida.Location = new System.Drawing.Point(155, 281);
            this.dateTimeHrSalida.Name = "dateTimeHrSalida";
            this.dateTimeHrSalida.RightToLeftLayout = true;
            this.dateTimeHrSalida.Size = new System.Drawing.Size(368, 20);
            this.dateTimeHrSalida.TabIndex = 40;
            // 
            // dateTimeHrEntrada
            // 
            this.dateTimeHrEntrada.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeHrEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHrEntrada.Location = new System.Drawing.Point(155, 235);
            this.dateTimeHrEntrada.Name = "dateTimeHrEntrada";
            this.dateTimeHrEntrada.RightToLeftLayout = true;
            this.dateTimeHrEntrada.Size = new System.Drawing.Size(368, 20);
            this.dateTimeHrEntrada.TabIndex = 39;
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(155, 188);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(368, 21);
            this.cmbSexo.TabIndex = 38;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDni.Location = new System.Drawing.Point(155, 148);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(368, 20);
            this.txtDni.TabIndex = 37;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(45, 394);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(187, 38);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(333, 394);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(215, 38);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Agregar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtApellido.Location = new System.Drawing.Point(155, 105);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(368, 20);
            this.txtApellido.TabIndex = 35;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombre.Location = new System.Drawing.Point(155, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(368, 20);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // Lb_Sexo
            // 
            this.Lb_Sexo.AutoSize = true;
            this.Lb_Sexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Sexo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Sexo.Location = new System.Drawing.Point(42, 189);
            this.Lb_Sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Sexo.Name = "Lb_Sexo";
            this.Lb_Sexo.Size = new System.Drawing.Size(37, 17);
            this.Lb_Sexo.TabIndex = 36;
            this.Lb_Sexo.Text = "Sexo";
            // 
            // Lb_Dni
            // 
            this.Lb_Dni.AutoSize = true;
            this.Lb_Dni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Dni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Dni.Location = new System.Drawing.Point(42, 151);
            this.Lb_Dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Dni.Name = "Lb_Dni";
            this.Lb_Dni.Size = new System.Drawing.Size(31, 17);
            this.Lb_Dni.TabIndex = 34;
            this.Lb_Dni.Text = "DNI";
            // 
            // Lb_Apellido
            // 
            this.Lb_Apellido.AutoSize = true;
            this.Lb_Apellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Apellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Apellido.Location = new System.Drawing.Point(25, 108);
            this.Lb_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Apellido.Name = "Lb_Apellido";
            this.Lb_Apellido.Size = new System.Drawing.Size(61, 17);
            this.Lb_Apellido.TabIndex = 33;
            this.Lb_Apellido.Text = "Apellido";
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Nombre.Location = new System.Drawing.Point(25, 67);
            this.Lb_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(61, 17);
            this.Lb_Nombre.TabIndex = 31;
            this.Lb_Nombre.Text = "Nombre";
            // 
            // Lb_HE
            // 
            this.Lb_HE.AutoSize = true;
            this.Lb_HE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_HE.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_HE.Location = new System.Drawing.Point(2, 239);
            this.Lb_HE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_HE.Name = "Lb_HE";
            this.Lb_HE.Size = new System.Drawing.Size(115, 17);
            this.Lb_HE.TabIndex = 49;
            this.Lb_HE.Text = "Hora de Entrada";
            // 
            // Lb_HS
            // 
            this.Lb_HS.AutoSize = true;
            this.Lb_HS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_HS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_HS.Location = new System.Drawing.Point(14, 285);
            this.Lb_HS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_HS.Name = "Lb_HS";
            this.Lb_HS.Size = new System.Drawing.Size(103, 17);
            this.Lb_HS.TabIndex = 50;
            this.Lb_HS.Text = "Hora de Salida";
            // 
            // Lb_Cargo
            // 
            this.Lb_Cargo.AutoSize = true;
            this.Lb_Cargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Cargo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Cargo.Location = new System.Drawing.Point(42, 329);
            this.Lb_Cargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Cargo.Name = "Lb_Cargo";
            this.Lb_Cargo.Size = new System.Drawing.Size(50, 17);
            this.Lb_Cargo.TabIndex = 52;
            this.Lb_Cargo.Text = "Cargo";
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.dataGridNoDocente);
            this.panelData.Location = new System.Drawing.Point(574, 46);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(518, 406);
            this.panelData.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(193, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrativos";
            // 
            // dataGridNoDocente
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridNoDocente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridNoDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNoDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNoDocente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridNoDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridNoDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridNoDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNoDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridNoDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNoDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridNoDocente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridNoDocente.EnableHeadersVisualStyles = false;
            this.dataGridNoDocente.GridColor = System.Drawing.Color.White;
            this.dataGridNoDocente.Location = new System.Drawing.Point(0, 24);
            this.dataGridNoDocente.Name = "dataGridNoDocente";
            this.dataGridNoDocente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNoDocente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(224)))));
            this.dataGridNoDocente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridNoDocente.Size = new System.Drawing.Size(515, 379);
            this.dataGridNoDocente.TabIndex = 0;
            this.dataGridNoDocente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridNoDocente_RowHeaderMouseClick);
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
            // Column5
            // 
            this.Column5.HeaderText = "Horario de Entrada";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Horario de Salida";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cargo";
            this.Column7.Name = "Column7";
            // 
            // FrmEditarAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1104, 464);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.Lb_Cargo);
            this.Controls.Add(this.Lb_HS);
            this.Controls.Add(this.Lb_HE);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.dateTimeHrSalida);
            this.Controls.Add(this.dateTimeHrEntrada);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Lb_Sexo);
            this.Controls.Add(this.Lb_Dni);
            this.Controls.Add(this.Lb_Apellido);
            this.Controls.Add(this.Lb_Nombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarAdministrativo";
            this.Text = "FrmBajaAdministrativo";
            this.Load += new System.EventHandler(this.FrmEditarAdministrativo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNoDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_Editar;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.DateTimePicker dateTimeHrSalida;
        private System.Windows.Forms.DateTimePicker dateTimeHrEntrada;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Lb_Sexo;
        private System.Windows.Forms.Label Lb_Dni;
        private System.Windows.Forms.Label Lb_Apellido;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Label Lb_HE;
        private System.Windows.Forms.Label Lb_HS;
        private System.Windows.Forms.Label Lb_Cargo;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridNoDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}