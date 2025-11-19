using Exercicio02;

// criar uma lista para faturas
List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"Menu de Opções
    1) Cadastrar Fatura
    2) Cadastrar Relatorio
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatorios
    6) Listar Contratos
    0) Sair
    Escolha a opção: ");
    opcao = int.Parse(Console.ReadLine());

    //criar um swith case para as opções do menu
    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatório em desenvolvimento");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            Console.WriteLine($"Listar Relatorios em desenvolvimento");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }


    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();


} while (true);



//Funções Auxiliares
void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do Cliente Devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Qual e o valor");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Dias de atraso da fatura?");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    documentos.Add(fat);

    Console.WriteLine($"Fatura Cadastrada");
    
}

void CadastrarContratos()
{

}

void CadastrarRelatorios()
{

}


void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarContratos()
{

}

void ListarRelatorios()
{

}




// Cria um objeto de casa classe e adiciona nas listas
// Fatura fatFelipe = new Fatura();
// documentos.Add(fatFelipe);
// Fatura fatAle = new Fatura();
// documentos.Add(fatAle);

// Relatorio relFelipe = new Relatorio();
// documentos.Add(relFelipe);
// Relatorio relAle = new Relatorio();
// documentos.Add(relAle);

// Contrato contFelipe = new Contrato();
// documentos.Add(contFelipe);
// Contrato contAle = new Contrato();
// documentos.Add(contAle);


// Console.WriteLine($"Faturas: ");
// foreach (var fatura in documentos)
// {
//     if (fatura is Fatura)
//     {
//         fatura.Imprimir();
//     }
// }

// Console.WriteLine($"Contraros: ");
// foreach (var contrato in documentos)
// {
//     if (contrato is Contrato)
//     {
//         contrato.Imprimir();
//     }
// }

// Console.WriteLine($"Relatorios: ");
// foreach (var relatorio in documentos)
// {
//     if (relatorio is Relatorio)
//     {
//         relatorio.Imprimir();
//     }
// }
