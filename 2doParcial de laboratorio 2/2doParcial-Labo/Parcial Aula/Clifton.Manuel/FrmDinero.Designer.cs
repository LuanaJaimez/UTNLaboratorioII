namespace Clifton.Manuel
{
    partial class FrmDinero
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
            this.Lb_SueldoTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_texto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_SueldoTotal
            // 
            this.Lb_SueldoTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lb_SueldoTotal.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_SueldoTotal.Location = new System.Drawing.Point(0, 211);
            this.Lb_SueldoTotal.Name = "Lb_SueldoTotal";
            this.Lb_SueldoTotal.Size = new System.Drawing.Size(685, 191);
            this.Lb_SueldoTotal.TabIndex = 1;
            this.Lb_SueldoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lb_texto);
            this.panel1.Controls.Add(this.Lb_SueldoTotal);
            this.panel1.Location = new System.Drawing.Point(77, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 402);
            this.panel1.TabIndex = 2;
            // 
            // Lb_texto
            // 
            this.Lb_texto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lb_texto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_texto.Location = new System.Drawing.Point(0, 20);
            this.Lb_texto.Name = "Lb_texto";
            this.Lb_texto.Size = new System.Drawing.Size(685, 191);
            this.Lb_texto.TabIndex = 2;
            this.Lb_texto.Text = "Salario de todo el Personal";
            this.Lb_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSueldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_SueldoTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_texto;
    }
}