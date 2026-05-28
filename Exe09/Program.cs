using System;
namespace Exe09
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Exercício 9: Cardápio de Lanches");
            System.Console.WriteLine("1-	X-Burger	R$ 12,00");
            System.Console.WriteLine("2-	X-Salada	R$ 14,00");
            System.Console.WriteLine("3-	X-Bacon	R$ 16,00");
            System.Console.WriteLine("Digite o código do produto e a quantidade desejada:");
            System.Console.WriteLine("Digite o código");
            int code = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a quantidade:");
            int amount = int.Parse(Console.ReadLine());

            if (code == 1)
            {
                int price = 12;
                int priceFinal = price * amount;
                System.Console.WriteLine($"O valor total da compra ficará: {priceFinal} reais");
            } else if(code == 2)
            {
                int price = 14;
                int priceFinal = price * amount;
                System.Console.WriteLine($"O valor total da compra ficará: {priceFinal} reais");
            }else if (code == 3)
            {
                int price = 16;
                int priceFinal = price * amount;
                System.Console.WriteLine($"O valor total da compra ficará: {priceFinal} reais");
            }
        }
    }
}