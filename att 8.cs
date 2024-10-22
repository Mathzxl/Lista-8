using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_8._1
{
    internal class Program
    {
        static double ValorS(int n)
        {
            double s=0;
            if (n > 0)
            {
                for (int i = 1; i < n; i++)
                {
                    double cima = i * i + 1;
                    double baixo = i + 3;
                    s += cima / baixo;
                }
            }
            else
            {
                Console.WriteLine("Digite um número postivo");
            }
            return s;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Dê o valor de n para ver até aonde a soma do S vai");
            int n = int.Parse(Console.ReadLine());
            double result;
            result = ValorS(n);
            Console.WriteLine($"O valor de S é: {result}");
            Console.ReadLine();
        }
    }
}
