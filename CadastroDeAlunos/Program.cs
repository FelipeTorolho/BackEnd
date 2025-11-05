string[] nomes = new string[3];
int[] idades = new int[3];
int totalAlunos = 0;

int opcao;
do
{
    Console.Clear();
    Console.WriteLine($"====Aplicativo Sala de Aula");
    Console.WriteLine($"1) Listar Alunos");
    Console.WriteLine($"2) Cadastrar Alunos");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando");
            break;
        case 1:
            ListarAluno();
            break;
        case 2:
            CadastrarAluno();
            break;
        default:
        Console.WriteLine($"Opção inválida");
        break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void ListarAluno()
{
    Console.WriteLine($"=== Listagem de Alunos ===");
   //exibir os nomes dos alunos
   for (int t = 0; t < totalAlunos; t++)
   {
    Console.WriteLine($"Nome: {nomes[t]}, {idades[t]} anos");
   }
   
}

void CadastrarAluno()
{
    Console.WriteLine($"=== Cadastro de Alunos ===");

    //verificar se eu posso cadastrar
    if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido");
        return;
    }
    
    Console.WriteLine($"Digite o nome do aluno");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine($"Digite a idade de {nomes[totalAlunos]}");
    idades[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++;
    Console.WriteLine($"Aluno cadastro com sucesso!");

}               