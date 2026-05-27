using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladorCafeteria
{
    internal class BebidaCaliente : Bebida
    {
        private float Temperatura;

        public float temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }

        public BebidaCaliente(string nombre,string tamaño,double precio, float temperatura) : base(nombre, tamaño, precio)
        {
            Temperatura=temperatura;
        }

        public override string Preparar()
        {
            return " Estamos preparando un: " + Nombre + " de temperatura "+ temperatura + " de tamaño " + Tamaño;
        }
    }
}
