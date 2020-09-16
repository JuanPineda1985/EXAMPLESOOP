using System; // usando una Libreria generica

namespace UnoIntro // espacio de nombre (carpeta del proyecto)
{
    class Program // el archivo donde estoy codificando alguna funcionalidad especifica 
    {

        // Atributos (propiedades que lo identifican )
        //color, marca, placa, modelo, etc 


        // Metodos (funciones, tareas que realiza)
        //arrancar, acelerar, frenar, etc 

        static void Main(string[] args) //un metodo, modificador de accerso, retorno, nombre de acceso, argumentos del metodo "parametros para que funcione" args= argumentos 
        {
            //Console.WriteLine("Hello Wold!"); // Instrucciones, pasos, actividades etc 

            //Console.WriteLine("Numero uno");  
            //int numUno = int.Parse(Console.ReadLine());

            //Console.WriteLine("Numero dos");  
            //int numDos = int.Parse(Console.ReadLine());

            /*
            Forma estructurada 
            //Console.WriteLine("El numero es: " + numUno);
            //Console.WriteLine($"En numero es: {numUno}");

            //int suma = numUno + numDos; 

            //Console.WriteLine($"La suma de {numUno} y {numDos} es {suma}");

            Console.WriteLine($"La suma de {numUno} y {numDos} es {numUno + numDos}");
            */

            // Forma orientada a objetos 
            // Instanciar la class Operaciones 
             // Class    objeto(instancia) (= new ) SonPalabrasReservadas constructorDeLaClass()
            //Operaciones myOperacion = new Operaciones()
            //var myOperacion = new Operaciones () {
                //numeroUno = numUno,
                //numeroDos = numDos 
            //}; 

            // verificar el valor que tiene almacenado la propiedad 
            //Console.WriteLine(myOperacion.numeroUno);

            // Llevar el valor como parametro a un metodo 
            // para hacer esto llamar el metodo de la class 
            // mediante su instancia (un objeto)

            //myOperacion.nuestraSuma(myOperacion.numeroUno, myOperacion.numeroDos);
            //myOperacion.imprimirSuma(); 


            /**
            Ejemplo Hotel 
            con OOP

            */
             Console.WriteLine("Hotel WCG");  

            Console.WriteLine("Cantidad Huespedes");  
            int huespedes = int.Parse(Console.ReadLine());

            Console.WriteLine("Dias de estadia");  
            int cant_dias = int.Parse(Console.ReadLine());

             Console.WriteLine("Nombre habitacion");  
            String nom_hab= Console.ReadLine();

            // instancia 

            var hotelUno = new GestionHotel(){
                habitacion = nom_hab,
                huesped = huespedes,
                dias = cant_dias
            };

            hotelUno.cuentaCobro(); 
        }
    }


}
    }

    }