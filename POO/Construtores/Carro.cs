
namespace Construtores
{
    // Classe base
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        // Método virtual: pode ser sobrescrito nas classes filhas
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
        }
    }

    public class CarroEsportivo : Carro
    {
        public int VelocidadeMaxima;

        public CarroEsportivo(string marca, string modelo, int ano, int velocidadeMaxima)
            : base(marca, modelo, ano)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        // Sobrescrita do método
        public override void ExibirDados()
        {
            Console.WriteLine($"[Esportivo] {Marca} {Modelo} ({Ano}) - Velocidade Máxima: {VelocidadeMaxima} km/h");
        }
    }
}