namespace Heranca
{
    // Classe base
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }

    // Classe derivada (herda de Conta)
    public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            Saldo += Saldo * 0.02; // aumento de 2%
        }
    }
}