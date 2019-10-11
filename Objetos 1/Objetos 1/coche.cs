using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_1
{
    class Coche // molde con atributos
    {
        private string marca;
        private string modelo;
        private string color;
        private int caballos;
        private int puertas;

        public Coche(string marca, string modelo, string color, int caballos, int puertas) // CONSTRUCTOR
        {
            this.marca = marca; // this. diferencia que el atributo es el que decimos y no el dado por parámetros
            this.modelo = modelo;
            this.color = color;
            this.caballos = caballos;
            this.puertas = puertas;
        }
        public Coche() // CONSTRUCTOR VACIO. Puede estar vacio o darle valores y cada vez que llamemos a un coche vacio lo devuelve con sus atributos. 
        {
            marca = "Porsche";
            modelo = "Carrera";
            color = "rojo";
            caballos = 200;
            puertas = 5;
        }

        // getters y setter: get para acceder y set para modificar (son métodos)

        public string GetMarca() // Métodos de acceso. devuelve la marca del coche
        {
            return marca;
        }
        public void SetMarca(string marca) // modifica el valor de la marca
        {
            this.marca = marca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetCaballos()
        {
            return caballos.ToString();
        }
        public void SetCaballos(int caballos)
        {
            this.caballos = caballos;
        }
        public string GetPuertas()
        {
            return puertas.ToString();
        }
        public void SetPuertas(int puertas)
        {
            this.puertas = puertas;
        }
        public void Arrancar() // sirve para cualquier coche
        {
            Console.WriteLine($"El {marca} {modelo} ha arrancado");
        }
    }
}
