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

            Console.WriteLine("Ingrese el número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num3)
            {
                Console.WriteLine($"El número 1: {num1}, es el mayor");
            }
            else
            {
                Console.WriteLine($"El número 3: {num3}, es el mayor");
            }

            if (num2 > num3)
            {
                Console.WriteLine($"El número 2: {num2}, es el mayor");
            }
            else
            {
                Console.WriteLine($"El número 3: {num3}, es el mayor");
            }

            /*Realizar un algoritmo que permita solicitar 3 calificaciones, calcular el promedio. 
            Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes. 
            Considerar la situación en donde el promedio generado no esté contemplado en los rangos establecidos, mostrar mensaje de error. 
            9.5-10.0 Excelente 
            8.5-9.4 Muy bien 
            7.5-8.4 Bien*/

            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int promedio = 0;

            Console.WriteLine("Ingrese la nota 1: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3: ");
            nota3 = Convert.ToInt32(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"El promedio es: {promedio}");

            if (promedio >= 9.5 && promedio <= 10)
            {
                Console.WriteLine("Muy bien");
            }
            else
            {
                if (promedio >= 8.5 && promedio <= 9.4)
                {
                    Console.WriteLine("Muy bien");
                }
                else
                {
                if (promedio >= 7.5 && promedio <= 8.4)
                    {
                        Console.WriteLine("Bien");
                    }
                else
                    {
                        Console.WriteLine("Error, los datos no estan en el rango establecido");
                    }
                }
            }
        }
    }
}
