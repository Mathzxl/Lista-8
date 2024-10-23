using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace atv_10
{
    internal class Program
    {
        static int[] LerMatriculas(string Disciplina)
        {
            int[] matriculas = new int[10];
            Console.WriteLine($"Informe os números de matrícula dos alunos matriculados em {Disciplina}:");

            for (int i = 0; i < matriculas.Length; i++)
            {
                Console.Write($"Aluno {i + 1}: ");
                matriculas[i] = int.Parse(Console.ReadLine());
            }

            return matriculas;
        }

        static int[] IntersecaoMatriculas(int[] vet1, int[] vet2)
        {
            int[] intersecao = new int[10];
            int count = 0; 
            for (int i = 0; i < vet1.Length; i++)
            {
                for (int j = 0; j < vet2.Length; j++)
                {
                    if (vet1[i] == vet2[j])
                    {
                        intersecao[count] = vet1[i];
                        count++;
                    }
                }
            }
            int[] resultadoFinal = new int[count];
            for (int i = 0; i < count; i++)
            {
                resultadoFinal[i] = intersecao[i];
            }

            return resultadoFinal;
        }


        static void Main(string[] args)
        {
            int[] matriculasAlgoritmos = LerMatriculas("Algoritmos e Técnicas de Programação");
            int[] matriculasDIW = LerMatriculas("DIW");
            int[] matriculasComuns = IntersecaoMatriculas(matriculasAlgoritmos, matriculasDIW);
            if (matriculasComuns.Length > 0)
            {
                Console.WriteLine("Os alunos matriculados em ambas as disciplinas são:");
                foreach (int matricula in matriculasComuns)
                {
                    Console.WriteLine($"Matrícula: {matricula}");
                }
            }
            else
            {
                Console.WriteLine("Não há alunos matriculados simultaneamente nas duas disciplinas.");
            }
            Console.ReadLine();
        }
    }
}
