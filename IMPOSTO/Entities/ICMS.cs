using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPOSTO.Entities
{

    class ICMS : IImposto
    {

        public double Valor { get; set; }

        public ICMS(double valor)
        {
            Valor = valor;
        }

        public double CalcularImposto()
        {
            return Valor * 0.03;
        }

        




    }
}
