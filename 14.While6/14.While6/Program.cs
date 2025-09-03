namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //14. Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.

            int contador = 2;
            int n = 0;
            int pares = 0;

            Console.WriteLine("Ingrese un número n: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (contador <= n)
            {
                pares++;
                contador += 2;
            }
            Console.WriteLine($"La cantidad de números pares desde 1 hasta {n} es: {pares}");
        }
    }
}
