namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo unidimensional, 
            al final, debe visualizar el promedio de esos números.

            int[] vector; //Declarando

            vector = new int[15];
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i<vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el número entero para la posición {i + 1}, con índice {i}: ");
                vector[i] = int.Parse(Console.ReadLine());

                if (i==0)
                {
                    mayor=vector[i];
                    menor = vector[i]; 
                }
                else
                {
                    if (vector[i]>mayor)
                    {
                        mayor = vector[i];
                    }
                    if (vector[i] < menor)
                    {
                        menor = vector[i];
                    }
                }
            }
            Console.Clear();

            for (int i = 0; i<vector.Length; i++)
            {
                Console.WriteLine(vector[i] + " | ");
            }

            Console.WriteLine($"\n El número mayor es: {mayor}, el número menor es {menor}"); */


            /*2. Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el 
           orden de los elementos del vector. Se deben mostrar lo dos vectores. 

            string texto = "";
            string invertido = "";

            Console.Write("Ingrese una palabra o cadena de caracteres: ");
            texto = Console.ReadLine();

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                invertido += texto[i];
            }

            Console.WriteLine("\nCadena original: " + texto);
            Console.WriteLine("Cadena invertida: " + invertido); */

            /*3. Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre
            0 y 50.Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
            número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
            vector resaltando el número en un color diferente.Si no se encuentra el número, se debe
            devolver y mostrar -1. 

            int[] vector = new int[20];
            Random aleatorio = new Random();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = aleatorio.Next(0, 51);
            }

            Console.WriteLine("Vector generado:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.Write("Ingrese un número para buscar: ");
            int numero = int.Parse(Console.ReadLine());

            int posicion = -1;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numero)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($" Número encontrado en la posición: {posicion}");
                Console.WriteLine(" Vector con el número resaltado:");

                for (int i = 0; i < vector.Length; i++)
                {
                    if (i == posicion)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; // Cambia el color del texto
                        Console.Write(vector[i] + " ");
                        Console.ResetColor(); // Vuelve al color normal
                    }
                    else
                    {
                        Console.Write(vector[i] + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine(" -1 (El número no se encuentra en el vector)");
            } */

            /*4. Escribir un algoritmo que permita:
            Crear un vector con rango impar, exceptuando el 1, 
            Pedirle al usuario un número entero y almacenarlo en la mitad del vector.
            Llenar la primera mitad del vector, con los números menores al número almacenado
            en la posición de la mitad. 
            Llenar la parte inicial del vector, con los números menores al número almacenado en
            la posición de la mitad. 
            Llenar la parte final del vector, con los números mayores al número almacenado en la
            posición de la mitad. 
            Mostrar el vector en pantalla.

            int tamaño;

            do
            {
                Console.Write("Ingrese un tamaño impar para el vector (mayor que 1): ");
                tamaño = int.Parse(Console.ReadLine());

                if (tamaño % 2 == 0 || tamaño == 1)
                {
                    Console.WriteLine("El número debe ser impar y mayor que 1. Intente de nuevo.");
                }
            } while (tamaño % 2 == 0 || tamaño == 1);

            int[] vector = new int[tamaño];

            Console.Write("Ingrese un número entero para colocar en el centro del vector: ");
            int numeroCentral = int.Parse(Console.ReadLine());

            int centro = tamaño / 2;
            vector[centro] = numeroCentral;

            for (int i = centro - 1; i >= 0; i--)
            {
                vector[i] = numeroCentral - (centro - i);
            }

            for (int i = centro + 1; i < tamaño; i++)
            {
                vector[i] = numeroCentral + (i - centro);
            }

            Console.WriteLine("Vector resultante:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write(vector[i] + " ");
            } */

            /*5. Escribir un algoritmo que permita:  
            Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el usuario. 
            LLenar el primer vector con números aleatorios entre 0 y su rango+1 
            LLenar el segundo vector con números aleatorios entre rango y rango*2 
            Combinar los dos vectores en uno solo. 
            Mostrar en pantalla los tres vectores 

            Random aleatorio = new Random();

            Console.Write("Ingrese el tamaño del primer vector: ");
            int tamaño1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tamaño del segundo vector: ");
            int tamaño2 = int.Parse(Console.ReadLine());

            int[] vector1 = new int[tamaño1];
            int[] vector2 = new int[tamaño2];
            int[] combinado = new int[tamaño1 + tamaño2];

            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = aleatorio.Next(0, tamaño1 + 2);
            }

            for (int i = 0; i < vector2.Length; i++)
            {
                vector2[i] = aleatorio.Next(tamaño2, tamaño2 * 2 + 1);
            }

            for (int i = 0; i < tamaño1; i++)
            {
                combinado[i] = vector1[i];
            }

            for (int i = 0; i < tamaño2; i++)
            {
                combinado[tamaño1 + i] = vector2[i];
            }

            Console.WriteLine("\nPrimer vector:");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write(vector1[i] + " ");
            }

            Console.WriteLine("\n\nSegundo vector:");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write(vector2[i] + " ");
            }

            Console.WriteLine("\n\nVector combinado:");
            for (int i = 0; i < combinado.Length; i++)
            {
                Console.Write(combinado[i] + " ");
            } */


        }
    }
}
