using System.Security.Cryptography;
using System.Xml.Linq;

namespace ParcialArreglosIsabelaCastaño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Desarrolla un programa que permita registrar y analizar las ventas de computadores en una red de cinco almacenes 
            durante los siete días de una semana.Para ello, se utilizará una matriz bidimensional Ventas[5][7], 
            donde cada fila representa un almacén y cada columna un día de la semana(de lunes a domingo).
            Requisitos del programa:
            Ingreso de datos con validación:
            Permitir al usuario ingresar las ventas diarias de cada almacén (valores enteros no negativos).
            Validar que los datos ingresados sean numéricos y mayores o iguales a cero. Si el usuario ingresa un valor inválido, solicitar el dato nuevamente.
            Visualización de la matriz:
            Mostrar por pantalla la matriz de ventas en forma tabular.
            Cálculos estadísticos:
            Calcular y mostrar el promedio semanal de ventas por cada almacén (promedio por fila).
            Calcular y mostrar el promedio de ventas por día, específicamente para:
            Lunes (columna 0)
            Viernes (columna 4)
            Mostrar el valor mínimo y máximo de ventas registrados en toda la matriz, e indicar en qué almacén y qué día ocurrieron.
            Calcular los siguientes datos:
            Determinar cuál fue el almacén con mayor promedio de ventas durante la semana.
            Determinar cuál fue el día de la semana con mayores ventas totales entre todos los almacenes. */

            int[,] ventas = new int[5, 7];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            // Ingreso de datos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Almacén " + (i + 1));
                for (int j = 0; j < 7; j++)
                {
                    int num = -1;
                    while (num < 0)
                    {
                        Console.Write("Ventas del " + dias[j] + ": ");
                        string dato = Console.ReadLine();
                        if (dato != "")
                        {
                            num = Convert.ToInt32(dato);
                            if (num < 0)
                                Console.WriteLine("Ingrese un número mayor o igual a 0.");
                        }
                    }
                    ventas[i, j] = num;
                }
            }

            // Mostrar matriz
            Console.WriteLine("Matriz de ventas:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                    Console.Write(ventas[i, j] + "\t");
                Console.WriteLine();
            }

            // Promedio semanal por almacén
            Console.WriteLine("Promedio semanal por almacén:");
            int[] promAlmacen = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int suma = 0;
                for (int j = 0; j < 7; j++)
                    suma += ventas[i, j];
                promAlmacen[i] = suma / 7;
                Console.WriteLine("Almacén " + (i + 1) + ": " + promAlmacen[i]);
            }

            // Promedio lunes y viernes
            Console.WriteLine("Promedio de ventas Lunes y Viernes:");
            for (int d = 0; d < 7; d++)
            {
                if (d == 0 || d == 4)
                {
                    int suma = 0;
                    for (int i = 0; i < 5; i++)
                        suma += ventas[i, d];
                    Console.WriteLine(dias[d] + ": " + (suma / 5));
                }
            }

            // Mínimo y máximo
            // aMax, aMin significa el maximo y minimo del almacen 
            // dMax, dMin significa el maximo y minimo del día 

            int min = ventas[0, 0], max = ventas[0, 0];
            int aMin = 0, dMin = 0, aMax = 0, dMax = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (ventas[i, j] < min) { min = ventas[i, j]; aMin = i; dMin = j; }
                    if (ventas[i, j] > max) { max = ventas[i, j]; aMax = i; dMax = j; }
                }
            }
            Console.WriteLine("Mínimo: " + min + " (Almacén " + (aMin + 1) + ", " + dias[dMin] + ")");
            Console.WriteLine("Máximo: " + max + " (Almacén " + (aMax + 1) + ", " + dias[dMax] + ")");

            // Almacén con mayor promedio
            int mayorProm = promAlmacen[0], mejor = 0;
            for (int i = 1; i < 5; i++)
                if (promAlmacen[i] > mayorProm) { mayorProm = promAlmacen[i]; mejor = i; }
            Console.WriteLine("Almacén con mayor promedio: " + (mejor + 1));

            // Día con mayores ventas totales
            int mejorDia = 0, totalMax = 0;
            for (int j = 0; j < 7; j++)
            {
                int suma = 0;
                for (int i = 0; i < 5; i++)
                    suma += ventas[i, j];
                if (suma > totalMax) { totalMax = suma; mejorDia = j; }
            }
            Console.WriteLine("Día con mayores ventas: " + dias[mejorDia]);

        }
    }
}
