using System;
using System.Collections;
using System.Linq;

namespace Questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Preenche um vetor de int e não permite números repetidos

            int qtdItensVetor = 5;

            int[] v = new int[qtdItensVetor];
            int contZero = 0;

            bool test = false;
            for (int i = 0; i < qtdItensVetor; i++)
            {
                //var de input
                int num = 0;

                Console.Write("Indique num: ");
                num = int.Parse(Console.ReadLine());

                //monitora zero input
                if (num == 0)
                {
                    contZero++;
                }

                //se zero for digitado 1 vez será permitido somente 1 vez
                if (contZero == 1)
                {
                    v[i] = num;
                }
                else
                {
                    //verifica e retorna bool - o número digitado já está presente no vetor? true/false
                    test = v.Any(x => x == num);
                }

                // se não presente permite a atribuição do valor na posição correspondente no vetor
                if (!test)
                {
                    v[i] = num;
                }

                while (test)
                {
                    Console.Write($"{num} já está presente, digite outro número: ");
                    num = int.Parse(Console.ReadLine());

                    if (!v.Any(x => x == num))
                    {
                        test = false;
                        v[i] = num;
                    }
                }
                Console.WriteLine(test);
            }

            //usando Linq para Ordenar o vetor
            v = v.OrderBy(x => x).ToArray();

            Console.WriteLine(String.Join(' ', v));







        }
    }
}
