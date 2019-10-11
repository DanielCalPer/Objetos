using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_4
{

    public class Satelite

    {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;

        public Satelite(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public Satelite()
        {
            meridiano = paralelo = distancia_tierra = 0;
        }


        public void SetPosicion(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }
        public void PrintPosicion()
        {
            Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo + " Meridiano "+meridiano+" a una distancia de la tierra de "+distancia_tierra+" Kilómetros");
            Console.ReadLine();
        }
        public void VariaAltura(double desplazamiento)
        {
            this.distancia_tierra += desplazamiento;
        }
        public bool EnOrbita(double d)
        {
            if (d > 0)
            {
                Console.WriteLine("El satélite está en órbita");
                return true;
            }
            Console.WriteLine("El satélite NO esta en órbita");
            return false;
        }
        public void VariaPosicion(double variap, double variam)
        {
            meridiano = variam;
            paralelo = variap;  
        }
    }
}
