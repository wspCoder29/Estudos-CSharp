using CALC_AREAS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC_AREAS.Entities
{
    internal class Retangulo : FormaGeometrica, ICalculosGerais
    {
        public Retangulo()
        {
        }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Base = largura;
        }

        public double CalculoDeArea()
        {
            return Altura * Base;
        }


    }
}
