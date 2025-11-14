namespace Construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa()
        {
            Console.WriteLine($"Objeto Criado");
        }

        public Pessoa(String n, int i, string xpto)
        {
            Nome = n;
            Idade = i;
            Console.WriteLine($"Seu texto é: {xpto}");

        }

        public Pessoa(String n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public Pessoa(String n)
        {
            Nome = n;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");

        }
    }
}