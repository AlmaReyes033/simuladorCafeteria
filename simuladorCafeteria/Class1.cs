using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladorCafeteria
{
    internal class Bebida
    {
        protected string Nombre;
        protected string Tamaño;
        protected double Precio;


        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string tamaño
        {
            get { return Tamaño;}
            set { Tamaño = value; }
        }
        public  double precio
        {
            get { return Precio; }
            set {
                if (value>0)
                Precio = value; }
        }
        public Bebida(string nombre, string tamaño, double precio)
        {
            this.Nombre = nombre;
            this.Tamaño = tamaño;
            this.Precio = precio;
        }

        public Bebida()
        {
            Nombre = "";
            Tamaño = "";
            Precio = 0.0f;
        }

        public virtual string Preparar()
        {
            return " Estamos preparando un: " + Nombre + " de tamaño " + Tamaño;
        }

        public void aplicaDescuento(double porcentaje)
        {
            double descuento = precio * (porcentaje / 100);
            precio = precio - descuento;
        }

        public virtual string mostrarDatos()
        {
            return "esto es un " + nombre + " de tamaño " + tamaño + " con un costo de " + precio + "\n";
        }
            
    }
  
}
