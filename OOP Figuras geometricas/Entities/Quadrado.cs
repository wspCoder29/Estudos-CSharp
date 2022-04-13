using CALC_AREAS.Interfaces;

namespace CALC_AREAS.Entities
{
    class Quadrado : FormaGeometrica, ICalculosGerais
    {
        public Quadrado(double altura, double largura)
        {
            Altura = altura;
            Base = largura;
        }

        public Quadrado() { }


        public double CalculoDeArea()
        {
            return Altura * Base;
        }



    }
}
