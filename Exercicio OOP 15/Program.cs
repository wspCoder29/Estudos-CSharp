using PESSOA_ENDERECO.Entities;
using System;
using System.Collections.Generic;

namespace PESSOA_ENDERECO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Crie uma Classe Pessoa, contendo os atributos (nome, endereço e telefone)
            encapsulados, com seus respectivos seletores (getters) e modificadores (setters), e
            ainda o construtor padrão. Por fim, criar uma classe principal que instancie o objeto
            Pessoa, adicione no mínimo um valor para cada atributo e imprima na tela.
            */


            List<Pessoa> li = new List<Pessoa>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Dados da pessoa [{i+1}]");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Tel: ");
                string tel = Console.ReadLine();

                Console.Write("Nome da rua: ");
                string nomeRua = Console.ReadLine();

                Console.Write("Número da casa:");
                int numeroCasa = int.Parse(Console.ReadLine());

                Console.Write("CEP: ");
                string cep = Console.ReadLine();

                Console.Write("Tipo: ");
                string tipo = Console.ReadLine();

                li.Add(new Pessoa(nome, new Endereco(nomeRua, numeroCasa, cep, tipo), tel));
                Console.WriteLine();

            }

            Console.WriteLine(" "+String.Join(' ',li));





        }
    }
}
