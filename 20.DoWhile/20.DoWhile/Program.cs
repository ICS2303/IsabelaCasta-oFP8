namespace _20.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
            El número de partidos perdidos  
            El número de partidos empatados  
            El número de partidos ganados  
            El porcentaje de partidos perdidos  
            El porcentaje de partidos empatados  
            El porcentaje de partidos ganados*/

            int partidos = 30;
            int partidosPerdidos = 0;
            int partidosEmpatado = 0;
            int partidosGanados = 0;
            int contador = 0;
            string resultado = " ";

            

            do
            {

                Console.WriteLine("Ingrese el resultado del partido: (G: gano, P: perdio, E: empato");
                resultado = Console.ReadLine();
                if (resultado == "G")
                {
                    partidosGanados++;
                }
                else if (resultado == "P")
                {
                    partidosPerdidos++; 
                }
                else
                {
                    partidosEmpatado++; 
                }
                contador++;

            } while (contador < partidos);

            Console.WriteLine($"Ganados: {partidosGanados} - {partidosGanados * 100 / partidos}%");
            Console.WriteLine($"Perdidos: {partidosPerdidos} - {partidosPerdidos * 100 / partidos}%");
            Console.WriteLine($"Empatados: {partidosEmpatado} - {partidosEmpatado * 100 / partidos}%");

        }
    }
}
