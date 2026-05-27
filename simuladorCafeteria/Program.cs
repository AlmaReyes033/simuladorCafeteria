namespace simuladorCafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bebida> Pedido = new List<Bebida>();

         
            Pedido.Add(new BebidaCaliente("Chocolate", "Mediano", 90.5f, 45.00f));
            Pedido.Add(new BebidaFria("Limonada", "Grande", 35, 5));
            Pedido.Add(new BebidaCaliente("Matcha latte", "Chico", 35.0f, 30.00f));
            Pedido.Add(new BebidaFria("Frappe de cafe", "Mediano", 60, 4));
            Pedido.Add(new BebidaCaliente("Cafe Americano", "Chico", 50.0f, 89.00f));

            Console.WriteLine("=== TICKET DE BARRA ===\n");

            double Costo_Total = 0;

            // Recorrer la lista
            foreach (Bebida b in Pedido)
            {
               
                Console.WriteLine(b.Preparar());
                
                if (b is BebidaCaliente caliente)
                {
                
                    if (caliente.temperatura > 88)
                    {
                        Console.WriteLine("   [!] ADVERTENCIA: ¡Cuidado, bebida muy caliente!");
                    }
                }

                Costo_Total = Costo_Total + b.precio;

                Console.WriteLine("\n");
            }

            Console.WriteLine("\nTotal a pagar: $" + Costo_Total);

            Console.ReadLine();
        }
    }
    
}
