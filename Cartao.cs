using System;

namespace Aula13Uber
{
    public class Cartao
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public string Bandeira { get; set; }
        public string cvv { get; set; }

        public string Cadastrar(string titular)
        {
            return "Cartão cadastrado";
        }

        public string Excluir(){
            return "Cartão cancelado e excluído";
        }

        internal void Cadastrar(string titular, string cvv)
        {
            throw new NotImplementedException();
        }
    }
}