using System;

namespace Objetos_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Consumo consumo = new Consumo(500, 120, 80, "gasolina95");

            Console.WriteLine($"El viaje durará {consumo.GetTiempo()} horas");
            Console.WriteLine($"El consumo medio a los 100km será de {consumo.ConsumoMedio()} litros de {consumo.GetTipodecombustible()}");
            Console.WriteLine($"El consumo en euros a los 100km será de {consumo.ConsumoEuros()} euros");
            Console.WriteLine(); 
            consumo.MostrarDatos(); 

            Console.ReadKey();
        }
    }
}
