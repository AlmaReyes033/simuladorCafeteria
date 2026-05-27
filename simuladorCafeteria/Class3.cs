using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladorCafeteria
{
    internal class BebidaFria:Bebida
    {
        private int Cantidad_Hielo;

        public int cantidad_Hielo
        {
            get { return Cantidad_Hielo; }
            set { Cantidad_Hielo = value; }
        }

        public BebidaFria(string nombre, string tamaño, double precio,int cantidad_Hielo ):base(nombre,tamaño,precio)
        {
            Cantidad_Hielo=cantidad_Hielo;
        }

        public override string Preparar()
        {
            return " Estamos preparando un: " + Nombre + " Helado Con " + cantidad_Hielo + " cubos de hielo de tamaño " + Tamaño;
        }
    }
}
