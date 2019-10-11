using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_11
{
    class Monedero
    {
        public double Cantidad { get; set; }

        public Monedero(double cantidad)
        {
            Cantidad = cantidad;
        }
        public void MeterDinero(double dinero)
        {
            if (dinero > 0)
            {
                Cantidad += dinero;
            }
            else
            {
                Console.WriteLine("la cantidad no puede ser negativa o 0");
            }

            
        }
        public void SacarDinero(double dinero)
        {

            if (dinero > 0)
            {
                if (dinero <= Cantidad)
                {
                    Cantidad -= dinero;
                }
                else
                {
                    Console.WriteLine("No se puede sacar más dineo del que se dispone en el Monedero");

                }
            }
            else
            {
                Console.WriteLine("La cantidad no puede ser negativa o 0");
            }

        }
        public double Consultar()
        {
            return Cantidad;
        }
    }
}
