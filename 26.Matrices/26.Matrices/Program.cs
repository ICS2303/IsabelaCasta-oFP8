namespace _26.Matrices
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            /* //Declaración de matrices
             int[,] numeros = new int[2, 2]; //Se pone número de filas 
             string[,] nombres = new string[2, 3]; //rango = 6 posiciones 

             //Asiganación de datos
             numeros[0, 0] = 25;
             numeros[0, 1] = 46;
             numeros[1, 0] = 42;
             numeros[1, 1] = 78;
             //numeros[1, 2] = 2;

             //Otra forma declarar e inicializar matrices
             string[,] apellidos =
             {
                 {"Chica", "Alvarez"},
                 {"Cardona", "Rios"},
                 {"Lopez", "Mejia"}
             };

             //Recuperar datos de la matriz
             Console.WriteLine(apellidos[1, 1]);

             //Recorrer Matrices - Almacenar datos
             char[,] caracteres = new char[3, 2]; //rango = 6 

             for (int i=0; i<3; i++) //Recorre las filas 
             {
                 for (int j=0; j<2; j++) //Recorres las columnas de cada fila 
                 {
                     Console.WriteLine($"Ingrese el caracter para la posición con indices {i}, {j}");
                     caracteres[i, j] = char.Parse(Console.ReadLine());

                 }
             }
             //Recorrer Matrices - Recuperar datos 
             for (int i = 0; i < caracteres.GetLength(0); i++) //.GetLength(0) devuelve números de filas 
             {
                 for (int j = 0; j < caracteres.GetLength(1); j++) //.GetLength(1) devuelve números de columnas
                 {
                     Console.WriteLine($"Caracter posición {i}, {j}: {caracteres[i, j]}");
                 }
             }

             for (int i = 0; i < caracteres.GetLength(0); i++) //.GetLength(0) devuelve números de filas 
             {
                 for (int j = 0; j < caracteres.GetLength(1); j++) //.GetLength(1) devuelve números de columnas
                 {
                     Console.WriteLine($"{caracteres[i,j]} | ");
                 }
                 Console.WriteLine();
             }

             //Rango de la matriz
             Console.WriteLine(caracteres.Length); */

            int[,] numeros =
             {
                 {10, 10, 10, 10},
                 {10, 10, 10, 10,},
                 {10, 10, 10, 10},
             };

            for (int i = 0; i < numeros.GetLength(0); i++) 
            {
                for (int j = 0; j < numeros.GetLength(1); j++) 
                {
                    Console.Write($"{numeros[i, j]} | ");
                }
                Console.WriteLine();
            }
        }
    }
}
