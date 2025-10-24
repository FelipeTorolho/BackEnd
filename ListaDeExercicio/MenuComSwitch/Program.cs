int opcao;

do
{

    Console.Clear();
    Console.WriteLine($"-----------------------------------------");
    Console.WriteLine($"             Bem Vindo                   ");
    Console.WriteLine($"                ao                       ");
    Console.WriteLine($"           Jacareca Food                 ");
    Console.WriteLine($"-----------------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"Escolha uma opção abaixo");
    Console.WriteLine();
    Console.WriteLine($"  1)  Hot Holl");
    Console.WriteLine($"  2)  Temaki");
    Console.WriteLine($"  3)  Sashimi");
    Console.WriteLine($"  4)  Yakisoba");
    Console.WriteLine($"  5)  Guioza");
    Console.WriteLine($"  6)  Shimeji");
    Console.WriteLine($"  0)  Sair");
    Console.WriteLine($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine();
            break;
        case 1:
            HotHool();
            break;
        case 2:
            Temaki();
            break;
        case 3:
            Sashimi();
            break;
        case 4:
            Yakisoba();
            break;
        case 5:
            Guioza();
            break;
        case 6:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }
    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();
} while (opcao != 0);


void HotHool()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Hot Holl com carinho");
}

void Temaki()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Temaki com carinho");
}

void Sashimi()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Sashimi com carinho");
}

void Yakisoba()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Yakisoba com carinho");
}

void Guioza()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Guioza com carinho");
}

void Shimeji()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Shimeji com carinho");
}