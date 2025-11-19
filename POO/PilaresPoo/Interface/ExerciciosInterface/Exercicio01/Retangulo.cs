namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public double Largura;
        public double Altura;

        public Retangulo(double l, double a)
        {
            Largura = l;
            Altura = a;
        }

        public void CalcularArea()
        {
            double area = Largura * Altura;
            Console.WriteLine($"Area do retângulo: {area}");
            
        }
    }
}
