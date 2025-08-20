using System.Runtime.Intrinsics.X86;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
            Si el día es martes o jueves, se realizará un descuento del 15% por la compra.  
            Si el día es lunes o miércoles, se realizará un descuento del 10% por la compra. 
            Si el día es viernes o sábado, se realizará un descuento del 20% por la compra. 
            Si es domingo no se realiza descuento. 
            Visualizar el día, el descuento y el total a pagar por la compra. */

             float ValorCompra = 0;
             float descuento = 0;
             char dia = ' ';

             Console.WriteLine("Ingrese el valor de la comrpa: ");
             ValorCompra = Single.Parse(Console.ReadLine());
             Console.WriteLine($"Ingrese el día de la semana: L: Lunes, M: Martes, X: Miercoles, J: Jueves, V: Viernes, S: Sábado, D: Domingo ");
             dia = Convert.ToChar(Console.ReadLine());

             switch (dia)
             {
                 case 'L':
                     descuento = ValorCompra * 0.1f;
                     Console.WriteLine($"Hoy es lunes, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                     break;

                 case 'M':
                     descuento = ValorCompra * 0.15f;
                     Console.WriteLine($"Hoy es martes, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                     break;

                 case 'X':
                     descuento = ValorCompra * 0.1f;
                     Console.WriteLine($"Hoy es miercoles, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                     break;

                 case 'J':
                     descuento = ValorCompra * 0.15f;
                     Console.WriteLine($"Hoy es jueves, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                     break;

                 case 'V':
                     descuento = ValorCompra * 0.2f;
                     Console.WriteLine($"Hoy es viernes, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                     break;

                 case 'S':
                     descuento = ValorCompra * 0.2f;
                     Console.WriteLine($"Hoy es sábado, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                     break;

                 case 'D':
                     descuento = ValorCompra * 0;
                     Console.WriteLine($"Hoy es domingo, descuento de {descuento}, valor total de la compra {ValorCompra - descuento}");

                     break;

             }


            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. 
            Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            char opcion = ' ';

            Console.WriteLine("Ingrese el número 1: ");
            num1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2: ");
            num2 = Single.Parse(Console.ReadLine());
            Console.WriteLine($"Seleccione la opción que desea realizar: 1. Suma, 2. Resta, 3. Multiplicación, 4. División ");
            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case '1':
                    num3 = num1 + num2;
                    Console.WriteLine($"La operación que se realizó fue una suma y el resultado es {num3}");

                    break;

                case '2':
                    num3 = num1 - num2;
                    Console.WriteLine($"La operación que se realizó fue una resta y el resultado es {num3}");

                    break;

                case '3':
                    num3 = num1 * num2;
                    Console.WriteLine($"La operación que se realizó fue una multiplicación y el resultado es {num3}");

                    break;

                case '4':
                    num3 = num1 / num2;
                    Console.WriteLine($"La operación que se realizó fue una división y el resultado es {num3}");

                    break;

               
            }


            }


        }
    }
