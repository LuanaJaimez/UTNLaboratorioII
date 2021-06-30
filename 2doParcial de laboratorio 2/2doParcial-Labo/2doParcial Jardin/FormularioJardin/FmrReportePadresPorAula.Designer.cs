namespace FormularioJardin
{
    partial class FmrReportePadresPorAula
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
            this.lstBoxListaPadres = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxListaPadres
            // 
            this.lstBoxListaPadres.FormattingEnabled = true;
            this.lstBoxListaPadres.Location = new System.Drawing.Point(48, 39);
            this.lstBoxListaPadres.Name = "lstBoxListaPadres";
            this.lstBoxListaPadres.Size = new System.Drawing.Size(332, 355);
            this.lstBoxListaPadres.TabIndex = 0;
            this.lstBoxListaPadres.SelectedIndexChanged += new System.EventHandler(this.lstBoxListaPadres_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(295, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FmrReportePadresPorAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstBoxListaPadres);
            this.MaximumSize = new System.Drawing.Size(451, 489);
            this.MinimumSize = new System.Drawing.Size(451, 489);
            this.Name = "FmrReportePadresPorAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmrReportePadresPorAula";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.FmrReportePadresPorAula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxListaPadres;
        private System.Windows.Forms.Button btnSalir;
    }
}