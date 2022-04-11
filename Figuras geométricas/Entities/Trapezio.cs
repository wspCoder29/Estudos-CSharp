using CALC_AREAS.Interfaces;


namespace CALC_AREAS.Entities
{
    internal class Trapezio : FormaGeometrica, ICalculosGerais
    {

        public double base2 { get; set; }

        public Trapezio() { }


        public Trapezio(double base1, double bas2, double altura)
        {
            Altura = altura;
            Base = base1;
            base2 = bas2;
        }


        public double CalculoDeArea()
        {
            //Area trapezio
            return ((Base+base2)*Altura)/2;
        }




    }
}
