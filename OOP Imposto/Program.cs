using IMPOSTO.Entities;
using System;

namespace IMPOSTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Valor de entrada R$: ");
            double valorInput = double.Parse(Console.ReadLine());

            ICMS icms = new ICMS(valorInput);
            IPI ipi = new IPI(valorInput);
            COFINS cofins = new COFINS(valorInput);

            Console.WriteLine($"Valor de entrada {valorInput:C2}");
            Console.WriteLine($"ICMS: {icms.CalcularImposto():C2}");
            Console.WriteLine($"IPI: {ipi.CalcularImposto():C2}");
            Console.WriteLine($"COFINS: {cofins.CalcularImposto():C2}");

            double valorTotal = icms.CalcularImposto() + ipi.CalcularImposto() + cofins.CalcularImposto();

            Console.WriteLine($"Valor Total: {valorTotal:C2}");

            



        }
    }
}
