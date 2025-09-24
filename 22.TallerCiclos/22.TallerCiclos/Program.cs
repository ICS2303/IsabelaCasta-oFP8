using System.Net;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using System.ComponentModel.Design;

namespace _22.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
            le permitirá al usuario, introducir tantas calificaciones como así desee, 
            en el momento en que seleccione que no desea continuar capturando 
            calificaciones, el algoritmo debe presentar el promedio de las 
            calificaciones capturadas previamente.

            int calificaciones = 0;
            int suma = 0;
            string respuesta = " ";
            int contador = 0;
            int promedio = 0;

            do
            {
                Console.WriteLine("Ingrese la calificación: ");
                calificaciones = Convert.ToInt32(Console.ReadLine());
                suma += calificaciones;
                contador++;
                Console.WriteLine("Desea ingresar otra calificación: (Si / No)");
                respuesta = Console.ReadLine().ToLower();
        
                if (respuesta == "No")
                {
                    promedio = suma / contador;
                    Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
                }


            } while (respuesta == "Si"); */

            /* 2. Se requiere un algoritmo para mostrar por pantalla los divisores de un 
            número ingresado por teclado. Tener en cuenta que dados dos números enteros a y b, se dice que b es 
            divisor de a si se cumple que al efectuar una división entera a/b el 
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            una división de dos números. 
            Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
            2, 1 que son los divisores del número 6.

            int numero = 0; 

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Los divisores de {numero} son:");

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            /*3.Dados dos números enteros ingresados por teclado: b que es la base y
            e que es el exponente, se requiere calcular el resultado de la
            potenciación.
            Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            Mostrar por pantalla el resultado de la potenciación. 
            Seguir pidiendo por teclado la base y el exponente y realizar la
            potenciación correspondiente, hasta que el usuario ingrese por teclado
            el carácter de escape ‘n’

            int b = 0;
            int e = 0;
            int resultado = 1;
            string respuesta = "";

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un numero: ");
                e = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= e; i++)
                {
                    resultado *= b;
                }

                Console.WriteLine($"El resultado de la potenciación es: {resultado} ");
                b = 0;
                e = 0;
                resultado = 1; 
                Console.WriteLine("Desea continuar: (Si: S / No: n )");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta != "n");*/

            /*4.Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
            kilómetros durante 10 días, para determinar si es apto para la prueba de
            5 kilómetros.Para considerarlo apto debe cumplir las siguientes
            condiciones: 
             Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
             Que al menos en una de las pruebas realice un tiempo menor de 15
            minutos.
             Que su promedio sea menor o igual a 18 minutos.
            Diseñar un algoritmo para registrar los datos y decidir si es apto para la
            competencia.

            int dias = 5;
            bool TiempoMayor20 = false;
            bool TiempoMenor15 = false;
            int tiempo = 0;
            int suma = 0;
            float promedio = 0; 

            for (int i = 0; i < dias; i++)
            {
                Console.WriteLine($"Ingrese el tiempo del día: {i + 1}");
                tiempo = Convert.ToInt32(Console.ReadLine());

                suma += tiempo;

                if(tiempo>20)
                {
                    TiempoMayor20 = true; 
                }
                else if (tiempo<15)
                {
                    TiempoMenor15 = true; 
                }

            }

            promedio = suma / dias;
            Console.WriteLine($"El promedio del atleta es: {promedio}");

            if (!TiempoMayor20 && TiempoMenor15 && promedio <= 18) 
            {
                Console.WriteLine("El atleta es apto para la competencia"); 
            }
            else
            {
                Console.WriteLine("El atleta no es apto para la competencia");
            } */

            /*5. Se aplicó una encuesta a n personas solicitando su opinión sobre el 
            tema del servicio militar obligatorio para las mujeres. Las opciones de 
            respuesta fueron: a favor, en contra y no responde. Se solicita un 
            algoritmo que calcule qué porcentaje de los encuestados marcó cada 
            una de las respuestas. 

            int n = 0;
            int aFavor = 0;
            int enContra = 0;
            int noResponde = 0;
            int respuesta = 0; 


            Console.Write("Ingrese la cantidad de personas encuestadas: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"la persona {i}. Por favor eliga una opción (1-3) (1.A favor, 2.En Contra, 3.No responde) ");
                respuesta = Convert.ToInt32(Console.ReadLine());

                if (respuesta == 1)
                {
                    aFavor++;
                }
                else if (respuesta == 2)
                {
                    enContra++;
                }
                else if (respuesta == 3)
                {
                    noResponde++;
                }
            }
            int porcentajeFavor = (aFavor * 100) / n;
            int porcentajeContra = (enContra * 100) / n;
            int porcentajeNoResponde = (noResponde * 100) / n;

            Console.WriteLine($"El porcentaje de personas a favor es: {porcentajeFavor}%, el porcentaje de personas en contra es: {porcentajeContra}%, el porcentaje de personas que no responden es: {porcentajeNoResponde}%"); */

            /*6. Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos 
            de esos números son positivos, cuántos negativos, cuántos son neutros 
            (0); además que imprima por pantalla la sumatoria de los números 
            positivos y la de los negativos. 

            int totalnumeros = 40;
            int positivos = 0;
            int negativos = 0; 
            int neutros = 0;
            int sumaPositivos = 0;
            int sumaNegativos = 0;

            Console.WriteLine("Ingrese 40 números:");

            for (int i = 1; i <= totalnumeros; i++)
            {
                Console.Write($"Número {i}: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    positivos++;
                    sumaPositivos += numero;
                }
                else if (numero < 0)
                {
                    negativos++;
                    sumaNegativos += numero;
                }
                else
                {
                    neutros++;
                }
            }
            Console.WriteLine($"Cantidad de positivos: {positivos}, Cantidad de negativos: {negativos}, Cantidad de neutros: {neutros}, Suma de positivos: {sumaPositivos}, Suma de negativos: {sumaNegativos}"); */

            /*7. Una persona desea realizar un muestreo con 70 personas para 
             determinar el promedio de peso de los niños, jóvenes, adultos y viejos 
             que existen en su zona y cuántos son de cada una de las categorías. 
             Las categorías están dadas por la siguiente tabla: 
             Categoría       Edad 
             Niños           0-13 
             Jóvenes         14-30 
             Adultos         31-60 
             Viejos          61 en adelante
            int peso = 0;
            int edad = 0;

            int cantNiños = 0;
            int cantJovenes = 0;
            int cantAdultos = 0;
            int cantViejos = 0;

            int pesoNiños = 0;
            int pesoJovenes = 0;
            int pesoAdultos = 0;
            int pesoViejos = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Persona {i}: Ingrese su edad:");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su peso:");
                peso = Convert.ToInt32(Console.ReadLine());

                if (edad >= 0 && edad <= 13)
                {
                    cantNiños++;
                    pesoNiños += peso;
                }
                else if (edad >= 14 && edad <= 30)
                {
                    cantJovenes++;
                    pesoJovenes += peso;
                }
                else if (edad >= 31 && edad <= 60)
                {
                    cantAdultos++;
                    pesoAdultos += peso;
                }
                else if (edad >= 61)
                {
                    cantViejos++;
                    pesoViejos += peso;
                }
            }
            Console.WriteLine($"De los encuestados: {cantNiños} son niños, {cantJovenes} son jóvenes, {cantAdultos} son adultos y {cantViejos} son adultos mayores");
            Console.WriteLine($"Promedio de los pesos: Niños: {pesoNiños / cantNiños}, Jovenes: {pesoJovenes / cantJovenes}, Adultos: {pesoAdultos / cantAdultos}, Adultos mayores: {pesoViejos / cantViejos}"); */

            /*8. El Departamento de Transito de Antioquia. desea saber de los n autos 
            que entran a la ciudad de Medellín, cuántos autos entran con 
            calcomanía de un determinado color. Conociendo el último dígito de la 
            placa de cada automóvil se puede determinar el color de la calcomanía, 
            para determinar lo anterior utilice la siguiente tabla: 
            DÍGITO  COLOR 
            1 o 2   amarilla 
            3 o 4   rosa 
            5 o 6   roja 
            7 o 8   verde 
            9 o 0   azul

            int autos = 0;
            int digito = 0;

            int calcAmarilla = 0;
            int calcRosa = 0;
            int calcRoja = 0;
            int calcVerde = 0;
            int calcAzul = 0;

            Console.WriteLine("Ingrese el número de autos que han ingresado a Medellín:");
            autos = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= autos; i++)
            {
                Console.WriteLine($"Ingrese el último dígito de la placa del auto {i}");
                digito = Convert.ToInt32(Console.ReadLine());

                if (digito == 1 || digito == 2)
                {
                    calcAmarilla++;
                }
                else if (digito == 3 || digito == 4)
                {
                    calcRosa++;
                }
                else if (digito == 5 || digito == 6)
                {
                    calcRoja++;
                }
                else if (digito == 7 || digito == 8)
                {
                    calcVerde++;
                }
                else if (digito == 9 || digito == 0)
                {
                    calcAzul++;
                }
            }
            Console.WriteLine($"Cantidad de autos que ingresan con calcomanía: Amarilla: {calcAmarilla}; Rosa: {calcRosa}; Roja: {calcRoja}; Verde: {calcVerde}; Azul: {calcAzul}"); */
        }


    }
  }

