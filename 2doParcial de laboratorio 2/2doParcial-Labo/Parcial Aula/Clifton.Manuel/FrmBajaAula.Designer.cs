namespace Clifton.Manuel
{
    partial class FrmBajaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaAula));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_BajaAula = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.Lb_Color = new System.Windows.Forms.Label();
            this.Lb_Turno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarBaja = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lb_BajaAula);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 40);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lb_BajaAula
            // 
            this.Lb_BajaAula.AutoSize = true;
            this.Lb_BajaAula.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_BajaAula.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_BajaAula.Location = new System.Drawing.Point(202, 9);
            this.Lb_BajaAula.Name = "Lb_BajaAula";
            this.Lb_BajaAula.Size = new System.Drawing.Size(128, 22);
            this.Lb_BajaAula.TabIndex = 0;
            this.Lb_BajaAula.Text = "Baja de Aula";
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
            this.cmbColores.Location = new System.Drawing.Point(238, 94);
            this.cmbColores.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(199, 28);
            this.cmbColores.TabIndex = 27;
            // 
            // Lb_Color
            // 
            this.Lb_Color.AutoSize = true;
            this.Lb_Color.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Color.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Color.Location = new System.Drawing.Point(104, 95);
            this.Lb_Color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Color.Name = "Lb_Color";
            this.Lb_Color.Size = new System.Drawing.Size(58, 22);
            this.Lb_Color.TabIndex = 26;
            this.Lb_Color.Text = "Color";
            // 
            // Lb_Turno
            // 
            this.Lb_Turno.AutoSize = true;
            this.Lb_Turno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Turno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Turno.Location = new System.Drawing.Point(104, 203);
            this.Lb_Turno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Turno.Name = "Lb_Turno";
            this.Lb_Turno.Size = new System.Drawing.Size(60, 22);
            this.Lb_Turno.TabIndex = 28;
            this.Lb_Turno.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbTurno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Naranja",
            "Rojo",
            "Amarillo",
            "Verde"});
            this.cmbTurno.Location = new System.Drawing.Point(238, 202);
            this.cmbTurno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(199, 28);
            this.cmbTurno.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(98, 321);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 45);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarBaja
            // 
            this.btnConfirmarBaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmarBaja.Location = new System.Drawing.Point(361, 321);
            this.btnConfirmarBaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarBaja.Name = "btnConfirmarBaja";
            this.btnConfirmarBaja.Size = new System.Drawing.Size(187, 42);
            this.btnConfirmarBaja.TabIndex = 32;
            this.btnConfirmarBaja.Text = "Confirmar Baja";
            this.btnConfirmarBaja.UseVisualStyleBackColor = true;
            this.btnConfirmarBaja.Click += new System.EventHandler(this.btnConfirmarBaja_Click);
            // 
            // FrmBajaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(631, 414);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarBaja);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.Lb_Turno);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.Lb_Color);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaAula";
            this.Text = "FrmBajaAula";
            this.Load += new System.EventHandler(this.FrmBajaAula_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_BajaAula;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label Lb_Color;
        private System.Windows.Forms.Label Lb_Turno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarBaja;
    }
}