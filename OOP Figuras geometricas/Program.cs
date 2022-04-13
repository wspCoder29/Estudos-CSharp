using CALC_AREAS.Entities;
using System;
using System.Globalization;

namespace CALCAREA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Escreva um programa que contenha uma interface chamada
            calculosGerais. Essa interface deve conter um único método
            chamado calculoDeArea. Crie também quatro classes que deverão
            implementar a interface calculosGerais. As classes serão
            Triangulo, Retangulo, Quadrado e Trapezio. O programa deverá
            imprimir a área de cada uma das figuras geométricas
            apresentadas abaixo*/


            //Base Altura
            Quadrado quadrado = new Quadrado(10, 10);
            Console.WriteLine("Quadrado: " + quadrado.CalculoDeArea().ToString("F2", CultureInfo.InvariantCulture));


            //Base Altura
            Retangulo ret = new Retangulo(10, 10);
            Console.WriteLine("Retangulo: " + ret.CalculoDeArea().ToString("F2", CultureInfo.InvariantCulture));


            //Base, Altura
            Triangulo tri = new Triangulo(10, 10);
            Console.WriteLine("Triangulo: " + tri.CalculoDeArea().ToString("F2", CultureInfo.InvariantCulture));


            //base Maior base Menor Altura
            Trapezio tp = new Trapezio(24, 9, 15);
            Console.WriteLine("Trapezio: " + tp.CalculoDeArea().ToString("F1", CultureInfo.InvariantCulture));


            

        }



    }
}
