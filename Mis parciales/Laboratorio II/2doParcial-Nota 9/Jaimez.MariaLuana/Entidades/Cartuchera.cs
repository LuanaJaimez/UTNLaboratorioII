using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        #region Atributos
        protected int capacidad;
        protected List<T> elementos;
        public delegate void EventoPrecio(object sender, EventArgs e);
        public EventoPrecio PrecioSuperado;
        #endregion

        #region Propiedades
        public List<T> Elementos
        { 
            get 
            { 
                return this.elementos; 
            } 
        }

        public double PrecioTotal
        {
            get
            {
                double total = 0;
                foreach (T item in elementos)
                {
                    total += item.precio;
                }

                return total;
            }
        }
        #endregion

        #region Constructores
        public Cartuchera()
        {
            elementos = new List<T>();
        }

        public Cartuchera(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            st.AppendFormat("Cartuchera tipo: {0}\nCapacidad: {1}\nCantidad de elementos: {2}\nPrecio total: {3}\nLista de elementos:\n", typeof(T).Name, this.capacidad, this.elementos.Count, this.PrecioTotal);
            
            foreach (Utiles item in this.elementos)
            {
                st.AppendLine(item.ToString());
            }

            return st.ToString();
        }
        #endregion

        #region Operadores
        public static Cartuchera<T> operator +(Cartuchera<T> l, T u)
        {
            if (l.elementos.Count < l.capacidad && l != null)
            {
                l.elementos.Add(u);
            }
            else if (l.elementos.Count >= l.capacidad)
            {
                throw new CartucheraLlenaException();
            }

            if (l.PrecioTotal > 85 && l.PrecioSuperado != null)
            {
                l.PrecioSuperado.Invoke(l, EventArgs.Empty);
            }

            return l;
        }
        #endregion
    }
}
