using System;

namespace Exercicios_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoA = 4.90f;
            double precoG = 5.30f;
            int litros; 

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Qual combustível o cliente comprou?");
            Console.WriteLine("   A-álcool           G-gasolina   ");
            Console.WriteLine("-----------------------------------");
            string combustivel = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Quantos litros o cliente comprou?");
            litros = int.Parse(Console.ReadLine());

            double aPagarA = precoA * litros;
            double aPagarG = precoG * litros;
            
            switch (combustivel.ToLower())
            {
                case "a":
                    if (litros < 20)
                    {
                        double discontoA = aPagarA * 0.03;
                        double valorFinal = aPagarA - discontoA;
                        Console.WriteLine($"Total final com o desconto aplicado é de: {valorFinal}");
                    }
                    else
                    {
                        double discontoA = aPagarA * 0.05;
                        double valorFinal = aPagarA - discontoA;
                        Console.WriteLine($"Total final com o desconto aplicado é de: {valorFinal}");
                    }
                    break;
                case "g":
                    if (litros < 20)
                    {
                        double discontoG = aPagarA * 0.04;
                        double valorFinal = aPagarG - discontoG;
                        Console.WriteLine($"Total final com o desconto aplicado é de: {valorFinal}"); 
                    }
                    else
                    {
                        double discontoG = aPagarA * 0.06;
                        double valorFinal = aPagarG - discontoG;
                        Console.WriteLine($"Total final com o desconto aplicado é de: {valorFinal}");
                    }
                    break;
                default:
                    Console.WriteLine("Entrada inválida, tente novamente");
                    break;
            }
            

        }
    }
}
