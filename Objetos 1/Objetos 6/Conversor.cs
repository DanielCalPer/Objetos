using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_6
{
    class Conversor
    {

        public double Millas { get; set; } // llamarlo escribirendo prop + tab + tab
        public double Unidad { get; set; }

        public Conversor(double millas, double unidad)
        {
            Millas = millas; // como el this. La Mayuscula los diferencia. 
            Unidad = unidad; 
        }
        public double MillasAMetros()
        {
            return Millas * Unidad;
        }
        public double MillasAKm()
        {
            return MillasAMetros() / 1000;
        }

        //public Conversor(double millas) // CONSTRUCTOR
        //{           
        //    this.Unidad = 1852;
        //    this.Millas = millas; 

        //}




    }
}
