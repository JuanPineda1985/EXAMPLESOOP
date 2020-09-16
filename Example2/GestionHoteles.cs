using System; // usando una libreria generica

namespace OneIntro
{
    class GestionHotel
    {   
        //Propiedades
        public string habitacion { get; set;}
        public int huesped {get; set;}

        int Dias;
        //public int huesped {get; set;}
        public int dias{
            get{}
            set
            {
                if (value >=1)
                {
                    Dias = value;
                }else
                {

                    Consle.WriteLine("Cantidad dias debe ser minimo 1");
                }
            }
        }
        
        //Metodos
        public int valorEstadia(int huesp, int cantd){
            int TINDIVIDUAL = 2500;
            int TDOBLE = 4600;
            int TFAMILIAR = 5200;
        int cobro = 0;

            if (huesp == 1) {
                cobro = cantd * TINDIVIDUAL;
            }
            else{
                if (huesp == 2){
                    cobro = cantd * TDOBLE,
                };
                else {
                    if (huesp >= 3){
                        cobro = cantd * TFAMILIAR;
                    }
                    else {

                    }

                }

            }
            return cobro;

            public void cuentaCobro(){
                int IVA = 19;
                int precioConIba = 0; 
                precioConIva = valorEstadia(huesped, dias); 

                precioConIva = (precioConIva * IVA / 100) + 

                Console.WriteLine(precioConIva); 
            }
        }
    }
}
        



        
