using System.Numerics;

namespace _4._CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Explicación
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

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, 
             se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario,
            mostrar el mensaje “No es apto para el contenido de este sitio web”.*/  
            
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

            
            /*Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar
             su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número.*/

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

            /*Un cliente se hospeda varias noches en una hostería, el precio por noche es de 200 dólares.
            Si el usuario se queda más de 3 noches se le aplica un porcentaje de descuento del 17 % y
            si no se aplica un porcentaje de descuento del 2 %. Mostrar un mensaje con el monto total
            que debe pagar el cliente, sabiendo que el usuario indica cuántas noches se va a quedar en la hostería. */

            int precionoche = 200;
            int noches = 0;
            double Total = 0;
            double descuento = 0;

            Console.WriteLine("Ingrese cuantas noches se hospedará");
            noches = Convert.ToInt32(Console.ReadLine());
            
            Total = precionoche * noches;

            if (noches > 3)
            {
                descuento = Total * 0.17;
            }
            else
            {
                descuento = Total * 0.02;
            }

            double totalConDescuento = Total - descuento;
            Console.WriteLine($"El total a pagar es: {totalConDescuento}");



        }
    }
}
