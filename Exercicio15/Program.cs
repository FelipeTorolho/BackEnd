int n1, n2, n3, n4, media;

Console.WriteLine("Digite a primeira nota");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota");
n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota");
n4 = int.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;


if (media >= 7)
{
    Console.WriteLine("Aluno Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Aluno em Recuperação");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}