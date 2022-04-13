using System;


namespace IMPOSTO.Entities
{
    class IPI : IImposto
    {

        public double Valor { get; set; }

        public IPI(double valor)
        {
            Valor = valor;
        }


        public double CalcularImposto()
        {
            /*
            IPI - Se valor < 25000 imposto de 5 %
            else imposto de 1 %
            */
            double calcValorImposto = 0;
            if (Valor < 25000)
            {
                calcValorImposto = Valor * 0.05;
            }
            else
            {
                //imposto de 1%
                calcValorImposto = Valor * 0.01;
            }
            return calcValorImposto;
        }


    }
}
