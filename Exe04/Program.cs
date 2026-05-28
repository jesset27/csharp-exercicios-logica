using System;
namespace Exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Exercício 4: Positivo, Negativo ou Zero?");
            System.Console.WriteLine("Digite um número:");
            int number = int.Parse(Console.ReadLine());
            if(number < 0)
            {
                System.Console.WriteLine("Seu número é negativo");
            } else if (number > 0)
            {  
                System.Console.WriteLine("Seu número é positivo");
                if (number % 2 == 0)
                {
                    System.Console.WriteLine("Seu número é par");
                }
                else
                {
                    System.Console.WriteLine("Seu número é impar");
                }
            }
            else
            {
                System.Console.WriteLine("Seu número é neutro");
            }
        }
    }
}