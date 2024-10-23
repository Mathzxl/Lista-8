using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_11
{
    internal class Program
    {
        static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
        {
            hora = totalSegundos / 3600;
            min = (totalSegundos % 3600) / 60;
            seg = totalSegundos % 60;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o total de segundos: ");
            int totalSegundos = int.Parse(Console.ReadLine());
            ConverterSegundos(totalSegundos, out int horas, out int minutos, out int segundos);
            Console.WriteLine($"Tempo convertido: {horas} : {minutos} : {segundos}");
            Console.ReadLine();
        }
    }
}
