using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_8
{
    class Consumo
    {
        private double kms;
        private double litros;
        private double vmed;
        private string tipodecombustible;
 

        public Consumo(double kms, double vmed, double litros, string tipodecombustible)
        {
            this.kms = kms;
            this.vmed = vmed;
            this.litros = litros;
            this.tipodecombustible = tipodecombustible;
    }
        public string GetTiempo() // pasamos el tiempo a horas mins seg,
        {
            double horas = kms / vmed;
            int segundos = Convert.ToInt32(horas * 3600);
            int h = segundos / 3600;
            int m = (segundos % 3600) / 60;
            int s = (segundos % 3600) % 60;
            return $"{h} h {m} m {s} s";
            
        }
        public double ConsumoMedio()
        {

            return (litros/kms)*100; 
        }
        public string GetTipodecombustible()
        {
            return tipodecombustible;
        }
        public double ConsumoEuros()
        {
            double precio = 0; 

            if (tipodecombustible.ToLower() == "gasolina95")
            {
                precio = 1.14;
            }
            else if (tipodecombustible.ToLower() == "gasolina98")
            {
                precio = 1.25;
            }
            else if (tipodecombustible.ToLower() == "diesel")
            {
                precio = 1.04;
            }
           

            return ConsumoMedio() * precio;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($" Km recorridos: {kms} km \n Litros consumidos: {litros} L \n Velocidad media: {vmed} km/h \n Combustible usado: {GetTipodecombustible()} \n Tempo viaje: {GetTiempo()} horas \n Consumo Medio: {ConsumoMedio()} l/100km \n Precio: {ConsumoEuros()} €/100km");
        }

       
            
    }
}
