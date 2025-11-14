
using Heranca;

namespace Heranca
{
    public class Aviao : Veiculo
    {
        public int QtdAsas;

        public void Voar()
        {
            Console.WriteLine($"Avião levantou voo!");   
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"contém: {QtdAsas} asas");

        }
    }
}