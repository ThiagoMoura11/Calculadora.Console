using System;

class Calculator
{
    static double memory = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Calculadora Complexa");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Memória");
            Console.WriteLine("6. Limpar Memória");
            Console.WriteLine("7. Sair");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 7)
            {
                Console.WriteLine("Obrigado por usar a calculadora!");
                break;
            }

            double num1, num2, result;

            switch (choice)
            {
                case 1:
                    num1 = GetNumber("Digite o primeiro número: ");
                    num2 = GetNumber("Digite o segundo número: ");
                    result = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {result}");
                    break;
                case 2:
                    num1 = GetNumber("Digite o primeiro número: ");
                    num2 = GetNumber("Digite o segundo número: ");
                    result = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {result}");
                    break;
                case 3:
                    num1 = GetNumber("Digite o primeiro número: ");
                    num2 = GetNumber("Digite o segundo número: ");
                    result = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {result}");
                    break;
                case 4:
                    num1 = GetNumber("Digite o primeiro número: ");
                    num2 = GetNumber("Digite o segundo número: ");
                    if (num2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {result}");
                    }
                    break;
                case 5:
                    Console.WriteLine($"Valor na memória: {memory}");
                    break;
                case 6:
                    memory = 0;
                    Console.WriteLine("Memória limpa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static double GetNumber(string message)
    {
        Console.Write(message);
        return double.Parse(Console.ReadLine());
    }
}
