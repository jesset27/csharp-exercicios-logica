using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Exercicio 1: Caixa Eletrônico");
            System.Console.WriteLine("Digite um número desejado por favor:");
            int valorDesejado = int.Parse(Console.ReadLine());
            if (valorDesejado % 10 == 0)
            {
                System.Console.WriteLine("Notas de 10 liberadas");
            }
            else
            {
                System.Console.WriteLine("Valor não aceito (precisa ser múltiplo de 10)");
            }
        }
    }
}