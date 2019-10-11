using System;

namespace Objetos_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Monedero monedero = new Monedero(100);

            monedero.MeterDinero(100);
            monedero.SacarDinero(120);
            monedero.SacarDinero(2000);
            monedero.SacarDinero(-200);

            Console.WriteLine(monedero.Consultar());


            Console.ReadKey(); 
        }
    }
}
