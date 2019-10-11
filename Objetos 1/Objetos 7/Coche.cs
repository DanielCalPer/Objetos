using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_7
{
    class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        

        public Coche() // CONSTRUCTOR VACIO
        {
            
        }
        public Coche(string marca, string modelo) // CONSTRUCTOR CON PARÁMETROS
        {
            Marca = marca;
            Modelo = modelo; 
        }
        
        public string MostrarTodo()
        {
            return $"Marca: {Marca} Modelo: {Modelo}"; 
            
        }
    }


}
