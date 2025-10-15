using System.Drawing;
using System.Reflection;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TallerProgramaciónModular
{
    internal class Program
    {
        /*1. Desarrolla un programa que permita:
           Ingresar una palabra
           LLevar la palabra ingresada a un vector de caracteres
           Contar la cantidad de vocales y consonantes en la palabra proporcionada por el
           usuario. */
        /* static void Main()
        {
            string palabra = PedirPalabra();
            int vocales = ContarVocales(palabra);
            int consonantes = ContarConsonantes(palabra);
            MostrarResultado(palabra, vocales, consonantes);
        }

        static string PedirPalabra()
        {
            Console.Write("Ingrese una palabra: ");
            return Console.ReadLine();
        }

        static int ContarVocales(string palabra)
        {
            int contador = 0;
            palabra = palabra.ToLower();


            for (int i = 0; i < palabra.Length; i++)
            {
                char letra = palabra[i];
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                    contador++;
            }
            return contador;
        }

        static int ContarConsonantes(string palabra)
        {
            int contador = 0;
            palabra = palabra.ToLower();


            for (int i = 0; i < palabra.Length; i++)
            {
                char letra = palabra[i];
                if (letra >= 'a' && letra <= 'z' && !(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'))
                    contador++;
            }
            return contador;
        }

        static void MostrarResultado(string palabra, int vocales, int consonantes)
        {
            Console.WriteLine("La palabra es: " + palabra);
            Console.WriteLine("Número de vocales: " + vocales);
            Console.WriteLine("Número de consonantes: " + consonantes);
        } */


        /* 2. Crear un programa que permita gestionar una lista de tareas:
        Agregar tareas.
        Eliminar tareas
        Mostrar la lista de tareas */

        /* static void Main()
         {
             string[] tareas = new string[10];
             int cantidad = 0;
             int opcion;

             do
             {
                 opcion = MostrarMenu();
                 if (opcion == 1)
                     cantidad = AgregarTarea(tareas, cantidad);
                 else if (opcion == 2)
                     cantidad = EliminarTarea(tareas, cantidad);
                 else if (opcion == 3)
                     MostrarTareas(tareas, cantidad);
             } while (opcion != 0);
         }
         static int MostrarMenu()
         {
             Console.WriteLine("\n1. Agregar tarea");
             Console.WriteLine("2. Eliminar tarea");
             Console.WriteLine("3. Mostrar tareas");
             Console.WriteLine("0. Salir");
             Console.Write("Seleccione una opción: ");
             return int.Parse(Console.ReadLine());
         }

         static int AgregarTarea(string[] tareas, int cantidad)
         {
             if (cantidad < tareas.Length)
             {
                 Console.Write("Ingrese la tarea: ");
                 tareas[cantidad] = Console.ReadLine();
                 cantidad++;
                 Console.WriteLine("Tarea agregada.");
             }
             else
                 Console.WriteLine("Lista llena.");
             return cantidad;
         }
         static int EliminarTarea(string[] tareas, int cantidad)
         {
             MostrarTareas(tareas, cantidad);
             Console.Write("Ingrese el número de la tarea a eliminar: ");
             int pos = int.Parse(Console.ReadLine());
             if (pos > 0 && pos <= cantidad)
             {
                 for (int i = pos - 1; i < cantidad - 1; i++)
                     tareas[i] = tareas[i + 1];
                 cantidad--;
                 Console.WriteLine("Tarea eliminada.");
             }
             else
                 Console.WriteLine("Posición inválida.");
             return cantidad;
         }
         static void MostrarTareas(string[] tareas, int cantidad)
         {
             Console.WriteLine("\nLista de tareas:");
             for (int i = 0; i < cantidad; i++)
                 Console.WriteLine((i + 1) + ". " + tareas[i]);
             if (cantidad == 0)
                 Console.WriteLine("No hay tareas registradas.");
         } */


        /* 3. Desarrolla un programa que permita:
        Elegir un tipo de unidad de medida
        Masa
        Capacidad
        Longitud
        Tiempo
        Elegir una unidad de medida para convertir.
        Masa
        De kilogramos a gramos
        De gramos a Kilogramos
        Capacidad
        De litro a mililitro
        De mililitro a litro
        Longitud
        De kilometro a metro
        De metro a kilometro
        Tiempo
        De hora a segundos
        De segundos a hora
        Ingresar un valor para convertir.
        Al final mostrar el valor y la unidad a convertir, y el valor y la unidad a la que se
        convirtió.Ej: “1 kilometro son 1000 metros” */

        /* static void Main()
         {
             int opcion = 0;
             double valor, resultado;

             do
             {
                 opcion = MostrarMenu();
                 if (opcion != 0)
                 {
                     valor = PedirValor();
                     resultado = Convertir(opcion, valor);
                     MostrarResultado(opcion, valor, resultado);
                 }
             } while (opcion != 0);
         }

         static int MostrarMenu()
         {
             Console.WriteLine("\n1. Kilogramos a gramos");
             Console.WriteLine("2. Gramos a kilogramos");
             Console.WriteLine("3. Metros a centímetros");
             Console.WriteLine("4. Centímetros a metros");
             Console.WriteLine("0. Salir");
             Console.Write("Opción: ");
             return int.Parse(Console.ReadLine());
         }

         static double PedirValor()
         {
             Console.Write("Ingrese el valor: ");
             return double.Parse(Console.ReadLine());
         }


         static double Convertir(int opcion, double valor)
         {
             double resultado = 0;
             if (opcion == 1) resultado = valor * 1000;
             if (opcion == 2) resultado = valor / 1000;
             if (opcion == 3) resultado = valor * 100;
             if (opcion == 4) resultado = valor / 100;
             return resultado;
         }

         static void MostrarResultado(int opcion, double valor, double resultado)
         {
             if (opcion == 1) Console.WriteLine(valor + " kg son " + resultado + " g");
             if (opcion == 2) Console.WriteLine(valor + " g son " + resultado + " kg");
             if (opcion == 3) Console.WriteLine(valor + " m son " + resultado + " cm");
             if (opcion == 4) Console.WriteLine(valor + " cm son " + resultado + " m");
         }
     } */


        /* 4. Utiliza programación modular para crear un programa que permita:
        Recorrer una matriz y llenarla con nombres de contactos.
        Ingresar un nombre y buscarlo en la matriz
        Si se encuentra el nombre, cambiarlo en la matriz por un nuevo nombre que ingresa
        el usuario
        Mostrar por pantalla el nombre encontrado, su posición en la matriz(f, c), y el nuevo
        nombre ingresado. */

        /* static void Main()
        {
            string[,] matriz = new string[2, 2];
            LlenarMatriz(matriz);
            MostrarMatriz(matriz); 

            Console.Write("Ingrese el nombre a buscar: ");
            string nombre = Console.ReadLine();
            int[] posicion = BuscarNombre(matriz, nombre);

            if (posicion[0] != -1)
            {
                Console.WriteLine("\nNombre encontrado: " + matriz[posicion[0], posicion[1]]);
                Console.WriteLine("Posición: (" + posicion[0] + "," + posicion[1] + ")");

                Console.Write("Ingrese el nuevo nombre: ");
                string nuevo = Console.ReadLine();

                Reemplazar(matriz, posicion[0], posicion[1], nuevo);

                Console.WriteLine("\nMatriz actualizada:");
                MostrarMatriz(matriz);

                Console.WriteLine("Nuevo nombre en esa posición: " + nuevo);
            }
            else
            {
                Console.WriteLine("Nombre no encontrado.");
            }
        }
        static void LlenarMatriz(string[,] matriz)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Ingrese nombre [" + i + "," + j + "]: ");
                    matriz[i, j] = Console.ReadLine();
                }
            }
        }
        static void MostrarMatriz(string[,] matriz)
        {
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int[] BuscarNombre(string[,] matriz, string nombre)
        {
            int[] pos = { -1, -1 };
            nombre = nombre.ToLower(); 

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (matriz[i, j].ToLower() == nombre) 
                    {
                        pos[0] = i;
                        pos[1] = j;
                        return pos;
                    }
                }
            }
            return pos;
        }

        static void Reemplazar(string[,] matriz, int fila, int columna, string nuevo)
        {
            matriz[fila, columna] = nuevo;
        } */

        /* 5. Crear un programa que implemente el juego de tres en raya(triqui o gato), para dos
        Dibujar el tablero
        Permitir realizar movimientos.
        Verificar ganadores */

            static char[,] tablero = new char[3, 3];
            static void Main()
            {
                InicializarTablero();
                char jugador = 'X';
                bool terminado = false;

                while (!terminado)
                {
                    MostrarTablero();
                    Console.WriteLine("Turno del jugador " + jugador);
                    JugarTurno(jugador);


                    if (VerificarGanador(jugador))
                    {
                        MostrarTablero();
                        Console.WriteLine("Ganó el jugador " + jugador);
                        terminado = true;
                    }
                    else
                    {
                        jugador = (jugador == 'X') ? 'O' : 'X';
                    }
                }
            }

            static void InicializarTablero()
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        tablero[i, j] = '-';
            }

            static void MostrarTablero()
            {
                Console.Clear();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        Console.Write(tablero[i, j] + " ");
                    Console.WriteLine();
                }
            }

            static void JugarTurno(char jugador)
            {
                int fila, columna;
                do
                {
                    Console.Write("Ingrese la fila (0-2): ");
                    fila = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la columna (0-2): ");
                    columna = int.Parse(Console.ReadLine());
                } while (tablero[fila, columna] != '-');


                tablero[fila, columna] = jugador;
            }

            static bool VerificarGanador(char jugador)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador) return true;
                    if (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador) return true;
                }
                if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador) return true;
                if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador) return true;
                return false;
            }

    }

}

