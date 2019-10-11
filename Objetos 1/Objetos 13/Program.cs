using System;

namespace Objetos_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarma alarma1 = new Alarma(); 
            Alarma alarma2 = new Alarma(40);

            alarma1.Comprueba();

            if (alarma1.Timbre)
            {
                alarma1.Normaliza();
                Console.WriteLine("Situación normalizada");
            }
 
            alarma2.Comprueba();

            if (alarma2.Timbre)
            {
                alarma2.Normaliza();
                Console.WriteLine("Situación normalizada");

            }
           

            Console.ReadKey();
        }
    }
}
