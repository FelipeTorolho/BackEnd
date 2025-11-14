namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 0;
        private double TaxaSaque = 3;

        //Construtores
        public ContaPoupanca(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        //Metodos

        public override void Depositar(double Valor)
        {
            if (Valor <= 0)
            {
                Console.WriteLine($"O valor do depósito deve ser positivo");
                return;
            }

            Saldo += Valor;
        }

        public override void Sacar(double Valor)
        {
            double totalComTaxa = (Valor / 100 * TaxaSaque) + Valor;
            
            if (Valor <= 0 || Saldo < totalComTaxa)
            {
                //debita da conta
                Console.WriteLine($"O valor do saque deve ser positivo e ter dinheiro na conta");
                return;
            }

            Saldo -= totalComTaxa; //efetua o saque
        }
    }
}