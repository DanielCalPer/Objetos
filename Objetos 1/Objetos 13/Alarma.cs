using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_13
{
    class Alarma
    {
        public double Temperatura { get; set; }
        public bool Timbre { get; set; }

        public Alarma(double temperatura)
        {
            Temperatura = temperatura;
            Timbre = false; 
        }

        public Alarma()
        {
            Console.WriteLine("Introduce la temperatura");
            Temperatura = Convert.ToDouble(Console.ReadLine()); 
            Timbre = false; 
        }
        public bool Comprueba()
        {
            if (Temperatura > 35 || Temperatura < 10)
            {
                return Timbre = true; 
            }
            return false; 
        }
        public void Normaliza()
        {
            Temperatura = 25;
            Timbre = false; 
            
        }
    }
}
