Console.WriteLine("Quantos números você deseja digitar?");
int quantidade = int.Parse(Console.ReadLine());

int contador = 1;

while (contador <= quantidade)
{
    Console.WriteLine($"Digite o {contador + 1}º número:");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é PAR!");
    }

    contador++;
}

Console.WriteLine("Fim do programa!");