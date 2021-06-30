namespace Clifton.Manuel
{
    partial class FrmMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_Videos = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listRutas = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lb_Videos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 40);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(786, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lb_Videos
            // 
            this.Lb_Videos.AutoSize = true;
            this.Lb_Videos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Videos.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Lb_Videos.Location = new System.Drawing.Point(286, 9);
            this.Lb_Videos.Name = "Lb_Videos";
            this.Lb_Videos.Size = new System.Drawing.Size(189, 21);
            this.Lb_Videos.TabIndex = 0;
            this.Lb_Videos.Text = "Videos de la Institución";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(714, 416);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(77, 36);
            this.btnCargar.TabIndex = 24;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Location = new System.Drawing.Point(714, 458);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(81, 36);
            this.btnReproducir.TabIndex = 25;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(714, 542);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(81, 36);
            this.btnParar.TabIndex = 26;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(714, 500);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(81, 36);
            this.btnPausar.TabIndex = 27;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(14, 51);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(802, 340);
            this.axWindowsMediaPlayer1.TabIndex = 29;
            // 
            // listRutas
            // 
            this.listRutas.FormattingEnabled = true;
            this.listRutas.Items.AddRange(new object[] {
            "https://examenprog.000webhostapp.com/Tiburoncito.mp4",
            "https://examenprog.000webhostapp.com/Silbar.mp4",
            "https://examenprog.000webhostapp.com/BloopersTS2.mp4"});
            this.listRutas.Location = new System.Drawing.Point(46, 416);
            this.listRutas.Name = "listRutas";
            this.listRutas.Size = new System.Drawing.Size(615, 160);
            this.listRutas.TabIndex = 30;
            // 
            // FrmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(829, 602);
            this.Controls.Add(this.listRutas);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMediaPlayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lb_Videos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnPausar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listRutas;
    }
}