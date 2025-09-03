namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. 
             Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
             El algoritmo debe escribir en pantalla: 
             La cantidad de números introducidos que son mayores que 0 
             La cantidad de números introducidos menores que 0  
             La cantidad de números iguales a 0.*/

            int cantidad = 0;
            int contador = 0;
            int positivos = 0;
            int negativos = 0;
            int cero = 0;
            int numero = 0;
            

            Console.WriteLine("¿Cuantos números desea ingresar?");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (contador < cantidad)
            {
                Console.WriteLine("Ingrese un número entero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    cero++;
                }
                contador++;
            }
            Console.WriteLine($"Los números positivos son: {positivos}");
            Console.WriteLine($"Los números negativos son: {negativos}");
            Console.WriteLine($"Los números iguales que cero son: {cero}");


        }
    }
}
