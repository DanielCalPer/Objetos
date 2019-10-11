using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_15
{
    class Hipoteca
    {
        public int Capital { get; set; }
        public double Redito { get; set; }
        public int Tiempo { get; set; }

        public Hipoteca(int capital, double redito, int tiempo)
        {
            Capital = capital;
            Redito = redito;
            Tiempo = tiempo;
        }
        public double Cuota()
        {
            double cuota;
            double sum = 0;
            for (int i = 1; i <= Tiempo; i++)
            {
                cuota = (Capital * Redito * i) / 100;
                sum += cuota;
            }

            return sum; 
            
        }
        public void MostrarTodo()
        {
            Console.WriteLine($"{Capital} euros, {Redito} % interés, {Tiempo} años");
        }
    }
}
