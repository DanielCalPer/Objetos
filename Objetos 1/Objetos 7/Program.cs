using System;

namespace Objetos_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche(); // objeto 1
            Coche coche1 = new Coche("Renault", "Megane"); // Objeto 2

            coche.Marca = "Ferrari";
            coche.Modelo = "Testarosa";


            Console.WriteLine(coche.MostrarTodo());
            
            Console.WriteLine(coche1.MostrarTodo()); 
            

            Console.ReadKey(); 

        }
    }
}
