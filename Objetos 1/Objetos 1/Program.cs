using System;

namespace Objetos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche("Renault", "Laguna", "Negro", 120, 5); // esto es instanciar una clase. Necesario para usar los métodos(getter, setter, Arrancar)
            Coche coche2 = new Coche(); // strings vacios e ints a 0
            coche2.SetMarca("Ferrari");

            Console.WriteLine(coche2.GetMarca());

            coche.Arrancar();
            Console.ReadLine();

        }
    }
}
