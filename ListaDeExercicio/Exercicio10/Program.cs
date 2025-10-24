string resultado = "";
int opcao;

do
{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("        Menu de Exercícios 1 a 6");
    Console.WriteLine("-------------------------------------------------------");

    Console.WriteLine("Escolha o exercício que deseja executar:");
    Console.WriteLine("1) Exercício 1 - Gastos vs Salário");
    Console.WriteLine("2) Exercício 2 - Placar de Futebol");
    Console.WriteLine("3) Exercício 3 - Tipo de Triângulo");
    Console.WriteLine("4) Exercício 4 - Validação de Senha");
    Console.WriteLine("5) Exercício 5 - Compras de Maçãs");
    Console.WriteLine("6) Exercício 6 - Média e Frequência");
    Console.WriteLine("0) Sair");

    Console.Write("Digite sua opção: ");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            resultado = Exercicio1();
            break;
        case 2:
            resultado = Exercicio2();
            break;
        case 3:
            resultado = Exercicio3();
            break;
        case 4:
            resultado = Exercicio4();
            break;
        case 5:
            resultado = Exercicio5();
            break;
        case 6:
            resultado = Exercicio6();
            break;
        case 0:
            resultado = "Saindo do programa...";
            break;
        default:
            resultado = "Opção Inválida!";
            break;
    }

    Console.WriteLine(resultado);

} while (opcao != 0);

Console.WriteLine("Programa finalizado.");


// Exercício 1
string Exercicio1()
{
    Console.Write("Informe o salário recebido: ");
    double salario = double.Parse(Console.ReadLine());
    Console.Write("Informe o total gasto: ");
    double gastos = double.Parse(Console.ReadLine());

    if (gastos <= salario)
        return "Gastos dentro do orçamento";
    else
        return "Orçamento estourado";
}

// Exercício 2
string Exercicio2()
{
    Console.Write("Informe os gols do primeiro time: ");
    int gols1 = int.Parse(Console.ReadLine());
    Console.Write("Informe os gols do segundo time: ");
    int gols2 = int.Parse(Console.ReadLine());

    if (gols1 > gols2)
        return "Vitória do primeiro time!";
    else if (gols2 > gols1)
        return "Vitória do segundo time!";
    else
        return "Empate!";
}

// Exercício 3
string Exercicio3()
{
    Console.Write("Informe o primeiro lado do triângulo: ");
    double lado1 = double.Parse(Console.ReadLine());
    Console.Write("Informe o segundo lado do triângulo: ");
    double lado2 = double.Parse(Console.ReadLine());
    Console.Write("Informe o terceiro lado do triângulo: ");
    double lado3 = double.Parse(Console.ReadLine());

    if (lado1 == lado2 && lado2 == lado3)
        return "Triângulo Equilátero";
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        return "Triângulo Isósceles";
    else
        return "Triângulo Escaleno";
}

// Exercício 4
string Exercicio4()
{
    Console.Write("Digite a senha: ");
    int senha = int.Parse(Console.ReadLine());

    if (senha == 1234)
        return "ACESSO PERMITIDO";
    else
        return "ACESSO NEGADO";
}

// Exercício 5
string Exercicio5()
{
    Console.Write("Informe o número de maçãs compradas: ");
    int quantidade = int.Parse(Console.ReadLine());
    double preco = (quantidade < 12) ? 0.30 : 0.25;
    double total = quantidade * preco;
    return $"Valor total da compra: R$ {total:F2}";
}

// Exercício 6
string Exercicio6()
{
    Console.Write("Informe a média do aluno: ");
    double media = double.Parse(Console.ReadLine());
    Console.Write("Informe a frequência do aluno (em %): ");
    double frequencia = double.Parse(Console.ReadLine());

    if (frequencia < 75)
        return "Aluno REPROVADO por frequência insuficiente.";
    else if (media >= 7)
        return "Aluno APROVADO!";
    else if (media >= 3)
        return "Aluno em RECUPERAÇÃO.";
    else
        return "Aluno REPROVADO por média baixa.";
}
