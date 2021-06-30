namespace Clifton.Manuel
{
    partial class FrmBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaja));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_BajaCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarBaja = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Lb_Dni = new System.Windows.Forms.Label();
            this.Lb_Apellido = new System.Windows.Forms.Label();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lb_BajaCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 40);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lb_BajaCliente
            // 
            this.Lb_BajaCliente.AutoSize = true;
            this.Lb_BajaCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_BajaCliente.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_BajaCliente.Location = new System.Drawing.Point(288, 12);
            this.Lb_BajaCliente.Name = "Lb_BajaCliente";
            this.Lb_BajaCliente.Size = new System.Drawing.Size(107, 21);
            this.Lb_BajaCliente.TabIndex = 0;
            this.Lb_BajaCliente.Text = "Tipo de baja";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDni);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnConfirmarBaja);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.Lb_Dni);
            this.panel2.Controls.Add(this.Lb_Apellido);
            this.panel2.Controls.Add(this.Lb_Nombre);
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 345);
            this.panel2.TabIndex = 34;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDni.Location = new System.Drawing.Point(219, 186);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(368, 20);
            this.txtDni.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(157, 272);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmarBaja
            // 
            this.btnConfirmarBaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmarBaja.Location = new System.Drawing.Point(418, 275);
            this.btnConfirmarBaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarBaja.Name = "btnConfirmarBaja";
            this.btnConfirmarBaja.Size = new System.Drawing.Size(187, 42);
            this.btnConfirmarBaja.TabIndex = 7;
            this.btnConfirmarBaja.Text = "Confirmar Baja";
            this.btnConfirmarBaja.UseVisualStyleBackColor = true;
            this.btnConfirmarBaja.Click += new System.EventHandler(this.btnConfirmarBaja_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtApellido.Location = new System.Drawing.Point(219, 124);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(368, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNombre.Location = new System.Drawing.Point(219, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(368, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // Lb_Dni
            // 
            this.Lb_Dni.AutoSize = true;
            this.Lb_Dni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Dni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Dni.Location = new System.Drawing.Point(110, 189);
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
            this.Lb_Apellido.Location = new System.Drawing.Point(110, 127);
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
            this.Lb_Nombre.Location = new System.Drawing.Point(110, 66);
            this.Lb_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(61, 17);
            this.Lb_Nombre.TabIndex = 0;
            this.Lb_Nombre.Text = "Nombre";
            // 
            // FrmBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(707, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProbandoMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_BajaCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarBaja;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Lb_Dni;
        private System.Windows.Forms.Label Lb_Apellido;
        private System.Windows.Forms.Label Lb_Nombre;
    }
}