
int media, frequencia;

Console.Write("Digite a média do aluno: ");
media = int.Parse(Console.ReadLine());

Console.Write("Digite a porcentagem da frequencia do aluno: ");
frequencia = int.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine("Aluno reprovado por frequência.");
}

else
{
    if (media >= 7)
    {
        Console.WriteLine("Aluno aprovado!");
    }
    else if (media >= 3 && media < 7)
    {
        Console.WriteLine("Aluno em recuperação.");
    }
    else
    {
        Console.WriteLine("Aluno reprovado por nota.");
    }
}

