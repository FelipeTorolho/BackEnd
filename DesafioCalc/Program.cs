//Pedir para o usuário digitar dois números e exibir a soma desses dois números
float n1, n2;

Console.WriteLine("Digite um número");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"A soma de {n1} + {n2} é {n1+n2}");