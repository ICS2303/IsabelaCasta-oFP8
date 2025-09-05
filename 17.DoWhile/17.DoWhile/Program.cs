using System.Xml.Schema;

namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Algoritmo que genere y calcule la suma de los 5 primeros números enteros positivos//

            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador += contador;
            } while (contador < 5);
            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");

            /*17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. 
            Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.*/

            int numero = 0;
            int multiplicación = 0;

            string respuesta = " ";


            do
            {
                Console.WriteLine("Ingrese un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                do
                {
                    multiplicación++;
                    Console.WriteLine($"{numero} * {multiplicación} = {numero * multiplicación}");
                } while (multiplicación < 10);
                multiplicación = 0; 

                Console.WriteLine("¿Desea ingresar otro número? (Si/No)");
                respuesta = Console.ReadLine().ToLower();


            } while (respuesta == "si");
        }
    }
}
