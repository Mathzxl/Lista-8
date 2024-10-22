using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_8
{
    internal class Program
    {
        static double ValorS(int n)
        {
            double s = 1;
            if(n > 0){
                for (int i = 2; i < n; i++)
                {
                    s += 1.0 / i;
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
            int n= int.Parse(Console.ReadLine());
            double result;
            result = ValorS(n);
            Console.WriteLine($"O valor de S é: {result}");
            Console.ReadLine();
        }
    }
}
