namespace Exercicio01
{
    public class Circulo : IForma
    {
        public double Raio;
        private double PI = 3.14;

        public void CalcularArea()
        {
            double area = PI * Raio * Raio;
            Console.WriteLine($"A área do circulo é: {area}");
        }
    }
}