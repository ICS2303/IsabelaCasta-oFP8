namespace _27.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*27. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.
 
            Requisitos del programa:
            Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
            Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3).
            Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas). */

            int[,] matriz1 = new int[2, 3];
            for (int a = 0; a < matriz1.GetLength(0); a++)
            {
                for (int b = 0; b < matriz1.GetLength(1); b++)
                {
                    Console.WriteLine($"Ingrese el número para la posición con índices {a}, {b}:");
                    matriz1[a, b] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] matriz2 = new int[2, 3];
            for (int c = 0; c < matriz2.GetLength(0); c++)
            {
                for (int d = 0; d < matriz2.GetLength(1); d++)
                {
                    Console.WriteLine($"Ingrese el número para la posición con índices {c}, {d}:");
                    matriz2[c, d] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] suma = new int[2, 3];
            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("\nLa matriz resultante de la suma es:");
            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    Console.Write(suma[i, j] + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}
