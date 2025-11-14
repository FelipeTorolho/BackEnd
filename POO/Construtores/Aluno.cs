namespace Construtores
{
    public class Aluno
    {
        public string Nome;
        public int Nota;

        public Aluno()
        {
            Console.WriteLine($"Lista de alunos: ");
        }

        public Aluno(string n, int i)
        {
            Nome = n;
            Nota = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome {Nome} | Nota {Nota}");   
        }
    }
}