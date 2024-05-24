using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    internal class Program
    {
        static double Met(int n1, int n2, int n3, char letra)
        {
            if (letra == 'A')
            {
                double MA = (n1 + n2 + n3) / 3;
                return MA;
            }
            else if (letra == 'P')
            {
                double MP = (n1 * 5 + n2 * 3 + n3 * 2) / 10;
                return MP;
            }
            else
            {
                Console.WriteLine("Letra inválida");
            }
            return 0;
        } 
            static void Main(string[] args)
        {
            Console.WriteLine("Escolha entre a Letra A ou P");
            char letra = char.Parse(Console.ReadLine());

            if (letra == 'A')
            {
                Console.WriteLine("Dê um número qualquer");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê um número qualquer");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê um número qualquer");
                int n3 = int.Parse(Console.ReadLine());
                double resultado = Met(n1, n2, n3, letra);
                Console.WriteLine($"O resultado é: {resultado}");
            }
            else if (letra == 'P')
            {
                Console.WriteLine("Dê um número qualquer");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê um número qualquer");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dê um número qualquer");
                int n3 = int.Parse(Console.ReadLine());
                double resultado = Met(n1, n2, n3, letra);
                Console.WriteLine($"O resultado é: {resultado}");
            }
            else
            {
                Console.WriteLine("Letra inválida. Não é possível fazer nenhum cálculo.");
            }
            Console.ReadLine();
        }
    }
}
