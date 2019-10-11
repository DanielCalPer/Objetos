using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_10
{
    class Rectángulo
    {
        public int Largo { get; set; } // en realidad publicos son los get y set, los atributos son privados. 
        public int Ancho { get; set; }

        public Rectángulo()
        {

        }

        public Rectángulo(int largo, int ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }
        public int Area()
        {
            return Largo*Ancho; 
        }
        public double Diagonal()
        {

            return Math.Sqrt(Math.Pow(Largo, 2) + Math.Pow(Ancho, 2)); 
        }
    }
}
