namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {
        public string Titular;
        public float Saldo;

        public void Depositar(float _valorSaque)
        {
            if (_valorSaque <= 0)
            {
                Console.WriteLine($"O valor do saldo deve ser maior que R$ 0");
                return;
            }

            Saldo += _valorSaque;

            Console.WriteLine($"Depósito realizado. Novo Saldo: {Saldo:F2}");

        }
        public void Sacar(float _valorSaque)
        {
            if (_valorSaque <= 0)
            {
                Console.WriteLine($"Saldo Atual: {Saldo:F2}");
                Console.WriteLine($"Não e possível sacar este valor solicitado, por favor insira um valor válido ");
                return;
            }

            Saldo -= _valorSaque;

            Console.WriteLine($"Saque realizado. Novo Saldo: {Saldo:F2}");
            
        }
    }
}