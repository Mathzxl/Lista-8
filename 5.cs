using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Program
    {
        static int Vogais(char[] v)
        {
            int contvg = 0;
            char[] vg = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = 0; j < vg.Length; j++)
                {
                    if (v[i] == vg[j])
                    {
                        contvg++;
                    }
                }
            }
            return contvg;
        }
        static void Main(string[] args)
        {
            char[] vg = new char[10];
            for( int i = 0; i < vg.Length; i++)
            {
                Console.WriteLine("Digite uma letra qualquer");
                char l = char.Parse(Console.ReadLine());
                vg[i] = l;
            }
            int nv = Vogais(vg);
            Console.WriteLine("Número de vogais no vetor: " + nv);
            Console.ReadLine();
        }
    }
}
