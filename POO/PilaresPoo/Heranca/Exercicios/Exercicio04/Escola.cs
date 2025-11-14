namespace Heranca
{
    public class Pessoa
  {
        public string Nome;
        public int Idade;
        public string Curso;

       public void ExibirInfo()
        {
          Console.WriteLine($"Nome: {Nome}");
          Console.WriteLine($"Idade: {Idade}");
          Console.WriteLine($"Curso: {Curso}");
          
        }
    }
}

namespace Heranca
{
    public class Professor : Pessoa
    {
        public string Disciplina;


           public void ExibirInfo()
        {
          Console.WriteLine($"Nome: {Nome}");
          Console.WriteLine($"Idade: {Idade}");
          Console.WriteLine($"Disciplina: {Disciplina}");
          
        }
    }
}
