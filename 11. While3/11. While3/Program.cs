namespace _11._While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que pida números enteros positivos y los sume, 
            hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla 
            el total de la suma de los números ingresados*/

            int contador = 0;
            int acumulador = 0;
            int numP = 0;

            Console.WriteLine("Ingrese números enteros positivos: (ingrese un número negativo para terminar)");
            numP = Convert.ToInt32(Console.ReadLine());

            while (numP >= 0)
            {
                acumulador += numP;
                contador++;

             
               numP = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"La suma total de los números imgresados es: {acumulador}");

        }
    }
}
