namespace _32.ProgramaciónModular
{
    internal class Program
    {
        static void Main()
        {
            int opcion;
            do
            {
                MostrarMenu();
                opcion = CapturarOpcion();
                RealizarOperaciones(opcion);

            } while (opcion != 5);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\nMENÚ DE OPERACIONES");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
        }

        static int CapturarOpcion()
        {
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        static void RealizarOperaciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        static void Suma()
        {
            Console.Write("¿Cuántos números desea sumar? ");
            int cantidad = int.Parse(Console.ReadLine());
            double suma = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                suma += double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La suma total es: {suma}");
        }

        static void Resta()
        {
            Console.Write("Ingrese el primer número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de la resta es: {a - b}");
        }

        static void Multiplicacion()
        {
            Console.Write("¿Cuántos números desea multiplicar? ");
            int cantidad = int.Parse(Console.ReadLine());
            double producto = 1;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                producto *= double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El producto total es: {producto}");
        }

        static void Division()
        {
            Console.Write("Ingrese el primer número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double b = double.Parse(Console.ReadLine());

            if (b != 0)
                Console.WriteLine($"El resultado de la división es: {a / b}");
            else
                Console.WriteLine("Error: no se puede dividir entre cero.");
        }
    }
}
