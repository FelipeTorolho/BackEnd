string cargo;
double salario, salarioNovo = 0;

Console.WriteLine("O seu cargo na empresa é producao, administrativo ou diretoria?");
cargo = Console.ReadLine().ToLower(); // converte para minúsculas

Console.WriteLine("Qual é o seu salário?");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065);
}
else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075);
}
else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12);
}
else
{
    Console.WriteLine("Cargo inválido.");
}

Console.WriteLine($"O novo salário é: {salarioNovo}");
