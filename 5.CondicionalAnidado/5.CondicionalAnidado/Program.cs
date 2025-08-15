namespace _5.CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que lea tres números A, B, C y 
             visualice en pantalla el valor más grande. 
             El usuario debe ingresar tres valores diferentes. */
            
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine(num1);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2);
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num3);
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num3)
            {
                Console.WriteLine($"El número 1 {num1}, es el mayor");
            }
            else
            {
                Console.WriteLine($"El número 3 {num3}, es el mayor");
            }

            if (num2 > num3)
            {
                Console.WriteLine($"El número 2 {num2}, es el mayor");
            }
            else
            {
                Console.WriteLine($"El número 3 {num3}, es el mayor");
            }


        }
    }
}
