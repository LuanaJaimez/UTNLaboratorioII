using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioJardin
{
    public partial class FmrReportePadresPorAula : Form
    {
        List<Alumno> listaResponsable;
        public FmrReportePadresPorAula()
        {
            InitializeComponent();
        }
        public FmrReportePadresPorAula(List<Alumno> lstResponsable): this()
        {
            this.listaResponsable = lstResponsable;
            
        }
        private void lstBoxListaPadres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FmrReportePadresPorAula_Load(object sender, EventArgs e)
        {
            if (!(this.listaResponsable is null))
                foreach (var item in this.listaResponsable)
                {
                    lstBoxListaPadres.Items.Add(item.Responsable.Nombre + " " + item.Responsable.Apellido + "  " + item.Responsable.Parentesco +" de " + item.Nombre );
                }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
