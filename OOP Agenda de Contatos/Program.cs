using AGENDA.Entities;
using System;

namespace AGENDA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Crie uma agenda que armazena: código da pessoa, número do telefone, idade. 
                Sua agenda deve possibilitar: (vale 3 pontos)
                (1) – inserir um contato
                (2) – Remover um contato
                (3) – Editar um contato
            */

            Agenda agenda = new Agenda();

            //Carrega 3 contatos para teste
            agenda.Load();

            //Mostra os contatos cadastrados
            agenda.ShowContatos();

            //Menu na classe Agenda
            agenda.Menu();

            agenda.ShowContatos();






        }
    }
}
