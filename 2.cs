using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    class Program
    {
        static double Hipotenusa(int A, int B)
        {
            double calchip = Math.Sqrt((double)Math.Pow(A,2) + (double)Math.Pow(B,2));
            return calchip;
        }
        static void Main(string[] args)
        {
            int a, b;
            double hip;
            Console.WriteLine("Dê um valor pro lador do triângulo");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dê um valor pro lador do triângulo");
            b = int.Parse(Console.ReadLine());
            hip = Hipotenusa(a, b);
            Console.WriteLine("O valor da sua Hipotenusa é: " + hip);
            Console.ReadLine();
        }
    }
}
