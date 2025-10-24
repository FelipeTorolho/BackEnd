double lado1, lado2, lado3;

Console.WriteLine("Digite o valor do primeiro lado do triângulo:");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo lado do triângulo:");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do terceiro lado do triângulo:");
lado3 = double.Parse(Console.ReadLine());


if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("O trangulo e Equilátero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("O trangulo e Isóscele");
}
else
{
    Console.WriteLine("O trangulo e  Escaleno");
}