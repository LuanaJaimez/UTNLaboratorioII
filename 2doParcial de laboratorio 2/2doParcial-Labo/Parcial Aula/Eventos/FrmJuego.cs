using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{



    public partial class FrmJuego : Form
    {

        List<Thread> hilos;

        public FrmJuego()
        {
            InitializeComponent();
            hilos = new List<Thread>();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            Numero jugador1 = new Numero();
            Numero jugador2 = new Numero();
            Numero jugador3 = new Numero();
            Numero jugador4 = new Numero();

            jugador1.TxtAsociado = this.txtJugador1;
            jugador2.TxtAsociado = this.txtJugador2;
            jugador3.TxtAsociado = this.txtJugador3;
            jugador4.TxtAsociado = this.txtJugador4;

            jugador1.LlegueACero  += perdi;
            jugador2.LlegueACero  += perdi;
            jugador3.LlegueACero  += perdi;
            jugador4.LlegueACero  += perdi;

            hilos.Add(new Thread(jugador1.Descontar));
            hilos.Add(new Thread(jugador2.Descontar));
            hilos.Add(new Thread(jugador3.Descontar));
            hilos.Add(new Thread(jugador4.Descontar));

            btnJugador1.Click = jugador1.Reset;
            btnJugador1.Click += btnJugador1_Click;
            btnJugador2.Click = jugador2.Reset;
            btnJugador2.Click += btnJugador2_Click;
            btnJugador3.Click = jugador3.Reset;
            btnJugador3.Click += btnJugador3_Click;
            btnJugador4.Click = jugador4.Reset;
            btnJugador4.Click += btnJugador4_Click;

        }

        private void FrmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            eliminarHilos();
        }

        private void eliminarHilos()
        {
            foreach (var item in hilos)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }

        private void btnJugador1_Click(object sender, EventArgs e)
        {
            hilos[0].Abort();
            hilos[0].Start();
        }

        private void btnJugador2_Click(object sender, EventArgs e)
        {
            hilos[1].Abort();
            hilos[1].Start();
        }

        private void btnJugador4_Click(object sender, EventArgs e)
        {
            hilos[3].Abort();
            hilos[3].Start();
        }

        private void btnJugador3_Click(object sender, EventArgs e)
        {
            hilos[2].Abort();
            hilos[2].Start();
        }
    }//
}//
