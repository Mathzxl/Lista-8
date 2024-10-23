using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_12
{
    internal class Program
    {
        static void EncontrarMaiorElemento(int[,] Anxn, out int k, out int lin, out int col)
        {
            k = Anxn[0, 0];
            lin = 0;
            col = 0;
            for (int i = 0; i < Anxn.GetLength(0); i++)
            {
                for (int j = 0; j < Anxn.GetLength(1); j++)
                {
                    if (Anxn[i, j] > k)
                    {
                        k = Anxn[i, j];
                        lin = i;
                        col = j;
                    }
                }
            }
        }
            static void Main(string[] args)
        {
            int[,] Anxn= new int[3,3];
            Random rnd = new Random();
            for (int i = 0;i < Anxn.GetLength(0); i++)
            {
                for(int j = 0;j < Anxn.GetLength(1); j++)
                {
                    Anxn[i, j] = rnd.Next(0,11);
                    Console.Write(Anxn[i, j] + " ");
                }
                Console.WriteLine();
            }
            EncontrarMaiorElemento(Anxn, out int maiorElemento, out int linha, out int coluna);
            Console.WriteLine($"Maior elemento: {maiorElemento}");
            Console.WriteLine($"Posição: Linha {linha}, Coluna {coluna}");
            Console.ReadLine();
        }
    }
}
