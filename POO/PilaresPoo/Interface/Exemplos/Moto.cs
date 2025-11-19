namespace Exemplos
{
    public class Moto : IMotor
    {
        // Propiedades
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        // Contrutores
        public Moto(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }

        //Métodos
        
        public void ExibirInfo()
        {
            Console.WriteLine($@"
Informações do Veículo:
    Marca: {Marca}
    Modelo: {Modelo}
    Ano: {Ano}
    Cor: {Cor}
            ");
        }
        
        public void Acelerar()
        {
            Console.WriteLine($"Moto acelerando... Vrum Vrum");
        }

        public void Freiar()
        {
            Console.WriteLine($"Moto Freiando... irrrrrrrrrrrrh");
        }
    }
}