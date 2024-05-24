using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    internal class Program
    {
        static int MMC(int a, int b)
        {
            return (a * b) / MDC(a, b);
        }
        public static int MDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int menu;
            do
            {
                Console.WriteLine("1) Calcular MMC\n2) Calcular MDC\n3) Sair do programa");
                menu = int.Parse(Console.ReadLine());
                int n1, n2;
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro valor");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("MMC = " + MMC(n1, n2));
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Digite o primeiro valor");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor");
                        n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("MDC = " + MDC(n1, n2));
                        Console.WriteLine();
                        break;
                    case 3:
                        break;
                }
            } while (menu != 3);
        }
    }
}
