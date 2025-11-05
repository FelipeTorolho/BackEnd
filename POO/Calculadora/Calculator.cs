namespace Calculadora
{
    public class Calculator
    {
        public double Num1;
        public double Num2;
        public double Resultado;

        // métodos
        public double Somar()
        {
            Resultado = Num1 + Num2;
            return Resultado;
        }
        public double Subtrair()
        {
            Resultado = Num1 - Num2;
            return Resultado;
        }
        public double Multiplicar()
        {
            Resultado = Num1 * Num2;
            return Resultado;
        }
        public double Dividir()
        {
            if (Num2 == 0)
            {
                Console.WriteLine($"Não existe divisão por zero");
                return -1;
            }
            
            Resultado = Num1 / Num2;
            return Resultado;
        }
    }
}