using System;

namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        public string Carro { get; set; }
        public string Placa { get; set; }

        public string AceitarPassageiro(string Nome)
        {
            if (Nome != "")
            {
                return "Passageiro aceito";
            }
            return "Passageiro não encontrado";
        }

        public string ReceberPagamento(string StatusCorrida){
           if(StatusCorrida == "Finalizada"){
               return "Você recebeu o pagamento da corrida";
           }
           return "O pagamento ainda não foi concludio, pois a corrida ainda finalizou";
        } 

    }
}