using Heranca;

namespace Heranca
{
    public class Moto : Veiculo
    {
        public int cilindradas;

        public void SomDaMoto()
        {
            Console.WriteLine($"Grrrrrrrrrrrrrrrrrrrr");

        }

        public void Acelerar()
        {
            Console.WriteLine($"Acelerando o veiculo");

        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"contém: {cilindradas}");

        }
    }
}
