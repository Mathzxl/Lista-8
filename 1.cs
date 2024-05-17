using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class Program
    {
        static int MenorValor(int v1, int v2, int v3, int v4)
        {
            int menorv = v1;
            if (v1 > v2)
                menorv = v2;
            else if (v2 > v3)
                menorv = v3;
            else if (v3 > v4)
                menorv = v4;
            return menorv;

        }
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("Dê um valor qualquer");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dê um valor qualquer");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dê um valor qualquer");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dê um valor qualquer");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("O menor valor é: " + MenorValor(n1, n2, n3, n4));
            Console.ReadLine();
        }
    }
}
