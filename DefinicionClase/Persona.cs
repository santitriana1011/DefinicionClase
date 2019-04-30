using System;
using System.Collections.Generic;
using System.Text;

namespace DefinicionClase
{
   public class Persona
    {
        //Es para definir todas las propiedades
        #region Propiedades
        public int Edad { get; set; }
        public string Nombre { get; set; }
        #endregion
        
        public void IngresarPersona()
        {
            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            Edad = Convert.ToInt32(Console.ReadLine());
        }
        //Para Listar las personas que se hicieron en el ciclo while hecho en Program
        public void ListarPersonas(List<Persona> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine($"Nombre: { item.Nombre} Edad: {item.Edad}");
            }
        }


    }
}
