using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_5
{
    class Peso
    {
        private double kilos;
        
        

        public Peso(double peso, string medida) //CONSTRUCTOR
        {
            this.kilos = peso;
            switch (medida.ToLower())
            {
                case "lb":
                    kilos = peso / 0.453;
                    break;

                case "li":
                    kilos = peso * 14.59;
                    break;

                case "oz":
                    kilos = peso * 0.02835;
                    break;

                case "p":
                    kilos = peso * 0.0015;
                    break;

                case "k":
                    kilos = peso;
                    break;

                case "g":
                    kilos = peso * 0.001; ; 
                    break;

                case "q":
                    kilos = peso * 43.3;
                    break;

                default:
                    Console.WriteLine("No has introducido una medida válida");
                    break;
            }
            
            
        }

        public double GetLibras()
        {
            return kilos *0.453;
        }
        public double GetLingotes()
        {
            return kilos*14.59;
        }
        public double GetPeso(string medida)
        {
            double peso=1;

            switch (medida.ToLower())
            {
                case "lb":
                    peso = peso / 0.453;
                    break;

                case "li":
                    peso = peso / 14.59;
                    break;

                case "oz":
                    peso = peso / 0.02835;
                    break;

                case "p":
                    peso = peso / 0.00155;
                    break;

                case "k":
                    peso = peso;
                    break;

                case "g":
                    peso = peso / 0.001;
                    break;

                case "q":
                    peso = peso / 43.3;
                    break;

                default:
                    Console.WriteLine("No has introducido una medida válida");
                    break;
            }

            return peso; 
        }
    }
}
