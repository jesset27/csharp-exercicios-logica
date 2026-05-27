using System;
namespace Exe03;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Exercício 3: Classificando Nadadores");
        System.Console.WriteLine("Digite a idade do Nadador por favor:");
        int age = int.Parse(Console.ReadLine());
        if (age >= 5 && age <= 7)
        {
            System.Console.WriteLine("Infantil A: 5 a 7 anos");
        }else if (age >= 8 && age <= 10){
            System.Console.WriteLine("Infantil B: 8 a 10 anos");
        }else if(age >= 11 && age <= 13){
            System.Console.WriteLine("Juvenil A: 11 a 13 anos");
        }else if (age >= 14 && age <= 17)
        {
            System.Console.WriteLine("Juvenil B: 14 a 17 anos");
        }else if (age >= 18)
        {
            System.Console.WriteLine("Adulto: 18 anos ou mais");
        }
        else
        {
            System.Console.WriteLine("Fora da faixa etária para menores de 5.");
        }
    }
}