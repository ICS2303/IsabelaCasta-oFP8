namespace _28.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*28. Clasificación de números en una matriz 
            Desarrolla una aplicación que realice las siguientes tareas: 
            Solicita al usuario que ingrese las dimensiones de una matriz (número de filas y columnas). 
            Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 
            Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, cuántos son negativos y cuántos son ceros. 
            Finalmente, muestra por pantalla los totales obtenidos para cada categoría (positivos, negativos y ceros). */
            
            int filas = 0;
            int columnas = 0;
            int positivos = 0;
            int negativos = 0; 
            int ceros = 0;

            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese un número entero para la posición [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] > 0)
                    {
                        positivos++;
                    }
                    else if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        ceros++;
                    }
                }
            }

            Console.WriteLine($"Cantidad de números positivos: {positivos}");
            Console.WriteLine($"Cantidad de números negativos: {negativos}");
            Console.WriteLine($"Cantidad de ceros: {ceros}");
        }
    }
}
