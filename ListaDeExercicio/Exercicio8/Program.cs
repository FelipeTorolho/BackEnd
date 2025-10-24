int opcao;

do
{
    Console.Clear();
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("        Bem Vindo, Usuário");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine();

    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine("   1) Opção 1");
    Console.WriteLine("   2) Opção 2");
    Console.WriteLine("   3) Opção 3");
    Console.WriteLine("   0) Sair");

    Console.Write("Digite sua opção: ");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você escolheu a Opção 1.");
            break;

        case 2:
            Console.WriteLine("Você escolheu a Opção 2.");
            break;

        case 3:
            Console.WriteLine("Você escolheu a Opção 3.");
            break;

        case 0:
            Console.WriteLine("Saindo do programa... Até logo!");
            break;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
    }

} while (opcao != 0);
