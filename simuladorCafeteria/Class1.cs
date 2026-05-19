using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simuladorCafeteria
{
    public class Bebida
    {
        private string nombre;
        private string tamaño;
        private double precio;

        public Bebida(string nombre, string tamaño, double precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }

        public void Preparar()
        {
            Console.WriteLine(" se esta preparando un " + nombre + " de tamaño " + tamaño);
        }

        public void aplicaDescuento(double porcentaje)
        {
            double descuento = precio * (porcentaje / 100);
            precio = precio - descuento;
        }
        public void mostrarDatos()
        {
            Console.WriteLine("esto es un " + nombre + " de tamaño " + tamaño + " con un costo de " + precio + "\n");
        }
            
    }
  
}
