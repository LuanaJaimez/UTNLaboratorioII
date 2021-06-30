namespace parcial_2_de_corredor
{
    partial class frmRSP
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
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.lblCarril1 = new System.Windows.Forms.Label();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.lblCarril2 = new System.Windows.Forms.Label();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(110, 20);
            this.pgbCarril1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(380, 31);
            this.pgbCarril1.TabIndex = 0;
            // 
            // lblCarril1
            // 
            this.lblCarril1.AutoSize = true;
            this.lblCarril1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarril1.Location = new System.Drawing.Point(27, 28);
            this.lblCarril1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarril1.Name = "lblCarril1";
            this.lblCarril1.Size = new System.Drawing.Size(63, 24);
            this.lblCarril1.TabIndex = 1;
            this.lblCarril1.Text = "Carril1";
            // 
            // btnCorrer
            // 
            this.btnCorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrer.Location = new System.Drawing.Point(368, 120);
            this.btnCorrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(122, 58);
            this.btnCorrer.TabIndex = 2;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // lblCarril2
            // 
            this.lblCarril2.AutoSize = true;
            this.lblCarril2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarril2.Location = new System.Drawing.Point(27, 75);
            this.lblCarril2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarril2.Name = "lblCarril2";
            this.lblCarril2.Size = new System.Drawing.Size(63, 24);
            this.lblCarril2.TabIndex = 4;
            this.lblCarril2.Text = "Carril2";
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(110, 67);
            this.pgbCarril2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(380, 31);
            this.pgbCarril2.TabIndex = 3;
            // 
            // frmRSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 188);
            this.Controls.Add(this.lblCarril2);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.btnCorrer);
            this.Controls.Add(this.lblCarril1);
            this.Controls.Add(this.pgbCarril1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRSP";
            this.Text = "RSP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.Label lblCarril1;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Label lblCarril2;
        private System.Windows.Forms.ProgressBar pgbCarril2;
    }
}

