using System;

namespace oneintro
{
    class Operaciones
    {
        //Atributos (propiedades)
        public      int             numeroUno               { get; set; }
        //mod acc   tipo de dato    nombrepropiedad     metodos para recibir  (set) y para entregr  (get) el valor de la propiedad 
        public int numeroDos { get; set; }

        //Metodos(funciones)
        /*public  void nuestraSuma(int n1, int n2)
        {
        // Modificadior de Acceso tipo de retorn NombreMetodo (args o parame)
            int suma = n1 + n2;
            Console.WriteLine($"La suma de {n1} y {n2} es {suma}");
         }  */

         // separar responsabilidades en los metodos
         public int calcularSuma(int n1, int n2)
        {
            int resultadoSuma = 0;
            resultadoSuma = n1 + n2;
            return resultadoSuma;
        }
        
        public void imprimirSuma(){
             Console.WriteLine(
                 "la suma es " +
                 calcularSuma(numeroUno, numeroDos)
            );
 
        }

    }
}