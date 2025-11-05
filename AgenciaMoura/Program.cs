string[] nomes = new string[10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarCliente();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
    Console.WriteLine($"=== Cadastro de Clientes ===");

    //verificar se eu posso cadastrar
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido");
        return;
    }

    Console.WriteLine($"Nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine($"cliente cadastrado com sucesso!");
}
void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    //cliente encontrado
    Console.Write($"Valor para depósito: ");
    float Valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += Valor;
    Console.WriteLine($"Depósito de R$ {Valor:F2} realizado");
    
}
void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Digite o valor do saque: ");
    float valor = float.Parse(Console.ReadLine());
    if (valor > saldos[idCliente] && valor > 0)
    {
        Console.WriteLine($"Saldo insuficiente para saque!");
        return;
    }
    saldos[idCliente] -= valor;
    Console.WriteLine($"Saque de R$ {valor:F2} Realizado!");
}
void Transferir()
{
    Console.WriteLine($"== Transferência ==");
    Console.Write($"Conta de Origem: ");
    int idOrigem = BuscarCliente();

    if (idOrigem == -1) return;

    Console.Write($"Conta de Destino: ");
    int idDestino = BuscarCliente();

    if (idDestino == -1) return;

    Console.Write($"Valor para transferir: ");
    float valor = float.Parse(Console.ReadLine());

    if (saldos[idOrigem] >= valor && valor > 0)
    {
        saldos[idOrigem] -= valor;
        saldos[idDestino] += valor;
        Console.WriteLine($"Transferência concluída");
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente");   
    }

}
void ListarCliente()
{
    Console.WriteLine($"=== Listagem de Clientes ===");

    for (int t = 0; t < totalClientes; t++)
    {
        Console.WriteLine($"Nome:{t} - {nomes[t]}, R$ {saldos[t]}");
    }
}
int BuscarCliente()
{
    //listar cliente
    ListarCliente();
    //pedir pro usuário escolher o cliente
    Console.WriteLine($"Digite o número do clinete: ");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado!");
        return -1;
    }
    
    //retornar/devolver o id do cliente
    return idCliente;
}