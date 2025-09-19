namespace ParcialCiclosIsabelaCastaño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* El almacén Oxford cuenta con los registros mensuales del número de ventas del año anterior y 
            requiere un programa que procese esta información para evaluar el desempeño anual.
            El programa debe realizar las siguientes operaciones:
            Ingresar por teclado el número de ventas realizadas en cada mes (12 meses en total).
            Calcular el promedio anual de ventas.
            Determinar y mostrar el mes con mayor número de ventas.
            Determinar y mostrar el mes con menor número de ventas.
            Evaluar el promedio anual de ventas y mostrar un mensaje:
            Si el promedio es mayor a 500 ventas, mostrar: “Se aprobó la meta”.
            Si el promedio es menor o igual a 500 ventas, mostrar: “La meta de ventas no se cumplió”.*/

            int Meses = 12;
            float acumuladoVentas = 0;
            float ventasMaximas = 0;
            float ventasMinimas = 0;
            float mesMaximo = 1;
            float mesMinimo = 1;
            float Ventasmes = 0;
            float promedio = 0;

            Console.WriteLine("Registro de ventas mensuales del año anterior:");

            acumuladoVentas += Ventasmes;
            ventasMaximas = Ventasmes;
            ventasMinimas = Ventasmes;

            for (int mes = 1; mes <= Meses; mes++)
            {
                Console.Write($"Ingrese las ventas del mes {mes}: ");
                Ventasmes = Convert.ToInt32(Console.ReadLine());

                acumuladoVentas += Ventasmes;

                if (Ventasmes > ventasMaximas)
                {
                    ventasMaximas = Ventasmes;
                    mesMaximo = mes;
                }

                if (Ventasmes < ventasMinimas)
                {
                    ventasMinimas = Ventasmes;
                    mesMinimo = mes;
                }
            }
            promedio = acumuladoVentas / Meses; 

            if (promedio > 500)
            {
                Console.WriteLine("Se aprobó la meta");
            }
            else if (promedio <= 500)
            {
                Console.WriteLine("La meta de ventas no se cumplió");
            }
            
            Console.WriteLine($"Promedio anual de ventas: {promedio}");
            Console.WriteLine($"Mes con mayor número de ventas: {mesMaximo} ({ventasMaximas} ventas)");
            Console.WriteLine($"Mes con menor número de ventas: {mesMinimo} ({ventasMinimas} ventas)");
        }
    }
}
