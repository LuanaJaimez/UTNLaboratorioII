namespace FormularioDocente
{
    partial class FrmArchivoTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArchivoTexto));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rtxtContenido = new System.Windows.Forms.RichTextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.btnMostrarCont = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(42, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rtxtContenido
            // 
            this.rtxtContenido.Location = new System.Drawing.Point(42, 111);
            this.rtxtContenido.Name = "rtxtContenido";
            this.rtxtContenido.Size = new System.Drawing.Size(276, 133);
            this.rtxtContenido.TabIndex = 25;
            this.rtxtContenido.Text = "";
            this.rtxtContenido.TextChanged += new System.EventHandler(this.rtxtContenido_TextChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(124, 33);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(194, 20);
            this.txtPath.TabIndex = 24;
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "Abrir";
            // 
            // btnMostrarCont
            // 
            this.btnMostrarCont.Location = new System.Drawing.Point(42, 72);
            this.btnMostrarCont.Name = "btnMostrarCont";
            this.btnMostrarCont.Size = new System.Drawing.Size(122, 23);
            this.btnMostrarCont.TabIndex = 27;
            this.btnMostrarCont.Text = "Mostrar Contenido";
            this.btnMostrarCont.UseVisualStyleBackColor = true;
            this.btnMostrarCont.Click += new System.EventHandler(this.btnMostrarCont_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(196, 72);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 23);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar Archivo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\frann\\Desktop\\Componentes Graficos Vb2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\MS" +
    "N\\MSN.ssk";
            this.skinEngine1.SkinPassword = "";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // FrmArchivoTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 273);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMostrarCont);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rtxtContenido);
            this.Controls.Add(this.txtPath);
            this.Name = "FrmArchivoTexto";
            this.Text = "Archivos de Texto";
            this.Load += new System.EventHandler(this.FrmDeserializar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox rtxtContenido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.Button btnMostrarCont;
        private System.Windows.Forms.TextBox txtPath;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}