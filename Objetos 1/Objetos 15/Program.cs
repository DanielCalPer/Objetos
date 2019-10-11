using System;

namespace Objetos_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Hipoteca hipoteca = new Hipoteca(6000, 3.5, 20);


            Console.WriteLine($"CAPITAL: {hipoteca.Capital} RÉDITO: {hipoteca.Redito}");
            Console.WriteLine($"TIEMPO:\t\t CUOTA:");

            double cuota;
            for (int i = 1; i <= hipoteca.Tiempo; i++)
            {
                cuota = (hipoteca.Capital * hipoteca.Redito * i) / 100;
                Console.WriteLine($" {i} \t \t {cuota}");
            }

            Console.WriteLine(); 
            Console.WriteLine($"Cuota total: {hipoteca.Cuota()}");
            hipoteca.MostrarTodo();
          
            Console.ReadKey();
        }
    }
}
