using System;

namespace Eventos
{
    class Empresarial : Cultural
    {
        public string Venta_produc { get; set; }
        public string Sociali_empresa { get; set; }

        public void charla()
        {
            Console.WriteLine("comenzamos pronto");
        }
    }
}