namespace _10._While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)*/

            int contador = 1;
            int acumulador = 1;
            int num = 0;

            Console.WriteLine("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(contador <= num)
            {
                acumulador *= contador;
                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
                contador++;
            }
            Console.WriteLine($"El factorial del número {num} es: {acumulador}");
            
        }
    }
}
