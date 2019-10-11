using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_12
{
    class Triangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3; 
        }
        public bool EsIsosceles()
        {
            if (!EsEquilatero() && !EsEscaleno())
            {
                return true;
            }
            return false;
        }
        public bool EsEquilatero()
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return true;
            }
            return false;
        }
        public bool EsEscaleno()
        {
            if (Lado1 != Lado2 && Lado2 != Lado3)
            {
                return true;
            }
            return false;

        }
        public double Perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
