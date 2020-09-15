using System; // usando una libreria generica

namespace oneintro // espacio de nombre (carpeta del proyecto)
{
    class Program //el archivo donde estoy codificando alguna funcionalidad especifica
    {

        // Atributos (propiedades)
        // color, marca, placa, modelo, etc
        
        //metodos (funciones)
        // arrancar, acelerar, frenar, etc

        static void Main(string[] args) //un metodo
        {
            Console.WriteLine("hablalo"); //las instrucciones,pasos,tareas,actividades

            Console.WriteLine("Numero uno");
            int numUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero dos");
            int numDos = int.Parse(Console.ReadLine());
            
            /* forma Estructurada
            //Console.WriteLine("En numero es: " + numUno");
           // Cosoole.WriteLine($" El numeroes: {numUno}");

           //int suma = numUno + numDos

            Console.WriteLine($"La suma de {numUno} y {numDos} es {numUno + numDos}");
            */

            //Forma Orientada a Objetos
            // Instanciar la class Operaciones (objeto de la class)
            //class    Objeto(instancia) (=new)  son palabras reservadas constructorDeLaClass()
            //Operaciones myOperation = new Operaciones()
            var myOperation = new Operaciones (){
                numeroUno = numUno,
                numeroDos = numDos
            };
               
            // verificar el valor que tiene almacenado la propiedad
           //Console.WriteLine(myOperation.numeroUno);

            //Llevar el valor como parametro a un metodo
            // Para ehacer esto Llamar el metodo de la cass
            // mediante su instancia

            //myOperation.nuestraSuma(myOperation.numeroUno, myOperation.numeroDos);
            myOperation.imprimirSuma();

        }
    }


}