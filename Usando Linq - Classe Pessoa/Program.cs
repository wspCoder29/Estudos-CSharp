using System;
using System.Collections.Generic;
using ZTestes.Entities;
using System.Linq;
using System.Globalization;

namespace Testes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Classe Pessoa com atributos, nome e data de nascimento
            //Separar pessoas por idade, por nome, remover de acordo com idade indicada
            

            /* INPUT PARA TESTE
            Pessoa p1 = new Pessoa("Zia", DateTime.Parse("01/01/1990"));
            Pessoa p2 = new Pessoa("Ada", DateTime.Parse("01/01/1995"));
            Pessoa p3 = new Pessoa("Bia", DateTime.Parse("01/01/1985"));
            Pessoa p4 = new Pessoa("Kia", DateTime.Parse("01/01/2000"));
            Pessoa p5 = new Pessoa("Are", DateTime.Parse("01/01/2010"));

            List<Pessoa> li = new List<Pessoa>();
            li.Add(p1);
            li.Add(p2);
            li.Add(p3);
            li.Add(p4);
            li.Add(p5);
            */

            List<Pessoa> li = new List<Pessoa>();


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Indique nome: ");
                string nome = Console.ReadLine();

                Console.Write("Indique data nasc:");
                DateTime nasc = ValidarDataNasc();

                li.Add(new Pessoa(nome, nasc));
            }

            Console.WriteLine();
            Console.WriteLine("Input original");
            Console.WriteLine(" " + String.Join(' ', li));

            li = li.OrderBy(x => x.Nome).ToList();

            Console.WriteLine("Por Nome");
            Console.WriteLine(" " + String.Join(' ', li));

            li = li.OrderByDescending(x => x.Idade).ToList();

            Console.WriteLine("Por Idade");
            Console.WriteLine(" " + String.Join(' ', li));

            Console.WriteLine();
            Console.WriteLine("Exibe quem tem mais de 30 anos");
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].Idade > 30)
                {
                    Console.WriteLine(li[i]);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Remove todos com menos de 20, ordena por idade Maior Menor");

            li = li.Where(x => x.Idade > 20).OrderByDescending(x => x.Idade).ToList();

            Console.WriteLine(String.Join(' ', li));

            Console.WriteLine("Exibe total de pessoas restantes na lista");
            int cont = li.Count();
            Console.WriteLine("Total: " + cont);
            
        }

        public static DateTime ValidarDataNasc()
        {
            string dataInput = "";
            bool control = true;
            DateTime nasc = DateTime.Now;
            while (control)
            {
                try
                {
                    //Console.Write("Indique Data de Nasc: ");
                    dataInput = Console.ReadLine();
                    nasc = DateTime.ParseExact(dataInput, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    control = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Data inválida [dd/MM/yyyy]");
                }
            }

            return nasc;
        }



    }
}
