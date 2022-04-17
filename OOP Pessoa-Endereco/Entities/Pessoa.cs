using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESSOA_ENDERECO.Entities
{
    class Pessoa
    {

        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Telefone { get; private set; }

        public Pessoa() { }

        public Pessoa(string nome, Endereco endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }


        public override string ToString()
        {
            string str = "";
            str += $"{Nome}, {Endereco}, Tel: {Telefone}" + "\n";
            return str;
        }




    }
}
