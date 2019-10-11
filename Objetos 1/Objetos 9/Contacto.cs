using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_9
{
    class Contacto
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public DateTime Fechadenacimiento { get; set; }

        public Contacto(string nombre, int telefono, string fechadenacimiento) //CONSTRUCTOR 1
        {
            Nombre = nombre;
            Telefono = telefono;
            Fechadenacimiento = Convert.ToDateTime(fechadenacimiento);
        }

        public Contacto(string nombre, string fechadenacimiento) // CONSTRUCTOR 2
        {
            Nombre = nombre;

            // Esto tb puede hacerse TryParse si en vez de una DateTime para la fechadenacimiento tomamos un string. 

            DateTime fecha;
            if (DateTime.TryParse(fechadenacimiento, out fecha))
            {
                if (fecha.Year > 1920 && fecha < DateTime.Today)
                {
                    Fechadenacimiento = fecha;
                }

                else
                {
                    Fechadenacimiento = DateTime.Today;
                }
            }
            else
            {
                Fechadenacimiento = DateTime.Today;
            }


        }

        public Contacto(string nombre, int telefono) // CONSTRUCTOR 3
        {
            Nombre = nombre;
            Telefono = telefono;
            Fechadenacimiento = DateTime.Today;
        }

        public void MostrarDatos()
        {

            Console.WriteLine($"Nombre: {Nombre} \n Teléfono: {Telefono} \n Fecha de nacimiento: {Fechadenacimiento}");

        }
       
    }
}
