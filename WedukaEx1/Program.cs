using System;
using System.Collections.Generic;
using WedukaEx1.Validators;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            var validador = new ValidadorDeColchetes();

            Console.Write("Insira uma sequência de colchetes, chaves ou parênteses: ");
            Console.WriteLine();
            Console.Write("Obs.: O código só será finalizado ao digitar sair.");
            Console.WriteLine();
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                break;
            }

            bool isValid = validador.IsValidBrackets(input);

            Console.WriteLine($"A sequência '{input}' é {(isValid ? "valida" : "não válida")}");
            Console.WriteLine();
        }
    }
}