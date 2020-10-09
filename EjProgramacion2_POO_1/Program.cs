using System;

namespace EjProgramacion2_POO_1
{
    class Program
    {
        /*
        Crear una clase Rectangulo, con atributos base y altura. Crear también el constructor de la clase 
        y los métodos necesarios para calcular el área y el perímetro. 
        Crear otra clase PruebaRectangulo (Program) que pruebe varios rectángulos y muestre por pantalla sus áreas y perímetros.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Area y Perímetro del rectángulo");
            Console.WriteLine("Ingrese el valor del lado a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado b");
            int b = Convert.ToInt32(Console.ReadLine());
           
            Rectangulo rectangulo1 = new Rectangulo(a , b);

            int area1 = rectangulo1.calcularArea();
            Console.WriteLine("El area es " + area1);

            int perimetro1 = rectangulo1.calcularPerimetro();
            Console.WriteLine("El perimetro es " + perimetro1);

            Console.WriteLine("----------------------------------------------");

            Rectangulo rectangulo2 = new Rectangulo(5, 8);

            int area2 = rectangulo2.calcularArea();
            Console.WriteLine("El area de un rectángulo de lados 5 y 8 es " + area2);

            int perimetro2 = rectangulo2.calcularPerimetro();
            Console.WriteLine("El perímetro de un rectángulo de lados 5 y 8 es " + perimetro2);
        }
    }
    class Rectangulo
    {
         public int baseR { get; set; }   // Propiedad
         public int alturaR { get; set; } // Propiedad

        public Rectangulo(int pBase, int pAltura)  // Constructor
        {
            baseR = pBase;
            alturaR = pAltura;
        }

        
        public int calcularArea() // firma del método
        {
            return baseR * alturaR;
        }
        public int calcularPerimetro() // firma del método
        { 
            return (baseR * 2) + (alturaR * 2);
        }
    }
}
