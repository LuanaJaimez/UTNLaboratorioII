using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public delegate void DelegadoRadical(object sender);
    class Numero
    {

        public event DelegadoRadical LlegueACero;


        int numero;

        int valor;
        private TextBox txtAsosiado;
        int velocidad;

        public Numero()
        {
            Valor = 100;
            Velocidad = 1000;
        }

        public TextBox TxtAsociado
        {
            get { return txtAsosiado; }
            set { this.txtAsosiado = value; }
        }
        public int Valor
        {
            get { return this.valor; }
            set {
                if (value == 0  )
                {

                }
                this.valor = value; 
            }
        }



        public int Velocidad
        {
            get { return this.velocidad; }
            set
            {
                if (value < 1)
                {

                }
                this.velocidad = value; }
        }

        public void Reset(object sender, EventArgs e)
        {
            valor = 100;
            Velocidad = Velocidad - 50;
        }

        public void Descontar()
        {
            while (Valor > 0)
            {
                Valor--;
                if (this.TxtAsociado.InvokeRequired)
                {
                    this.TxtAsociado.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.TxtAsociado.Text = Valor.ToString();
                    }
                    );
                }
                else
                {
                    this.txtMostrado.Text = Valor.ToString();
                }
                Thread.Sleep();
            }
        }





    }
}
