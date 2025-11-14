using Exercicio02;

Funcionario funComum = new Funcionario();
Gerente gerente = new Gerente();

funComum.SalarioBase = 1000;
gerente.SalarioBase = 10000;

float SalFinalComum = funComum.CalcularSalario();
float SalFinalGer = gerente.CalcularSalario();

Console.WriteLine($"Salario do Funcionário: {SalFinalComum}");
Console.WriteLine($"Salario do Gerente: {SalFinalGer}");
