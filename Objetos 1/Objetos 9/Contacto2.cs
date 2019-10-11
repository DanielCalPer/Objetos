using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_9
{
    class Contacto2
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public DateTime Fechadenacimiento { get; set; }
        public String Tipodecontacto { get; set; }

        public Contacto2(string nombre, int telefono, string fechadenacimiento, string tipodecontacto) //CONSTRUCTOR 1
        {
            Nombre = nombre;
            Telefono = telefono;
            Fechadenacimiento = Convert.ToDateTime(fechadenacimiento);
            Tipodecontacto = tipodecontacto;

            switch (tipodecontacto.ToLower())
            {
                case "familia":
                    tipodecontacto = "familia";
                    break;
                case "amigos":
                    tipodecontacto = "amigos";
                    break;
                case "trabajo":
                    tipodecontacto = "trabajo";
                    break;
                case "estudios":
                    tipodecontacto = "estudios";
                    break;
                default:
                    tipodecontacto = "amigos";
                    break;
            }

        }

        public Contacto2(string nombre, string fechadenacimiento, string tipodecontacto) // CONSTRUCTOR 2
        {
            Nombre = nombre;

            // Esto tb puede hacerse TryParse si en vez de una DateTime para la fechadenacimiento tomamos un string. 

            DateTime fecha;
            if (DateTime.TryParse(fechadenacimiento, out fecha))
            {
                if (fecha.Year > 1920 && fecha < DateTime.Today)
                {
                    Fechadenacimiento = Convert.ToDateTime(fecha);
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
            Tipodecontacto = tipodecontacto;

        }

        public Contacto2(string nombre, int telefono, string tipodecontacto) // CONSTRUCTOR 3
        {
            Nombre = nombre;
            Telefono = telefono;
            Fechadenacimiento = DateTime.Today;
            Tipodecontacto = tipodecontacto;
        }
        public Contacto2(string nombre, string fechadenacimiento) // CONSTRUCTOR 4
        {
            Nombre = nombre;
            Tipodecontacto = "Amigos";

        }
        public void MostrarDatos()
        {

            Console.WriteLine($"Nombre: {Nombre} \n Teléfono: {Telefono} \n Fecha de nacimiento: {Fechadenacimiento} \n Tipo de contacto: {Tipodecontacto}");

        }
    } 
}