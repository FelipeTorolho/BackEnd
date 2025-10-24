int senhaDigitada, senhaCorreta = 1234;

Console.WriteLine("Qual e Senha?");
senhaDigitada = int.Parse(Console.ReadLine());

if (senhaDigitada == senhaCorreta)
{
    Console.WriteLine("Acesso Liberado");
}
else
{
    Console.WriteLine("Acesso Negado");
}