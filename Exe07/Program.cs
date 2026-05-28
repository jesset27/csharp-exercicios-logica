using System;
namespace Exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Exercício 7: Triângulo Válido");
            System.Console.WriteLine("Digite o primeiro número:");
            int numberOne = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número:");
            int numberTwo = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o terceiro número:");
            int numberThree = int.Parse(Console.ReadLine());

            //3 4 10
            if (numberOne < (numberTwo + numberThree))
            {
                if (numberTwo < (numberThree + numberOne))
                {
                    if (numberThree < (numberOne + numberTwo))
                    {
                        System.Console.WriteLine("Triangulo Valido");
                    }else
                    {
                        System.Console.WriteLine("Triangulo Invalido");
                    }
                }else
                {
                    System.Console.WriteLine("Triangulo Invalido");
                }
            }
            else
            {
                System.Console.WriteLine("Triangulo Invalido");
            }


        }
    }
}