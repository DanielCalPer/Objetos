using System;

namespace Objetos_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso peso = new Peso(10, "Lb");
            

            Console.WriteLine(peso.GetLibras());
            Console.WriteLine(peso.GetLingotes());
            Console.WriteLine(peso.GetPeso("li"));

            Console.ReadKey(); 

        }
    }
}
