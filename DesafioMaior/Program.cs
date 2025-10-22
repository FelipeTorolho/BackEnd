//pedir para o usuário digitar dois números em seguida verificar qual e o maior número
int n1, n2;

Console.WriteLine("Digite um número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"esse número e maior: {n1}");
}
else if (n2 > n1)
{
    Console.WriteLine($"esse número e maior: {n2}");
}
else
{
    Console.WriteLine($"Os números são iguais: {n1} e {n2}");
}