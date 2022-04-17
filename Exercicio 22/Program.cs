using System;
using System.Globalization;

namespace ZTEST4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calcula a expectativa de vida

            string dataNasc = "01/01/1990";
            string genero = "F";

            DateTime dtAtual = DateTime.Now;

            DateTime dtNasc = DateTime.ParseExact(dataNasc, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int idade = dtAtual.Subtract(dtNasc).Days / 365;

            Console.WriteLine("Idade: " + idade);

            int expectativaDeVida = 0;
            if (genero == "M")
            {
                expectativaDeVida = 80 - idade;

            }
            else if (genero == "F")
            {
                expectativaDeVida = 90 - idade;
            }

            Console.WriteLine($"Expectativa de vida: {expectativaDeVida} anos");





        }
    }
}
