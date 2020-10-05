using System;

namespace Eventos
{
    class Cultural
    {
       //Propiedades
        public string Exposicion { get; set; }
        public string Conferencia { get; set; }
        public int Aforo { get; set; }
       //Funciones
        public void concierto()
        {
            Console.WriteLine("Inscripiones Abiertas");
        }
    }
}
