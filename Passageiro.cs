namespace Aula13Uber
{
    public class Passageiro : Usuario
    {
        public string ProcurandoMotorista(){
            return "Procurando motoristas próximos";
        }
        public string Pagar(string StatusCorrida){
            if(StatusCorrida == "Finalizada"){
                return "Pagamento efetuado";
            }
            return "corrida não finalizada, realize o pagamento somente após ela finalizar";
        }        
    }
}