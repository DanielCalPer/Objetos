using System;

namespace Objetos_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor(500, 1852);
            conversor.Millas = 100; 
            Console.WriteLine($"{conversor.Millas} millas son: {conversor.MillasAMetros()} metros");
            Console.WriteLine($"{conversor.Millas} millas son: {conversor.MillasAKm()} kilómetros");
            
            Console.ReadKey();
        }
    }
}
