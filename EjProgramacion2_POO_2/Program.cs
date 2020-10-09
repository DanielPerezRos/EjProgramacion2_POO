using System;

namespace EjProgramacion2_POO_2
{
    class Program
    {
        /*
         Crear una clase Coche, a través de la cual se pueda conocer el color del
        coche, la marca, el modelo, el número de caballos, el número de puertas
        y la matrícula. Crear el constructor del coche, así como los métodos que
        considere necesarios.
        Crear una clase PruebaCoche (Program) que instancie varios coches, cambiándole el
        color a lo largo de la vida a algunos de ellos y mostrándolo por pantalla. 
         */
        static void Main(string[] args)
        {
            Coche unCoche = new Coche();
            unCoche.marca = "Volkswagen";
            unCoche.modelo = "Polo";
            unCoche.caballos = 160;
            unCoche.color = "Negro";
            unCoche.puertas = 5;
            unCoche.matricula = "000XXX";

            unCoche.mostrarCoche();
           
        }
    }

    class Coche
    {
        private int vPuertas;
        private int vCV;

        public string color { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public int caballos
        {
            get
            {
                return vCV;
            }
            set
            {
                if (value > 0)
                    vCV = value;
                else
                    vCV = 0;
            }
        }

        public int puertas
        {
            get
            {
                return vPuertas;
            }
            set
            {
                if (value > 0)
                    vPuertas = value;
                else
                    vPuertas = 0;
            }
        }

        public string matricula { get; set; }

        public void mostrarCoche()
        {
            Console.WriteLine("Datos del coche \n-----------------\nColor: {0}\nMarca: {1}\nModelo: {2}\nCaballos: {3}\nPuertas: {4}\nMatrícula: {5}", color, marca, modelo, caballos, puertas, matricula);
        }
    }
}
