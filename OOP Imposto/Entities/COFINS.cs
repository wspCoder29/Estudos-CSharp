using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPOSTO.Entities
{
    class COFINS : IImposto

    {
        public double Valor { get; set; }

        public COFINS(double valor)
        {
            Valor = valor;
        }

        public double CalcularImposto()
        {
            double calcValorImposto = 0;
            // Cofins - Regra: 
            //se valor > 17000 - imposto de 8%

            if (Valor > 17000)
            {
                calcValorImposto = Valor * 0.08;
            }
            else
            {
                calcValorImposto = 0;
            }
            return calcValorImposto;
        }


        



    }
}
