Funcionario f1 = new Funcionario("Ana", 3000);
Gerente g1 = new Gerente("Carlos", 5000, 2000);

Console.WriteLine($"Funcionário: {f1.Nome} - Salário: R${f1.CalcularSalario()}");
Console.WriteLine($"Gerente: {g1.Nome} - Salário Total: R${g1.CalcularSalario()}");

ContaPoupanca cp = new ContaPoupanca();
cp.Numero = 123;
cp.Depositar(1000);
Console.WriteLine($"Saldo antes do rendimento: R$ {cp.Saldo:F2}");
cp.CalcularRendimento();
Console.WriteLine($"Saldo após rendimento: R$ {cp.Saldo:F2}");