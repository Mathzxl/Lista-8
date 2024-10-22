using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace atv_9
{
    internal class Program
    {
        static void ObterMaiorMenor(double[] vet,out double maior,out double menor)
        {
            maior = double.MinValue; 
            menor = double.MaxValue;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
                else if (vet[i] < menor)
                {
                    menor = vet[i];
                }
            }
        }
        static void Main(string[] args)
        {
            double[] vet = new double[10];
            Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(0,11);
                Console.Write(vet[i]+" ");
            }
            Console.WriteLine();
            double maior, menor;
            ObterMaiorMenor(vet,out maior,out menor);
            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Menor valor: {menor}");
            Console.ReadLine();
        }
    }
}
