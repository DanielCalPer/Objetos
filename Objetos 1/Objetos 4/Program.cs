using System;

namespace Objetos_4
{
    class Program
    {
       /* Modifica la clase satélite y añádele los siguientes métodos:
        Método void VariaAltura(double desplazamiento): Este método acepta un parámetro que será positivo o negativo dependiendo de si el satélite tiene que alejarse o acercarse a La Tierra.
        Método bool EnOrbita(): Este método devolverá false si el satélite está en tierra, y true en caso contrario.
        Método void VariaPosicion(double variap, double variam): Este método permite modificar los atributos de posición(meridiano y paralelo) mediante los parámetros variap y variam.Estos parámetros serán valores positivos o negativos relativos que harán al satélite modificar su posición.*/
        static void Main(string[] args)
        {
            Satelite satelite = new Satelite();
            Satelite satelite1 = new Satelite(5, 10, 20);

            satelite1.VariaAltura(5);
            satelite1.VariaPosicion(15, 30);
            satelite1.EnOrbita(10);

            satelite1.PrintPosicion();


            Console.ReadKey(); 
        }
    }
}
