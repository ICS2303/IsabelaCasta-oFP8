namespace _15.While7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 15.Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, 
            si al final de cada mes deposita cantidades variables de dinero; además, 
            se quiere saber cuánto lleva ahorrado cada mes.*/

            int ahorro = 0;
            int deposito = 0;
            int mes = 1;

            while (mes <= 12)
            {
                Console.WriteLine($"Ingrese el depósito del mes {mes} ");
                deposito = Convert.ToInt32(Console.ReadLine());

                ahorro += deposito;
                Console.WriteLine($"Ahorro acumulado hasta el mes {mes}, es: {ahorro}");
                mes++;

            }
            Console.WriteLine($"El ahorro total del año es: {ahorro}");
        }
    }
}
