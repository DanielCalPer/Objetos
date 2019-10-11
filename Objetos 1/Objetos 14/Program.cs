using System;

namespace Objetos_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cifras cifras = new Cifras(18);

            cifras.Divisores();

            Console.WriteLine();

            
            if (cifras.EsPar() == true)
            {
                Console.WriteLine("La cifra es par");
            }
            else
            {
                Console.WriteLine("La cifra NO es par");

            }
            
            Console.WriteLine(cifras.SumaDigitos());

            Console.ReadKey();
        }
    }
}
