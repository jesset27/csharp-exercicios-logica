using System;

namespace Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2: Validação de Login");
            System.Console.WriteLine("Digite seu usuário por favor:");
            string user = Console.ReadLine();
            System.Console.WriteLine("Digite sua senha por favor:");
            string password = Console.ReadLine();
            if (user == "admin" && password == "1234")
            {
                System.Console.WriteLine("Acesso Concedido!");
            }
            else
            {
                System.Console.WriteLine("Acesso Negado!");
            }
        }
    }
}