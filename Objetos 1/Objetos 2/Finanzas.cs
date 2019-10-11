using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_2
{
    class Finanzas // MOLDE
    {
        
        private double cambio; 

        public Finanzas() // CONSTRUCTOR
        {
            cambio = 0.92;

        }
        public Finanzas(double cambio) // CONSTRUCTOR
        {  
            this.cambio = cambio;

        }
        public double DolaresToEuros(double dolares)
        {
            return dolares*cambio;
        }
        public double EurosToDolares(double euros)
        {
            return euros/cambio; 
        }
       
    }
}
