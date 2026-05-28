using System;
using System.Net;
namespace Exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Exercício 6: Calculadora de IMC");
            System.Console.WriteLine("Digite seu peso em KG:");
            double peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite sua altura em M:");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);

            switch (imc)
            {
                case double i when i < 18.5:
                System.Console.WriteLine("Abaixo do Peso!");
                break;

                case double i when i >= 18.5 && i <= 24.9:
                System.Console.WriteLine("Peso Normal");
                break;

                case double i when i >= 25 && i <= 29.9:
                System.Console.WriteLine("Sobre Peso");
                break;

                default: 
                System.Console.WriteLine("Obesidade"); 
                break;
            }
        }
    }
}