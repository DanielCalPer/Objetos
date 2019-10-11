using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_9
{
    class CFecha
    {
        public DateTime Fecha { get; set; }

        public CFecha(DateTime fecha) //CONSTRUCTOR
        {

            Fecha = fecha;
        }
        public int DevolverDia()
        {

            return Fecha.Day;
        }
        public int DevolverMes()
        {

            return Fecha.Month;
        }
        public int DevolverAno()
        {

            return Fecha.Year;
        }
        public int ObtenerEdad() //TimeSpan guarda la diferencia entre 2 fechas
        {

            TimeSpan timeSpan = DateTime.Today - Fecha;
            return timeSpan.Days/365;

        }
        public void Felicitacion()
        {
            Console.WriteLine($"Felicidades, hoy cumples {ObtenerEdad()} años");
        }


    }
}
