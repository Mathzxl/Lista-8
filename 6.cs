using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_6
{
    internal class Program
    {
        static void MultiplicarEscalar(int[,] m, int n)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    m[i, j] = m[i,j] * n;
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] m = new int[3,3];
            Random rnd = new Random();
            for (int i = 0;i < m.GetLength(0); i++)
            {
                for(int j = 0;j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(0,11);
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Digite um valor para multiplicar essa matriz");
            int n = int.Parse(Console.ReadLine());
            MultiplicarEscalar(m, n);
            for (int i = 0;i< m.GetLength(0) ; i++)
            {
                for(int j = 0  ; j < m.GetLength(1) ; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
