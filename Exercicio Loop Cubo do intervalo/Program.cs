using System;
using System.Collections.Generic;

namespace ZZZTEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Escreva um programa que peça ao usuário dois números:
             a. Intervalo Inicial
             b. Intervalo Final
             Percorra o intervalo e imprima o cubo de cada número do intervalo. Tanto
             intervalo inicial como intervalo final devem fazer parte.
             O programa deverá parar se o usuário digitar um intervalo maior que 15.
             Exemplo:
             • Intervalo Inicial: 5 | Intervalo Final: 15 (intervalo = 10, válido)
             • Intervalo Inicial: 5 | Intervalo Final: 26 (intervalo = 21, inválido).
            */

            //FAZER O INPUT INICIAL 
            int ini = 1;

            int fim = 122;

            int diferenca = fim - ini;

            bool control = true;
            while (control)
            {

                if (ini > fim)
                {
                    Console.WriteLine($"inicio [{ini}] tem de ser menor que fim [{fim}]");
                    Console.Write("ini: ");
                    ini = int.Parse(Console.ReadLine());
                    Console.Write("fim: ");
                    fim = int.Parse(Console.ReadLine());
                }

                diferenca = fim - ini;

                if (diferenca > 15)
                {
                    Console.WriteLine("Intervalo inválido, é > 15");
                    Console.Write("Ini: ");
                    ini = int.Parse(Console.ReadLine());

                    Console.Write("Fim: ");
                    fim = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();
                if (ini < fim && diferenca < 15)
                {
                    control = false;
                }
            }



            for (int i = ini; i <= fim; i++)
            {
                Console.WriteLine(i + " : " + Math.Pow(i, 3));
            }









        }
    }
}
