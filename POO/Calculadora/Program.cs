using Calculadora;

Calculator calc = new Calculator();
int opcao = 0;

while (opcao != 0)
{
    Console.Clear();
    Console.WriteLine("=== CALCULADORA C# Console ===");
    Console.WriteLine();

    Console.WriteLine("   1 - Somar");
    Console.WriteLine("   2 - Subtrair");
    Console.WriteLine("   3 - Multiplicar");
    Console.WriteLine("   4 - Dividir");
    Console.WriteLine("   0 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o primeiro número: ");
            calc.Num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            calc.Num2 = double.Parse(Console.ReadLine());
            calc.Somar();
            break;

        case 2:
            Console.Write("Digite o primeiro número: ");
            calc.Num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            calc.Num2 = double.Parse(Console.ReadLine());
            calc.Subtrair();
            break;

        case 3:
            Console.Write("Digite o primeiro número: ");
            calc.Num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            calc.Num2 = double.Parse(Console.ReadLine());
            calc.Multiplicar();
            break;

        case 4:
            Console.Write("Digite o primeiro número: ");
            calc.Num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            calc.Num2 = double.Parse(Console.ReadLine());
            calc.Dividir();
            break;

        case 0:
            Console.WriteLine("Encerrando o programa...");
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }
}

// calc.Num1 = 50;
// calc.Num2 = 10;

// Console.WriteLine($"== Calculadora ==");
// Console.WriteLine($"Primeiro número: {calc.Num1}");
// Console.WriteLine($"Segundo número: {calc.Num2}");

// Console.WriteLine($"Resultados: ");
// Console.WriteLine();

// Console.WriteLine($"Soma {calc.Somar()}");
// Console.WriteLine();

// Console.WriteLine($"Subtração {calc.Subtrair()}");
// Console.WriteLine();

// Console.WriteLine($"Multiplicação {calc.Multiplicar()}");
// Console.WriteLine();

// Console.WriteLine($"Divisão {calc.Dividir()}");
// Console.WriteLine();