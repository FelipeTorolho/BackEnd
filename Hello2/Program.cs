//Pedir para o usuário digitar o nome, sobrenome,idade, saldo bancário e quanto investiu esse ano

string nome;
string sobrenomeDoFulano;
int idade;
float saldoConta;
float investimentos;


Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o saldo bancário?");
saldoConta = float.Parse(Console.ReadLine());

Console.WriteLine("Quanto é o investimento para esse ano?");
investimentos = float.Parse(Console.ReadLine());


Console.Clear();//limpa o console
Console.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"Saldo Bancário: {saldoConta}");
Console.WriteLine($"Investimentos este ano: {investimentos}");