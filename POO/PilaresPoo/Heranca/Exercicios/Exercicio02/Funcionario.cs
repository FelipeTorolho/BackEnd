namespace Exercicio
{
   
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(string nome, double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
    }

    // Classe derivada
    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        public Gerente(string nome, double salarioBase, double bonus)
            : base(nome, salarioBase)
        {
            Bonus = bonus;
        }

        // Sobrescreve o método da classe base
        public override double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}
