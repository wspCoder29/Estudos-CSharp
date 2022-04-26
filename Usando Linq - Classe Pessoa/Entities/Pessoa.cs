using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTestes.Entities
{
    internal class Pessoa
    {

        public string Nome { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public int Idade { get; private set; }

        public int CalcularIdade()
        {
            DateTime dtNow = DateTime.Now;

            TimeSpan tp = dtNow.Subtract(DataNascimento);

           return Idade = tp.Days / 365;

        }


        public Pessoa() { }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            this.DataNascimento = dataNascimento;
            Idade = CalcularIdade();
        }

        
        public override string ToString()
        {
            string str = "";
            str += $"Nome: {Nome}, Data nascimento: {DataNascimento.ToShortDateString()}, Idade: {Idade}" + "\n";
            return str;
        }







    }
}
