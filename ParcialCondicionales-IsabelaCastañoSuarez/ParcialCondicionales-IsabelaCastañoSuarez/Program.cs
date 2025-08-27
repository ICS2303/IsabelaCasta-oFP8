using System.ComponentModel.Design;

namespace ParcialCondicionalesIsabelaCastañoSuarez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un conjunto de personas ha sido clasificado en cuatro grupos denominados A, B, C y D, en función de tres criterios: 
            sexo, edad y el último dígito del documento de identidad. La asignación a los grupos se realiza de acuerdo con las siguientes reglas:

            Grupo A
            Pertenecen al grupo A las personas que cumplan alguna de estas dos condiciones:
            Mujeres con edad entre 16 y 20 años, y cuyo documento de identidad termine en 0, 4 o 8.
            Hombres con edad entre 18 y 22 años, y cuyo documento de identidad termine en 1, 5 o 9.
            
            Grupo B
            Pertenecen al grupo B las personas que cumplan alguna de estas dos condiciones:
            Mujeres con edad entre 21 y 25 años, y cuyo documento de identidad termine en 3 o 7.
            Hombres con edad entre 23 y 26 años, y cuyo documento de identidad termine en 2 o 6.
            
            Grupo C
            Pertenecen al grupo C las personas (sin distinción de sexo) que tengan 15 años de edad y que dominen el idioma inglés.
            
            Grupo D
            Pertenecen al grupo D todas aquellas personas que no cumplen con ninguno de los criterios anteriores.
            
            Objetivo del programa
            Desarrolla un programa que solicite al usuario ingresar los siguientes datos:
            Sexo (masculino o femenino),
            Edad (en años),
            Último dígito del documento de identidad (número del 0 al 9),
            Dominio del idioma inglés (en caso de que tenga 15 años).
            El programa debe analizar la información ingresada y mostrar en pantalla a qué grupo pertenece la persona.*/

            int edad = 0;
            string sexo = "";
            int digitodocumento = 0;
            string Grupo = "";
            string respuesta = "";
            bool dominaingles = false;

            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo: Femenino o masculino");
            sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el último digito de su documento de ideantidad: (0-9) ");
            digitodocumento = Convert.ToInt32(Console.ReadLine());

            if (edad == 15)
            {
                Console.WriteLine("Domina el ingles: (Si / No)");
                respuesta = Console.ReadLine();
                if (respuesta == "Si")
                {
                    dominaingles = true;
                }
            }

            if (sexo == "Femenino" && edad >= 16 && edad <= 20 && (digitodocumento == 0 || digitodocumento == 4 || digitodocumento == 8))
            {
                Grupo = "A";
            }
            else if (sexo == "Masculino" && edad >= 18 && edad <= 22 && (digitodocumento == 1 || digitodocumento == 5 || digitodocumento == 9))
            {
                Grupo = "A";
            }

            if (sexo == "Femenino" && edad >= 21 && edad <= 25 && (digitodocumento == 3 || digitodocumento == 7))
            {
                Grupo = "B";
            }
            else if (sexo == "Masculino" && edad >= 23 && edad <= 26 && (digitodocumento == 2 || digitodocumento == 6))
            {
                Grupo = "B";
            }
            if (edad == 15 && dominaingles)
            {
                Grupo = "C";
            }
            else
            {
                Grupo = "D";
            }
            Console.WriteLine($"La persona pertenece al grupo: {Grupo}");

        }
    }
}
