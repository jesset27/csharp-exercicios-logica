using System;
namespace Exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Exercício 10: Aprovado ou Reprovado");
            System.Console.WriteLine("Digite a primeira nota:");
            double noteOne = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a segunda nota:");
            double noteTwo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a terceira nota:");
            double noteThree = double.Parse(Console.ReadLine());

            double media = (noteOne + noteTwo + noteThree) / 3;
            
            if (media >= 7)
            {
                System.Console.WriteLine("A frequencia do aluno é 75% ou mais? s/n");
                char frequecy = char.Parse(Console.ReadLine());
                if (frequecy == 's')
                {
                    System.Console.WriteLine($"Aluno esta aprovado com a media de {media}");
                }
                else
                {
                    System.Console.WriteLine($"Aluno deve ir para a recuperação, pois sua media é de {media}, mas não tem o minimo de frequencia");
                }
            }
            else
            {
                System.Console.WriteLine($"O aluno esta reprovado com a media {media}");
            }
        }
    }
}