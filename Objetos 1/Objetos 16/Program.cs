using System;

namespace Objetos_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alimentos alimentos1 = new Alimentos("Solomillo", 200, 30, true); 
            Alimentos alimentos2 = new Alimentos("Lechuga", 0, 10, false);

            alimentos1.MostrarAtributos(); 
            alimentos2.MostrarAtributos();

            Console.WriteLine($"Es diatético: {alimentos1.EsDietetico()}");
            Console.WriteLine($"Es diatético: {alimentos2.EsDietetico()}");
            
            Console.WriteLine($"Su clave será: {alimentos1.ClaveA()}");
            Console.WriteLine($"Su clave será: {alimentos2.ClaveA()}");

            Console.WriteLine($"El alimento contiene: {alimentos1.Calorias(200)} calorias");
            Console.WriteLine($"El alimento contiene: {alimentos2.Calorias(200)} calorias");
            
          


            Console.ReadKey(); 
        }
    }
}
