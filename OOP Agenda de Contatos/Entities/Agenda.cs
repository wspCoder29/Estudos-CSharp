using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDA.Entities
{
    internal class Agenda
    {

        public List<Pessoa> li = new List<Pessoa>();

        //Carrega 3 contatos iniciais para teste
        public void Load()
        {
            li.Add(new Pessoa(4, "999999", 10));
            li.Add(new Pessoa(22, "3333333", 12));
            li.Add(new Pessoa(7, "666666", 9));
        }

        


        public void Menu()
        {
            bool control = true;
            while (control)
            {
                Console.WriteLine("1 - Inserir contato");
                Console.WriteLine("2 - Remover contato");
                Console.WriteLine("3 - Editar contato");
                Console.WriteLine("4 - Mostrar contatos");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        li.Add(AdicionarPessoa());
                        break;
                    case 2:
                        RemoverContato();
                        break;

                    case 3:
                        EditarContato();
                        break;

                    case 4:
                        ShowContatos();
                        break;

                    case 5:
                        Console.WriteLine("Sair");
                        control = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("===============");
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("===============");
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine();
        }


        public Pessoa AdicionarPessoa()
        {
            Console.WriteLine();
            Console.Write("Código Pessoa: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Tel: ");
            string tel = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return new Pessoa(codigo, tel, idade);
        }


        public void RemoverContato()
        {
            Console.WriteLine();
            Console.Write("Indique contato a ser removido: ");
            int remover = int.Parse(Console.ReadLine());
            li.RemoveAt(remover);
            Console.WriteLine($"Contato {remover} removido");
            Console.WriteLine();
        }


        public void EditarContato()
        {
            Console.WriteLine();
            Console.Write("Indique contato a ser editado: ");
            int contato = int.Parse(Console.ReadLine());
            li.RemoveAt(contato);
            li.Insert(contato, AdicionarPessoa());
            Console.WriteLine();
        }


        public void ShowContatos()
        {
            if (li.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("===========================");
                Console.WriteLine("Não há contatos cadastrados");
                Console.WriteLine("===========================");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("================================================");
                Console.WriteLine("Mostrando todos os contatos");

                for (int i = 0; i < li.Count; i++)
                {
                    Console.WriteLine($"Contato {i} ");
                    Console.WriteLine($"{li[i]}");
                }
                Console.WriteLine("================================================");
                Console.WriteLine();
            }
        }






    }
}
