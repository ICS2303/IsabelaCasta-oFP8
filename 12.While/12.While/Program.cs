namespace _12.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;     
            int acumulador = 0;   

            while (contador <= 99)
            {
                acumulador += contador;   
                contador += 2;            
            }

            Console.WriteLine("La suma de los números impares hasta 99 es: " + acumulador);
            
        }
    }
}
