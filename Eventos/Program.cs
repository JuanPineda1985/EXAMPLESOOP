using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eventos");
            Console.WriteLine("Exposicion: ");
            string Expo = Console.ReadLine();
            Console.WriteLine("Conferencia: ");
            string Confe = Console.ReadLine();
            Console.WriteLine("aforo: ");
            int Aforo = int.Parse(Console.ReadLine());
            Console.WriteLine("Productos en venta");
            string Product = Console.ReadLine();
            Console.WriteLine("Presentacion Empresarial");
            string Social = Console.ReadLine();
            Console.WriteLine("Muestras de Productos");
            string muestras = Console.ReadLine();

            Cultural cultural = new Cultural()
            {
                Exposicion = Expo,
                Conferencia = Confe,
                Aforo = Aforo
            };
            
            Empresarial empresarial = new Empresarial ()
            {
               Venta_produc = Product,
               Sociali_empresa = Social

            };

            feria Feria = new feria()
            {
               Mostrario = muestras 
            };


            Console.WriteLine($"{cultural.Exposicion} {cultural.Exposicion} {cultural.Aforo} {empresarial.Venta_produc}  {empresarial.Sociali_empresa} {Feria.Mostrario}");
        }    
    }
}