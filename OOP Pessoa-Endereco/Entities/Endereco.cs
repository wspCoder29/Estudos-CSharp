using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESSOA_ENDERECO.Entities
{
    class Endereco
    {

        public string Rua { get; private set; }

        public int Numero { get; private set; }

        public string CEP { get; private set; }

        public string Tipo { get; private set; }


        public Endereco() { }

        public Endereco(string rua, int numero, string cEP, string tipo)
        {
            Rua = rua;
            Numero = numero;
            CEP = cEP;
            Tipo = tipo;
        }


        public override string ToString()
        {
            string str = "";
            str += $"{Rua}, Número: {Numero}, CEP: {CEP}, Tipo: {Tipo}";
            return str;
        }







    }
}
