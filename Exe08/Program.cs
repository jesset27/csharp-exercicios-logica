using System;
namespace Exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Exercício 8: Ano Bissexto");
            System.Console.WriteLine("Digite seu ano por favor:");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    System.Console.WriteLine("É bissexto");
                } else if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        System.Console.WriteLine("É bissexto");
                    }
                    else
                    {
                        System.Console.WriteLine("Não é bissexto");
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Seu número não é bissexto");
            }
        }
    }
}