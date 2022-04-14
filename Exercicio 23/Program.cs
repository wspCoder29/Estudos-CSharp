using System;

namespace TEST9
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Faça um programa que apresente o menu de opções a seguir: (vale 3
             pontos)
             Menu de opções:
             1. Soma
             2. IMC
             3. Sair
             Digite a opção desejada:
             Na opção 1: receber dois números, calcular e mostrar a soma.
             Na opção 2: receber peso e altura, calcular e mostrar o seguinte resultado:
             a) Se menor que 18.5 mostrar o resultado e escrever “Peso abaixo do
             normal”.
             b) Se entre 18.5 e 25 mostrar o resultado e escrever “Peso normal”.
             c) Se maior que 25 até 30 mostrar o resultado e escrever “Sobre o peso”.
             d) Se maior que 30 até 35 mostrar o resultado e escrever “Grau de
             obesidade I”.
             Na opção 3: sair do programa.
             Verifique a possibilidade de opção inválida, mostrando uma mensagem.
             */



            bool control = true;

            while (control)
            {
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - IMC");
                Console.WriteLine("3 - Sair");
                Console.Write("Op: ");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (op != 1 && op != 2 && op != 3)
                {
                    Console.WriteLine("Opção Inválida 1, 2, ou 3");
                }

                if (op == 3)
                {
                    Console.WriteLine("Sair");
                    control = false;
                }

                switch (op)
                {
                    case 1:
                        Somar();
                        break;

                    case 2:
                        AvaliaIMC(IMC());
                        break;
                }

            }
        }




        public static void Somar()
        {
            Console.WriteLine("==Soma=========");
            double a, b;
            Console.Write("Digite A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write($"Soma {a} + {b} = {a + b}");
            Console.WriteLine();
            Console.WriteLine("================");
        }


        public static void AvaliaIMC(double IMC)
        {
            Console.WriteLine("Valor IMC:" + IMC.ToString("F1"));

            if (IMC < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
            }
            else if (IMC >= 18.5 && IMC <= 25)
            {
                Console.WriteLine("Peso Normal");

            }
            else if (IMC > 25 && IMC <= 30)
            {
                Console.WriteLine("Sobrepeso");

            }
            else if (IMC > 30 && IMC <= 35)
            {
                Console.WriteLine("Grau de obesidade I");
            }
        }

        public static double IMC()
        {
            Console.WriteLine("================");
            Console.WriteLine("IMC");
            Console.Write("Peso Kg: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Altura cm: ");
            double altura = double.Parse(Console.ReadLine());

            double calcImc = peso / Math.Pow(altura, 2);

            Console.WriteLine("================");
            Console.WriteLine();

            return calcImc;
        }



    }
}
