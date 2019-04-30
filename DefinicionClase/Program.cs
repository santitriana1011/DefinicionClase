using System;
using System.Collections.Generic;

namespace DefinicionClase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Asi se instancia
                //    Persona per = new Persona();
                //    Persona per2 = new Persona();
                //    Persona per3 = new Persona();
                List<Persona> personas = new List<Persona>();
                ////Fin de la Instancia
                ////Se le dan las propiedades a la instancia
                //    per.Nombre = "KJ";
                //    per.Edad = 18;
                //    //Para que nos muestre en pantalla
                //    Console.WriteLine($"Nombre:{per.Nombre} Edad: {per.Edad}");
                //    Console.WriteLine("Ingrese su nombre");
                //    per2.Nombre = Console.ReadLine();
                //    Console.WriteLine("Ingrese su edad");
                //    per2.Edad = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine($"Nombre:{per2.Nombre} Edad: {per2.Edad}");
                //    per3.IngresarPersona();
                //    personas.Add(per);
                //    personas.Add(per2);
                //    personas.Add(per3);
                //    //Para Recorrer la lista
                //    foreach (var item in personas)
                //    {
                //        Console.WriteLine($"Nombre: { item.Nombre} Edad: {item.Edad}");
                //    }
                // Ejercicio Ingresar Personas que desee
                Console.WriteLine("¿Desea Ingresar Personas? SI / NO");
                var res = Console.ReadLine();
                while (res == "s")
                {
                    Persona per4 = new Persona();
                    per4.IngresarPersona();
                    personas.Add(per4);
                    Console.WriteLine("¿Desea Ingresar Personas? SI / NO");
                    res = Console.ReadLine();
                }
                Persona per = new Persona();
                per.ListarPersonas(personas);
                Console.ReadLine();

            }
            catch (Exception)
            {

                Console.WriteLine("Ha ocurrido un error faltal. Solucionalo ya Bastardo");
                Console.ReadLine();
            }
        }
    }
}
