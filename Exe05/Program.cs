using System;
namespace Exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Peça três informações: temCnh (true/false), estaNaAutoEscola (true/false) e idade (int).  
            System.Console.WriteLine("Exercício 5: Pode Dirigir?");
            System.Console.WriteLine("A pessoa em questão possui CNH? s/n");
            char temCnh = char.Parse(Console.ReadLine());
            System.Console.WriteLine("Esta na autoescola? s/n");
            char estaNaAutoEscola = char.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual a idade da pessoa em questão?");
            int idade = int.Parse(Console.ReadLine());
            if (temCnh == 's' && idade >= 18 & estaNaAutoEscola == 'n')
            {
                System.Console.WriteLine("Pode dirigir!");
            }
            else
            {
                System.Console.WriteLine("Nao pode dirigir");
            }
        }
    }
}