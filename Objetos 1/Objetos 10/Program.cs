using System;

namespace Objetos_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectángulo rectangulo1 = new Rectángulo();
            Rectángulo rectangulo2 = new Rectángulo(4, 5);

            rectangulo1.Largo = 5; 
            rectangulo1.Ancho = 10; 


            Console.WriteLine(rectangulo1.Area()); 
            Console.WriteLine(rectangulo1.Diagonal()); 
            Console.WriteLine(rectangulo2.Area()); 
            Console.WriteLine(rectangulo2.Diagonal()); 

            Console.ReadKey();
        }
    }
}
