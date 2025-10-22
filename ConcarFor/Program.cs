// Perguntar ao usuário quantas letra tem o nome dele
//depois vamos pedir letra a letra de seu nome
//ao final, vamos exibir o nome do usuário completo

int qtdletras = 0;

Console.Write($"Olá usuário, quantas letras tem o seu nome?");
qtdletras = int.Parse(Console.ReadLine());
string nome = "";

for (int i = 1; i <= qtdletras; i++)
{
    Console.WriteLine($"Qual é a {i} letra?");
    nome += Console.ReadLine();
}

Console.WriteLine($"Seu nome é: {nome}");