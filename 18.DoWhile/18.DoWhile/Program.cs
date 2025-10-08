using System.ComponentModel.Design;

namespace _18.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
            Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y 
            “Es apto para el crédito” 
            Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y 
            “No es apto para el crédito” 
            El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar 
            más. 
            Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, 
            y debe mostrar el promedio de los saldos.*/

            string nombre = "";
            int cuenta, saldo = 0;
            string respuesta = "";

   

            do
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su número de cuenta: ");
                cuenta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el saldo que tiene en la cuenta: ");
                saldo = Convert.ToInt32(Console.ReadLine());

                if (saldo > 3000000)
                {
                    Console.WriteLine($"La persona {nombre}, con número de cuenta {cuenta}, y saldo {saldo}, Es apta para el crédito");
                }
                else if (saldo < 3000000)
                {
                    Console.WriteLine($"La persona {nombre}, con número de cuenta {cuenta}, y saldo {saldo}, No es apta para el crédito");
                }
                    
                   
                
            } while (respuesta == "si");
           
        }
    }
}
