using System;
using System.Linq;

namespace FIBO
{
    internal class Program
    {
        static void Main(string[] args)
        {
        


            //  1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584


            //GERADOR DE FIBONACCI
            //Verifica se item esta dentro da sequencia de Fibonacci
            int enesimoItem = 20;
            bool test = false;

            //Procurar
            int alvo = 55;

            int y = 1, x = 0;
            Console.Write(x + " " + y + " ");
            for (int i = 0; i < enesimoItem - 2; i++)
            {
                y = y + x;
                x = y - x;
                Console.Write(y + " ");

                if (y==alvo)
                {
                    test = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine(alvo+" "+test);




        }
    }
}
