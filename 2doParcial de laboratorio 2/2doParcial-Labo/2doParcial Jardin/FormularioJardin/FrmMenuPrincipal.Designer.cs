namespace FormularioJardin
{
    partial class MenPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenPrincipal));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDePadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionTotalDelJardinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreoObjDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.deserealizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.CreoObjDefault,
            this.deserealizarToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu Principal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDeDocenteToolStripMenuItem
            // 
            this.altaDeDocenteToolStripMenuItem.Name = "altaDeDocenteToolStripMenuItem";
            this.altaDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.altaDeDocenteToolStripMenuItem.Text = "Alta de Docente";
            this.altaDeDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDeDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta no Docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaAulaToolStripMenuItem
            // 
            this.altaAulaToolStripMenuItem.Name = "altaAulaToolStripMenuItem";
            this.altaAulaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.altaAulaToolStripMenuItem.Text = "Alta Aula";
            this.altaAulaToolStripMenuItem.Click += new System.EventHandler(this.altaAulaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDePadresToolStripMenuItem,
            this.sueldoDeDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudacionTotalDelJardinToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // informacionDePadresToolStripMenuItem
            // 
            this.informacionDePadresToolStripMenuItem.Name = "informacionDePadresToolStripMenuItem";
            this.informacionDePadresToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.informacionDePadresToolStripMenuItem.Text = "Informacion de padres";
            this.informacionDePadresToolStripMenuItem.Click += new System.EventHandler(this.informacionDePadresToolStripMenuItem_Click);
            // 
            // sueldoDeDocenteToolStripMenuItem
            // 
            this.sueldoDeDocenteToolStripMenuItem.Name = "sueldoDeDocenteToolStripMenuItem";
            this.sueldoDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sueldoDeDocenteToolStripMenuItem.Text = "Sueldo de docente";
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo no docente";
            // 
            // recaudacionTotalDelJardinToolStripMenuItem
            // 
            this.recaudacionTotalDelJardinToolStripMenuItem.Name = "recaudacionTotalDelJardinToolStripMenuItem";
            this.recaudacionTotalDelJardinToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.recaudacionTotalDelJardinToolStripMenuItem.Text = "Recaudacion total del jardin";
            // 
            // CreoObjDefault
            // 
            this.CreoObjDefault.Name = "CreoObjDefault";
            this.CreoObjDefault.Size = new System.Drawing.Size(111, 20);
            this.CreoObjDefault.Text = "Crear por defecto";
            this.CreoObjDefault.Click += new System.EventHandler(this.CreoObjDefault_Click);
            // 
            // deserealizarToolStripMenuItem
            // 
            this.deserealizarToolStripMenuItem.Name = "deserealizarToolStripMenuItem";
            this.deserealizarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deserealizarToolStripMenuItem.Text = "Deserealizar";
            this.deserealizarToolStripMenuItem.Click += new System.EventHandler(this.deserealizarToolStripMenuItem_Click);
            // 
            // MenPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.Menu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(816, 650);
            this.MinimumSize = new System.Drawing.Size(816, 650);
            this.Name = "MenPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDePadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionTotalDelJardinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreoObjDefault;
        private System.Windows.Forms.ToolStripMenuItem deserealizarToolStripMenuItem;
        // private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}