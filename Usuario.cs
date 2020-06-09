namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome { get; set; }
        private string login = "biasilva@hotmail.com";
        private string senha = "4186532157924251";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){
            
            if(this.login == login && this.senha == senha){
                TokenLogin = "fnniodiodsofvokvgreovgrfpokr";
                return true;
            }
            return false;
        }
        public void Logout(){
            TokenLogin = "";
        }


    }
}