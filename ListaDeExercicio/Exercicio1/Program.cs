float salario, gastos;

Console.WriteLine("Qual e o seu salario");
salario = float.Parse(Console.ReadLine());

Console.WriteLine("Quanto são os seus gastos");
gastos = float.Parse(Console.ReadLine());

if (gastos <= salario)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado");
}
