namespace _25.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear arreglo de 10 elementos
            int[] numeros = new int[10];
            int suma = 0;

            // Solicitar 10 números al usuario
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i]; // Acumular la suma
            }

            // Calcular el promedio (con división entera)
            int promedio = suma / numeros.Length;

            // Mostrar el promedio
            Console.WriteLine("\nEl promedio de los números ingresados es: " + promedio);
        }
    }
}
