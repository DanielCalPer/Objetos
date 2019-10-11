using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_3
{
    class Numero
    {
        private int num;

        public Numero() // CONSTRUCTOR
        {
            num = 0; // tb se puede no poner nada y dejarlo vacio. Lo iniciaria a 0. En caso de estring lo iniciaria sin valor. 

        }
        public Numero(int numero)
        {
            this.num = numero; 
        }
        public double GetNumero()
        {
            return num;
        }
        public void SetNumero(int numero)
        {
            this.num = numero;
        }
        public void Aniade()
        {
            num++;
        }
        public void resta()
        {
            num--;
        }
        
        public int GetDoble()
        {
            return num*2;
        }
        public int GetTriple()
        {
            return num * 3;
        }
        
    }
    
}
