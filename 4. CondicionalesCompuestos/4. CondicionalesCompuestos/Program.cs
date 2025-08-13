namespace _4._CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo");
            sueldo =Int32.Parse(Console.ReadLine());

            if (sueldo>=3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
                //Cuando la condición es verdadera
            }
            else
            {
                Console.WriteLine($"La persona {nombre}, está excenta de impuestos");
                //Cuando la condición es falsa
            }

            //Ejercicio 1 
            int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if(edad>=18)
            {
                Console.WriteLine($"La persona de edad {edad} años es bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine($"La persona de edad {edad} años no es apto para el contenido de este sitio web");
            }

            //Ejercicio 2 
            int Num1 = 0;
            int Num2 = 0;

            Console.WriteLine("Ingrese el Numero 1");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Numero 2");
            Num2 = Convert.ToInt32(Console.ReadLine());

            if(Num1>Num2)
            {
                Console.WriteLine($"La suma es {Num1 + Num2}");
                Console.WriteLine($"La diferencia es {Num1 - Num2}");
            }
            else
            {
                Console.WriteLine($"El producto es {Num1 * Num2}");
                Console.WriteLine($"La división es {Num1 / Num2}");
            }
        }
    }
}
