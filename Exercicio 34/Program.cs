using System;

namespace TESTE7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o multiplicador: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Início do intervalo: ");
            int inicioIntervalo = int.Parse(Console.ReadLine());

            Console.Write("Fim do intervalo: ");
            int fimIntervalo = int.Parse(Console.ReadLine());

            int resultado = 0;


            for (int i = inicioIntervalo; i <= fimIntervalo; i++)
            {
                if (m <= 1000 || inicioIntervalo > fimIntervalo || inicioIntervalo < 0 || fimIntervalo < 0)
                {
                    resultado = m * i;
                }
                Console.WriteLine($"{m} x {i} = " + resultado);



            }
        }
    }
}
