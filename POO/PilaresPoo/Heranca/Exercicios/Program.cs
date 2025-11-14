using Heranca;
Console.Clear();
// Carro fusca = new Carro();
// Veiculo generic = new Veiculo();

// Aviao airBussA320 = new Aviao();
// Moto HarleyDavilson = new Moto();
// HarleyDavilson.Marca = "HarleyDavilson";
// HarleyDavilson.Modelo = "Fat Boy";
// HarleyDavilson.Ano = 2028;
// HarleyDavilson.SomDaMoto();

// airBussA320.Marca = "LATAM AirBuss";
// airBussA320.Modelo = "AirBuss 320";
// airBussA320.Ano = 2022;
// airBussA320.QtdAsas = 2;
// airBussA320.Voar();

// Animal animal = new Animal();
// Cachorro cachorro = new Cachorro();
// Gato gato = new Gato();
// animal.FazerSom();
// cachorro.FazerSom();
// gato.FazerSom();

// Funcionario f1 = new Funcionario("Ana", 3000);
// Gerente g1 = new Gerente("Carlos", 5000, 2000);

// Console.WriteLine($"Funcionário: {f1.Nome} - Salário: R${f1.CalcularSalario()}");
// Console.WriteLine($"Gerente: {g1.Nome} - Salário Total: R${g1.CalcularSalario()}");

// ContaPoupanca cp = new ContaPoupanca();
// cp.Numero = 123;
// cp.Depositar(1000);
// Console.WriteLine($"Saldo antes do rendimento: R$ {cp.Saldo:F2}");
// cp.CalcularRendimento();
// Console.WriteLine($"Saldo após rendimento: R$ {cp.Saldo:F2}");

Pessoa aluno = new Pessoa();
aluno.Nome = "Torolho";
aluno.Idade = 16;
aluno.Curso = "TI";
aluno.ExibirInfo();
Console.WriteLine($"");

Professor professor = new Professor();
professor.Nome = "João";
professor.Idade = 56;
professor.Disciplina = "TI";
professor.ExibirInfo();


Console.WriteLine("=== Dados do Aluno ===");
Console.WriteLine($"Nome: {aluno.Nome}");
Console.WriteLine($"Idade: {aluno.Idade}");
Console.WriteLine($"Curso: {aluno.Curso}");
Console.WriteLine("=== Dados do Professor ===");
Console.WriteLine($"Nome: {professor.Nome}");
Console.WriteLine($"Idade: {professor.Idade}");
Console.WriteLine($"Disciplina: {professor.Disciplina}");