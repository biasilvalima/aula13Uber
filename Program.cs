using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            System.Console.WriteLine("Digite seu login:  ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:  ");
            string senha = Console.ReadLine();

            user.Login(login, senha);

                if(user.TokenLogin != "" && user.TokenLogin != null){  
                System.Console.WriteLine("Acesso liberado, Usuário logado");
                System.Console.WriteLine(user.TokenLogin);
            }else{
                System.Console.WriteLine("Usuário deslogado");
            }

            Cartao mastercard = new Cartao();

            mastercard.Titular = "Beatriz";
            mastercard.cvv = "107";
            
        System.Console.WriteLine("Digite nome do titular do cartão:  ");
        string Titular = Console.ReadLine();

        System.Console.WriteLine("Digite o cvv do cartão: ");
        string cvv = Console.ReadLine();

        mastercard.Cadastrar(Titular, cvv);
        System.Console.WriteLine("Cartão Cadastrado" +mastercard.Titular, mastercard.cvv);
        
        }
    }
}
