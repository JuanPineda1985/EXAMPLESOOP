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

            var FiestaLibro = new Cultural()
            {
                Exposicion = Expo,
                Conferencia = Confe,
                Aforo = Aforo
            };

            Console.WriteLine($"{FiestaLibro.Exposicion} {FiestaLibro.Aforo}");
        }    
        
    }
}