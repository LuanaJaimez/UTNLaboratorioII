namespace Clifton.Manuel._2D.Parcial2
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.Lb_Alumnos = new System.Windows.Forms.Label();
            this.Lb_Proximo = new System.Windows.Forms.Label();
            this.listAlumnos = new System.Windows.Forms.ListBox();
            this.txtProximo = new System.Windows.Forms.TextBox();
            this.Lb_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lb_Fecha = new System.Windows.Forms.Label();
            this.Lb_Coneccion = new System.Windows.Forms.Label();
            this.Lb_EstadoConexion = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.Lb_cantidadEva = new System.Windows.Forms.Label();
            this.Lb_cantEvaluados = new System.Windows.Forms.Label();
            this.Lb_Recreo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_Alumnos
            // 
            this.Lb_Alumnos.AutoSize = true;
            this.Lb_Alumnos.Location = new System.Drawing.Point(19, 27);
            this.Lb_Alumnos.Name = "Lb_Alumnos";
            this.Lb_Alumnos.Size = new System.Drawing.Size(47, 13);
            this.Lb_Alumnos.TabIndex = 0;
            this.Lb_Alumnos.Text = "Alumnos";
            // 
            // Lb_Proximo
            // 
            this.Lb_Proximo.AutoSize = true;
            this.Lb_Proximo.Location = new System.Drawing.Point(303, 27);
            this.Lb_Proximo.Name = "Lb_Proximo";
            this.Lb_Proximo.Size = new System.Drawing.Size(44, 13);
            this.Lb_Proximo.TabIndex = 1;
            this.Lb_Proximo.Text = "Proximo";
            // 
            // listAlumnos
            // 
            this.listAlumnos.FormattingEnabled = true;
            this.listAlumnos.Location = new System.Drawing.Point(12, 63);
            this.listAlumnos.Name = "listAlumnos";
            this.listAlumnos.Size = new System.Drawing.Size(169, 290);
            this.listAlumnos.TabIndex = 3;
            // 
            // txtProximo
            // 
            this.txtProximo.Enabled = false;
            this.txtProximo.Location = new System.Drawing.Point(235, 63);
            this.txtProximo.Name = "txtProximo";
            this.txtProximo.Size = new System.Drawing.Size(169, 20);
            this.txtProximo.TabIndex = 4;
            // 
            // Lb_Timer
            // 
            this.Lb_Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Timer.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Timer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Timer.Location = new System.Drawing.Point(225, 237);
            this.Lb_Timer.Name = "Lb_Timer";
            this.Lb_Timer.Size = new System.Drawing.Size(451, 52);
            this.Lb_Timer.TabIndex = 6;
            this.Lb_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lb_Fecha
            // 
            this.Lb_Fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Fecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Fecha.Location = new System.Drawing.Point(240, 309);
            this.Lb_Fecha.Name = "Lb_Fecha";
            this.Lb_Fecha.Size = new System.Drawing.Size(415, 26);
            this.Lb_Fecha.TabIndex = 7;
            this.Lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Coneccion
            // 
            this.Lb_Coneccion.AutoSize = true;
            this.Lb_Coneccion.Location = new System.Drawing.Point(634, 37);
            this.Lb_Coneccion.Name = "Lb_Coneccion";
            this.Lb_Coneccion.Size = new System.Drawing.Size(58, 13);
            this.Lb_Coneccion.TabIndex = 8;
            this.Lb_Coneccion.Text = "Coneccion";
            // 
            // Lb_EstadoConexion
            // 
            this.Lb_EstadoConexion.Location = new System.Drawing.Point(698, 37);
            this.Lb_EstadoConexion.Name = "Lb_EstadoConexion";
            this.Lb_EstadoConexion.Size = new System.Drawing.Size(11, 13);
            this.Lb_EstadoConexion.TabIndex = 9;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(216, 134);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(76, 36);
            this.btnEmpezar.TabIndex = 10;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // Lb_cantidadEva
            // 
            this.Lb_cantidadEva.AutoSize = true;
            this.Lb_cantidadEva.Location = new System.Drawing.Point(451, 27);
            this.Lb_cantidadEva.Name = "Lb_cantidadEva";
            this.Lb_cantidadEva.Size = new System.Drawing.Size(117, 13);
            this.Lb_cantidadEva.TabIndex = 11;
            this.Lb_cantidadEva.Text = "Cantidad de Evaluados";
            // 
            // Lb_cantEvaluados
            // 
            this.Lb_cantEvaluados.AutoSize = true;
            this.Lb_cantEvaluados.Location = new System.Drawing.Point(499, 66);
            this.Lb_cantEvaluados.Name = "Lb_cantEvaluados";
            this.Lb_cantEvaluados.Size = new System.Drawing.Size(0, 13);
            this.Lb_cantEvaluados.TabIndex = 12;
            // 
            // Lb_Recreo
            // 
            this.Lb_Recreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Recreo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Recreo.ForeColor = System.Drawing.Color.Firebrick;
            this.Lb_Recreo.Location = new System.Drawing.Point(313, 96);
            this.Lb_Recreo.Name = "Lb_Recreo";
            this.Lb_Recreo.Size = new System.Drawing.Size(379, 125);
            this.Lb_Recreo.TabIndex = 13;
            this.Lb_Recreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(752, 374);
            this.Controls.Add(this.Lb_Recreo);
            this.Controls.Add(this.Lb_cantEvaluados);
            this.Controls.Add(this.Lb_cantidadEva);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.Lb_EstadoConexion);
            this.Controls.Add(this.Lb_Coneccion);
            this.Controls.Add(this.Lb_Fecha);
            this.Controls.Add(this.Lb_Timer);
            this.Controls.Add(this.txtProximo);
            this.Controls.Add(this.listAlumnos);
            this.Controls.Add(this.Lb_Proximo);
            this.Controls.Add(this.Lb_Alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EVALUACIONES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Alumnos;
        private System.Windows.Forms.Label Lb_Proximo;
        private System.Windows.Forms.ListBox listAlumnos;
        private System.Windows.Forms.TextBox txtProximo;
        private System.Windows.Forms.Label Lb_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lb_Fecha;
        private System.Windows.Forms.Label Lb_Coneccion;
        private System.Windows.Forms.Label Lb_EstadoConexion;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label Lb_cantidadEva;
        private System.Windows.Forms.Label Lb_cantEvaluados;
        private System.Windows.Forms.Label Lb_Recreo;
    }
}

