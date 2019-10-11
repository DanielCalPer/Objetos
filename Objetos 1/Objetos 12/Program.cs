using System;

namespace Objetos_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo(5,5,5); 
            Triangulo triangulo2 = new Triangulo(6,5,2); 
            Triangulo triangulo3 = new Triangulo(5,5,3);

            if (triangulo1.EsEquilatero())
            {
                Console.WriteLine($"triangulo1 es equilatero");
            }

            if (triangulo2.EsEscaleno())
            {
                Console.WriteLine($"triangulo2 es escaleno");

            }

            if (triangulo3.EsIsosceles())
            {
                Console.WriteLine($"triangulo3 es isosceles");
            }
            
            
            Console.ReadKey();
        }
    }
}
