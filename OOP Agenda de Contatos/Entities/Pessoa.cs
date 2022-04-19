using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGENDA.Entities
{
    class Pessoa
    {

        public int Codigo { get; private set; }

        public string NumeroTelefone { get; private set; }

        public int Idade { get; private set; }

        public Pessoa() { }

        public Pessoa(int codigo, string numeroTelefone, int idade)
        {
            Codigo = codigo;
            NumeroTelefone = numeroTelefone;
            Idade = idade;
        }


        public override string ToString()
        {
            string str = "";
            str += $"Código Contato: {Codigo} | Tel: {NumeroTelefone} | Idade: {Idade} \n";
            return str;
        }









    }
}
