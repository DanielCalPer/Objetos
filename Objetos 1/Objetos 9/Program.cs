using System;

namespace Objetos_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto("David", 666555111, "30/06/1990");
            Contacto contacto2 = new Contacto("Javier", "10/05/19000"); // necesario TryParse
            Contacto contacto3 = new Contacto("Laura", 666555111);

            //contacto1.MostrarDatos();
            //contacto2.MostrarDatos();
            //contacto3.MostrarDatos();

            Contacto Miren = new Contacto("Miren", 944123456, "4 / 2 / 1990");
            Contacto Jon = new Contacto("Jon", 931212123);
            Contacto Ane = new Contacto("Ane", "12/10/1993");
            Contacto Julen = new Contacto("Julen", 944123321, ("4 / 2 / 1992"));

            CFecha fecha1 = new CFecha(Miren.Fechadenacimiento);
            CFecha fecha2 = new CFecha(Jon.Fechadenacimiento);
            CFecha fecha3 = new CFecha(Ane.Fechadenacimiento);
            CFecha fecha4 = new CFecha(Julen.Fechadenacimiento);

            Miren.MostrarDatos();
            Jon.MostrarDatos();
            Ane.MostrarDatos();
            Julen.MostrarDatos();

            Console.WriteLine($"{Miren.Nombre} tiene {fecha1.ObtenerEdad()} años");
            Console.WriteLine($"{Jon.Nombre} tiene {fecha2.ObtenerEdad()} años");
            Console.WriteLine($"{Ane.Nombre} tiene {fecha3.ObtenerEdad()} años");
            Console.WriteLine($"{Julen.Nombre} tiene {fecha4.ObtenerEdad()} años");

            if (Miren.Fechadenacimiento == DateTime.Today)
            {
                fecha1.Felicitacion();
            }
            else
            {
                Console.WriteLine("Feliz querido NO CUMPLEAÑOS");
            }
            if (Jon.Fechadenacimiento == DateTime.Today)
            {
                fecha2.Felicitacion();
            }
            else
            {
                Console.WriteLine("Feliz querido NO CUMPLEAÑOS");
            }
            if (Ane.Fechadenacimiento == DateTime.Today)
            {
                fecha3.Felicitacion();
            }
            else
            {
                Console.WriteLine("Feliz querido NO CUMPLEAÑOS");
            }
            if (Julen.Fechadenacimiento == DateTime.Today)
            {
                fecha4.Felicitacion();
            }
            else
            {
                Console.WriteLine("Feliz querido NO CUMPLEAÑOS");
            }

            Contacto2 Miren2 = new Contacto2("Miren", 944123456, "4 / 2 / 1990", "Amigos");
            Contacto2 Jon2 = new Contacto2("Jon", 456221546, "Trabajo");
            Contacto2 Ane2 = new Contacto2("Ane", "12/10/1993", "Familia");
            Contacto Julen2 = new Contacto("Julen", 944123321, ("4 / 2 / 1992"));
            Contacto2 Jone2 = new Contacto2("Jone", "6 / 6 / 1992");
            Contacto2 Mikel2 = new Contacto2("Mikel", "7 / 7 / 1997", "Familia");

            Miren2.MostrarDatos(); 
            Jon2.MostrarDatos(); 
            Ane2.MostrarDatos(); 
            Julen2.MostrarDatos(); 
            Jone2.MostrarDatos(); 
            Mikel2.MostrarDatos(); 


            Console.ReadKey();
        }
    }
}
