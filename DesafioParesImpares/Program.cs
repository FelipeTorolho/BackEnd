int qtdNumeros;

Console.WriteLine($"Quantos números Você quer digitar?");
qtdNumeros = int.Parse(Console.ReadLine());
string pares = "Pares: ";
string impares = "impares: ";

for (int i = 1; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i} numero");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        pares += numeroDigitado.ToString() + ", ";
    }
    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}

Console.Clear();
Console.WriteLine($"Resultado:");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);