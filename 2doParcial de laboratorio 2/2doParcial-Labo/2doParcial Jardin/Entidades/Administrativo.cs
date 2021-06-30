using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ECargo
    {
        Portería = 100,
        Cocina = 110,
        Secretaría = 140,
        Tesorería = 240,
        Dirección = 180
    }
    public class Administrativo : Personal
    {
        private ECargo cargo;
        public static double salarioBase;

        double aux;

        #region Propiedades
        public ECargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        #endregion

        #region Constructores
        static Administrativo()
        {
            salarioBase = 30000;
        }
        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaentrada, DateTime horasalida, ECargo cargo, double salario) : base(nombre, apellido, dni, femenino, horaentrada, horasalida)
        {
            this.cargo = cargo;

        }

        public override double CalcularSalario()
        {
            //if (cargo == ECargo.Portería)
            //{
            //    return salarioBase * (100 / 100);
            //}
            //else 
            //{
            //    if()
            //}

            switch (cargo)
            {
                case ECargo.Cocina:
                    aux = salarioBase * ((double)ECargo.Cocina / 100);
                    break;

                case ECargo.Dirección:
                    aux = salarioBase * ((double)ECargo.Dirección / 100);
                    break;

                case ECargo.Portería:
                    aux = salarioBase * ((double)ECargo.Portería / 100);
                    break;

                case ECargo.Secretaría:
                    aux = salarioBase * ((double)ECargo.Secretaría / 100);
                    break;

                case ECargo.Tesorería:
                    aux = salarioBase * ((double)ECargo.Tesorería / 100);
                    break;
            }
            return aux;


        }
        #endregion




    }
}
