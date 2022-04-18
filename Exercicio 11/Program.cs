using System;
using System.Linq;

namespace ZTEST6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite num de 4 dígitos - 1000 e 9999");

            bool control = true;
            int input = 0;

            while (control)
            {
                if (input <= 999 | input > 9999)
                {
                    Console.Write("Num: ");
                    input = int.Parse(Console.ReadLine());
                }

                if (input <= 999 | input > 9999)
                {
                    Console.WriteLine("Deve estar entre 1000 e 9999");
                }
                else
                {
                    control = false;
                }
            }

            string converteInput = input.ToString();

            char[] c = converteInput.ToCharArray();

            int[] v = Array.ConvertAll(c, x => (int)Char.GetNumericValue(x));

            int totalPares = v.Where(x => x % 2 == 0).Count();

            Console.WriteLine("Total pares: " + totalPares);




        }
    }
}
