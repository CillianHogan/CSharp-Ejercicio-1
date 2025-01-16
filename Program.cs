using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio 1. Crea un programa que muestre la pregunta "¿Cómo te llamas?" y luego espere a que el usuario escriba su nombre, 
            almacenando la entrada en una variable. Finalmente, debe mostrar el saludo "¡Hola, <nombre>!".
            */

            // Declara una variable para almacenar el nombre del usuario
            string nombre = "";

            // Pregunta al usuario su nombre
            Console.WriteLine("¿Cómo te llamas?");

            // Lee la entrada del usuario y la almacena en la variable
            nombre = Console.ReadLine();

            // Muestra el saludo con el nombre del usuario
            Console.WriteLine("¡Hola " + nombre + "!");
        }
    }
}
