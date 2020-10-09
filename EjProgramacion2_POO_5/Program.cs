using System;

namespace EjProgramacion2_POO_5
{
    class Program
    {
        /*
        Queremos mantener una colección de los libros que hemos ido leyendo,
        poniéndoles una calificacón según nos haya gustado más o menos al leerlo.
        Para ello, crear la clase Libro, cuyos atributos son el título, el autor, el
        número de páginas y la calificación que le damos entre 0 y 10. Crear los
        métodos típicos para poder modificar y obtener los atributos si tienen
        sentido. Posteriormente, crear una clase ConjuntoLibros, que almacena
        un conjunto de libros (con un array de un tamaño fijo). Se pueden añadir
        libros que no existan (siempre que haya espacio), eliminar libros por título
        o autor, mostrar por pantalla los libros con la mayor y menor calificación
        dada y, por último, mostrar un contenido de todo el conjunto.
        Crear una clase PruebaLibros, que realice varias pruebas con las clases
        creadas. En concreto, pruebe a: crear dos libros, añadirlos al conjunto,
        eliminarlos por los dos criterios hasta que el conjunto esté vacío, volver a
        añadir un libro y mostrar el contenido final.
         */
        static void Main(string[] args)
        {
            ConjuntoLibros misLibros = new ConjuntoLibros();
            misLibros.aniadirLibros(0, "Digital Fortress", "Dan Brown", 500, 4);
            Console.WriteLine("Libro 0: {0}, {1}", misLibros.Libros[0].titulo, misLibros.Libros[0].autor);

            misLibros.aniadirLibros(1, "Los pilares de la Tierra", "Ken Follet", 1020, 9);
            Console.WriteLine("Libro 1: {0}, {1}", misLibros.Libros[1].titulo, misLibros.Libros[1].autor);
            Console.WriteLine("____________________________________________________");
            misLibros.miCalificacion();

            misLibros.eliminarLibro("Los pilares de la Tierra", "0");
            misLibros.eliminarLibro("0", "Dan Brown");

            if (misLibros.Libros[0] != null)
                {
                   Console.WriteLine("Primer libro: {0}, {1}", misLibros.Libros[0].titulo, misLibros.Libros[0].autor);
                   
                }
            if (misLibros.Libros[1] != null)
            {
                Console.WriteLine("Segundo libro; {0}, {1}", misLibros.Libros[1].titulo, misLibros.Libros[1].autor);
            }
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("Libro añadido después de borrar:");
            misLibros.aniadirLibros(0, "Cabo Trafalgar", "Arturo Pérez-Reverte", 500, 8);
            Console.WriteLine("Libro: {0}, {1}, Número de páginas: {2}, Calificación: {3}", misLibros.Libros[0].titulo, misLibros.Libros[0].autor, misLibros.Libros[0].nPaginas, misLibros.Libros[0].calificacion);

            misLibros.miCalificacion();
        }
        
    }

    public class Libro
    {
        private int vCalificacion;

        public string titulo { get; set; }
        public string autor { get; set; }
        public int nPaginas { get; set; }
        public int calificacion 
        { 
            get
            { return vCalificacion; }
            set
            {
                if (value < 0 && value > 10)
                    vCalificacion = 0;
                else
                    vCalificacion = value;
            }
        }

    }

    public class ConjuntoLibros
    {
        private Libro[] vLibros = new Libro[3];

        public Libro[] Libros
        {
            get { return vLibros; }
            set { vLibros = value; }

        }

        public void aniadirLibros(int pIndiceLibro, string pTitulo, string pAutor, int pPaginas, int pCalificacion)
        {
            if (Libros[pIndiceLibro] == null)
            {
                if (pIndiceLibro >= 0 && pIndiceLibro <= 2)
                {
                    Libros[pIndiceLibro] = new Libro();
                    Libros[pIndiceLibro].titulo = pTitulo;
                    Libros[pIndiceLibro].autor = pAutor;
                    Libros[pIndiceLibro].nPaginas = pPaginas;
                    Libros[pIndiceLibro].calificacion = pCalificacion;
                }
                else
                    Console.WriteLine("No pueden haber más de 3 libros");
            }
            else
                Console.WriteLine("Ya existe una libro en ese subíndice");
        }
        public void eliminarLibro(string pTitulo, string pAutor)
        {
            for (int i = 0; i <Libros.Length; i ++)
            {
                if (Libros[i] != null)
                {
                    if (Libros[i].titulo == pTitulo || Libros[i].autor == pAutor)
                    {
                        Libros[i] = null;
                        Console.WriteLine("libro " + i + " borrado");
                    }
                }
                
            }  

        }

        public void miCalificacion()
        {
            for (int i = 0; i < Libros.Length; i++)
            {
                if (Libros[i] != null)
                {
                    if (Libros[i].calificacion > 5)
                    {
                        Console.WriteLine(Libros[i].titulo + " Mayor Calificación: " + Libros[i].calificacion);
                    }
                    else if (Libros[i].calificacion <= 5)
                    {
                        Console.WriteLine(Libros[i].titulo + " Menor Calificación: " + Libros[i].calificacion);
                    }
                }

            }
        }


    }
}
