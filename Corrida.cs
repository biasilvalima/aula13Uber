namespace Aula13Uber
{
    public class Corrida
    {
        public string Localizacao { get; set; }
        public string LocalChegada { get; set; }
        public string StatusCorrida { get; set; }
        public string Motorista { get; set; }
        public string Passageiro { get; set; }

        public string CancelarCorida(){
            return "Sua corrida foi cancelada";
        }        
    }
}