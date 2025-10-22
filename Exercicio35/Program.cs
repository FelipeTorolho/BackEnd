int qtdrepeticoes, contador = 1;

Console.Write("Digite o número de repetições: ");
qtdrepeticoes = int.Parse(Console.ReadLine());

while (contador <= qtdrepeticoes)
{
    Console.WriteLine($"Repetição {contador}:");

    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine($"O maior número é: {num1}");
    }
    else if (num2 > num1)
    {
        Console.WriteLine($"O maior número é: {num2}");
    }
    else
    {
        Console.WriteLine("Os dois números são iguais.");
    }

    contador++;
}