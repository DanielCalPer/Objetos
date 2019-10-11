using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_16
{
    class Alimentos
    {
        public string Nombre { get; set; }
        public int Grasas { get; set; }
        public int Hidratos { get; set; }
        public bool Origenanimal { get; set; }

        public Alimentos(string nombre, int grasas, int hidratos, bool origenanimal)
        {
            Nombre = nombre;
            Grasas = grasas;
            Hidratos = hidratos;
            Origenanimal = origenanimal;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Grasas: {Grasas}, Hidratos: {Hidratos}, Origen animal: {Origenanimal}");
        }
        public bool EsDietetico()
        {
            if (Grasas < 12 && Origenanimal == false)
            {
                return true;
            }
            return false;
        }
        public string ClaveA()
        {
            string nombre, letras, grasas;
            nombre = Nombre.ToString();
            letras = nombre.Substring(0, 3).ToUpper();
            grasas = Grasas.ToString();
            return letras + grasas;
        }
        public double Calorias(int gramos)
        {
            double calorias = gramos * (Grasas * 5.3 + Hidratos * 2.1);
            return calorias;
        }
    }
}
