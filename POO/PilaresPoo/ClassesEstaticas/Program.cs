using ClassesEstaticas;

// Console.WriteLine($"Soma de 5 e 10: {CalculosMatematicos.Somar(5, 10)}");
// Console.WriteLine($"Soma de 50,2 e 10,7: {CalculosMatematicos.Somar(50.2f, 10.7f)}");
// Console.WriteLine($"Divisão de 5 por 0 é{CalculosMatematicos.Dividir(5, 0)}");

Console.WriteLine($"Digite o primeiro número:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número:");
 float n2 = float.Parse(Console.ReadLine());

// Console.WriteLine($"Resultados:");
// Console.WriteLine($"Soma: {CalculosMatematicos.Somar(n1, n2)}");
// Console.WriteLine($"Subtração: {CalculosMatematicos.Subtrair(n1, n2)}");
// Console.WriteLine($"Multiplicação: {CalculosMatematicos.Multiplicar(n1, n2)}");
// Console.WriteLine($"Divisão: {CalculosMatematicos.Dividir(n1, n2)}");

Console.WriteLine($"O Maior número é: {Math.Max(n1, n2)}");
Console.WriteLine($"O Menor número é: {Math.Min(n1, n2)}");
