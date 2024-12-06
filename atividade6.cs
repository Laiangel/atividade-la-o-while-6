using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEscolha uma operação (+, -, *, /) ou digite 'sair' para encerrar:");
            string operacao = Console.ReadLine();

            // Verifica se o usuário deseja sair
            if (operacao.Equals("sair", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Calculadora encerrada. Até logo!");
                break;
            }

            // Verifica se a operação é válida
            if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
            {
                Console.WriteLine("Operação inválida. Tente novamente.");
                continue;
            }

            // Solicita os dois números do usuário
            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                continue;
            }

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                continue;
            }

            // Realiza o cálculo com base na operação escolhida
            double resultado;
            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Divisão por zero não é permitida. Tente novamente.");
                        continue;
                    }
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Erro inesperado. Tente novamente.");
                    continue;
            }

            // Exibe o resultado
            Console.WriteLine($"Resultado: {num1} {operacao} {num2} = {resultado}");
        }
    }
}



