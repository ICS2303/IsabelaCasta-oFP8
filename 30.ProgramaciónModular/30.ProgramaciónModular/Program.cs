namespace _30.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es Isabela");
            MostrarMensajes("Tengo 17 años");
            Console.WriteLine($"Edad calculada: {CalcularEdad()}");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 1981)} años");
        }
        //Módulo 1 - Procedimiento sin parámetros
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenidos a la clase de programación modular");
            MostrarMensajes("Estoy desde procedimiento sin parámetros");
        }

        //Módulo 2 - Procedimiento con parámetros

        static void MostrarMensajes (string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Funciones

        static int CalcularEdad()
        {
            int edad;
            edad = 2025 - 2008;

            return edad;
        }

        //Mósulo 4 - Funciones con parámetros

        static int CalcularEdad (int AñoActual, int AñoNacimiento)
        {
            return AñoActual - AñoNacimiento;
        }
    }
}
