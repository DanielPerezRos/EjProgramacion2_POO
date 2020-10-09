using System;

namespace EjProgramacion2_POO_3
{
    class Program
    {
        /*
        Crear una clase Tiempo, con atributos hora, minuto y segundo, que pueda
        ser construída indicando los tres atributos, sólo la hora y minuto o sólo
        la hora. Crear además los métodos necesarios para modificar la hora en
        cualquier momento de forma manual. Mantenga la integridad de los datos
        en todo momento.
        Crear una clase PruebaTiempo que prueba una hora concreta y la modifique
       a su gusto mostrándola por pantalla.
         */
        static void Main(string[] args)
        {
            Tiempo miTiempo = new Tiempo(22,50,30);

            Console.WriteLine("Tiempo sin errores");
            miTiempo.mostrarHora();

            Tiempo tiempoError = new Tiempo(24, 60, 60);
            Console.WriteLine("--------------------");
            Console.WriteLine("Tiempo con errores");
            tiempoError.mostrarHora();

        }
    }

    class Tiempo
    {

        private int vHora;
        private int vMinutos;
        private int vSegundos;

        // Propiedades

        public int hora 
        { 
            get
            {
                return vHora;
            }
            set
            {
                if (value >= 0 && value <24)
                    vHora = value;
                else
                    vHora = 0;
            }
        
        }  
        public int minuto 
        {
            get
            {
                return vMinutos;
            }
            set
            {
                if (value >= 0 && value < 60)
                    vMinutos = value;
                else
                    vMinutos = 0;
            }
        }
        public int segundo 
        {
            get
            {
                return vSegundos;
            }
            set
            {
                if (value >= 0 && value < 60)
                    vSegundos = value;
                else
                    vSegundos = 0;
            }
        }
        public Tiempo(int pHora, int pMinuto, int pSegundo)  // Constructor
        {
            hora = pHora;
            minuto = pMinuto;
            segundo = pSegundo;
        }
        public Tiempo(int pHora, int pMinuto)  // Constructor
        {
            hora = pHora;
            minuto = pMinuto;
        }
        public Tiempo(int pHora)  // Constructor
        {
            hora = pHora;
        }

        public void mostrarHora()
        {
            Console.WriteLine("La hora seleccionada es: {0} horas : {1} minutos : {2} segundos", hora, minuto, segundo);
        }
    }

}
