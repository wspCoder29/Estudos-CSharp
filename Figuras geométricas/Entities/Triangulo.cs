using CALC_AREAS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC_AREAS.Entities
{
    internal class Triangulo : FormaGeometrica, ICalculosGerais
    {

        public Triangulo() { }

        public Triangulo(double baseMedida, double altura)
        {
            Altura = altura;
            Base = baseMedida;
        }


        public double CalculoDeArea()
        {
            //Area triângulo
            return (Altura * Base) / 2;
        }






    }
}
