namespace Clifton.Manuel._2D.Parcial2
{
    partial class FrmSecundario
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
            this.listEvaluados = new System.Windows.Forms.ListBox();
            this.Lb_Evaluados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listEvaluados
            // 
            this.listEvaluados.FormattingEnabled = true;
            this.listEvaluados.Location = new System.Drawing.Point(170, 83);
            this.listEvaluados.Name = "listEvaluados";
            this.listEvaluados.Size = new System.Drawing.Size(190, 134);
            this.listEvaluados.TabIndex = 0;
            // 
            // Lb_Evaluados
            // 
            this.Lb_Evaluados.AutoSize = true;
            this.Lb_Evaluados.Location = new System.Drawing.Point(220, 51);
            this.Lb_Evaluados.Name = "Lb_Evaluados";
            this.Lb_Evaluados.Size = new System.Drawing.Size(72, 13);
            this.Lb_Evaluados.TabIndex = 6;
            this.Lb_Evaluados.Text = "EVALUADOS";
            // 
            // FrmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(551, 366);
            this.Controls.Add(this.Lb_Evaluados);
            this.Controls.Add(this.listEvaluados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(1200, 300);
            this.Name = "FrmSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AULAS";
            this.Load += new System.EventHandler(this.FrmSecundario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listEvaluados;
        private System.Windows.Forms.Label Lb_Evaluados;
    }
}