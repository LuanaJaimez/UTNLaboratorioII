namespace Eventos
{
    partial class FrmJuego
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
            this.btnJugador1 = new System.Windows.Forms.Button();
            this.btnJugador2 = new System.Windows.Forms.Button();
            this.btnJugador3 = new System.Windows.Forms.Button();
            this.btnJugador4 = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.txtJugador1 = new System.Windows.Forms.TextBox();
            this.txtJugador2 = new System.Windows.Forms.TextBox();
            this.txtJugador3 = new System.Windows.Forms.TextBox();
            this.txtJugador4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJugador1
            // 
            this.btnJugador1.Location = new System.Drawing.Point(59, 152);
            this.btnJugador1.Name = "btnJugador1";
            this.btnJugador1.Size = new System.Drawing.Size(75, 43);
            this.btnJugador1.TabIndex = 0;
            this.btnJugador1.Text = "Jugador Uno";
            this.btnJugador1.UseVisualStyleBackColor = true;
            this.btnJugador1.Click += new System.EventHandler(this.btnJugador1_Click);
            // 
            // btnJugador2
            // 
            this.btnJugador2.Location = new System.Drawing.Point(225, 152);
            this.btnJugador2.Name = "btnJugador2";
            this.btnJugador2.Size = new System.Drawing.Size(75, 43);
            this.btnJugador2.TabIndex = 1;
            this.btnJugador2.Text = "Jugador Dos";
            this.btnJugador2.UseVisualStyleBackColor = true;
            this.btnJugador2.Click += new System.EventHandler(this.btnJugador2_Click);
            // 
            // btnJugador3
            // 
            this.btnJugador3.Location = new System.Drawing.Point(394, 152);
            this.btnJugador3.Name = "btnJugador3";
            this.btnJugador3.Size = new System.Drawing.Size(75, 43);
            this.btnJugador3.TabIndex = 2;
            this.btnJugador3.Text = "Jugador Tres";
            this.btnJugador3.UseVisualStyleBackColor = true;
            this.btnJugador3.Click += new System.EventHandler(this.btnJugador3_Click);
            // 
            // btnJugador4
            // 
            this.btnJugador4.Location = new System.Drawing.Point(568, 152);
            this.btnJugador4.Name = "btnJugador4";
            this.btnJugador4.Size = new System.Drawing.Size(75, 43);
            this.btnJugador4.TabIndex = 3;
            this.btnJugador4.Text = "Jugador Cuatro";
            this.btnJugador4.UseVisualStyleBackColor = true;
            this.btnJugador4.Click += new System.EventHandler(this.btnJugador4_Click);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(71, 368);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 43);
            this.btnEmpezar.TabIndex = 4;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.Location = new System.Drawing.Point(592, 383);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(40, 13);
            this.lbPuntos.TabIndex = 5;
            this.lbPuntos.Text = "Puntos";
            // 
            // txtJugador1
            // 
            this.txtJugador1.Enabled = false;
            this.txtJugador1.Location = new System.Drawing.Point(46, 57);
            this.txtJugador1.Name = "txtJugador1";
            this.txtJugador1.Size = new System.Drawing.Size(100, 20);
            this.txtJugador1.TabIndex = 6;
            this.txtJugador1.Text = "Jugador Uno";
            // 
            // txtJugador2
            // 
            this.txtJugador2.Enabled = false;
            this.txtJugador2.Location = new System.Drawing.Point(211, 57);
            this.txtJugador2.Name = "txtJugador2";
            this.txtJugador2.Size = new System.Drawing.Size(100, 20);
            this.txtJugador2.TabIndex = 7;
            this.txtJugador2.Text = "Jugador Dos";
            // 
            // txtJugador3
            // 
            this.txtJugador3.Enabled = false;
            this.txtJugador3.Location = new System.Drawing.Point(383, 57);
            this.txtJugador3.Name = "txtJugador3";
            this.txtJugador3.Size = new System.Drawing.Size(100, 20);
            this.txtJugador3.TabIndex = 8;
            this.txtJugador3.Text = "Jugador Tres";
            // 
            // txtJugador4
            // 
            this.txtJugador4.Enabled = false;
            this.txtJugador4.Location = new System.Drawing.Point(555, 57);
            this.txtJugador4.Name = "txtJugador4";
            this.txtJugador4.Size = new System.Drawing.Size(100, 20);
            this.txtJugador4.TabIndex = 9;
            this.txtJugador4.Text = "Jugador Cuatro";
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 445);
            this.Controls.Add(this.txtJugador4);
            this.Controls.Add(this.txtJugador3);
            this.Controls.Add(this.txtJugador2);
            this.Controls.Add(this.txtJugador1);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.btnJugador4);
            this.Controls.Add(this.btnJugador3);
            this.Controls.Add(this.btnJugador2);
            this.Controls.Add(this.btnJugador1);
            this.Name = "FrmJuego";
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmJuego_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJugador1;
        private System.Windows.Forms.Button btnJugador2;
        private System.Windows.Forms.Button btnJugador3;
        private System.Windows.Forms.Button btnJugador4;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.TextBox txtJugador1;
        private System.Windows.Forms.TextBox txtJugador2;
        private System.Windows.Forms.TextBox txtJugador3;
        private System.Windows.Forms.TextBox txtJugador4;
    }
}