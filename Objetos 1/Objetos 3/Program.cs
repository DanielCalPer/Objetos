using System;

namespace Objetos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Numero numero1 = new Numero(5);

            numero.Aniade(); // suma 1
            Console.WriteLine(numero.GetNumero()); // devuelveme el numero modificado
            numero1.SetNumero(numero1.GetTriple());
            numero1.SetNumero(numero1.GetDoble());
            
            Console.WriteLine(numero1.GetNumero());


            Console.ReadKey();
        }
    }
}
