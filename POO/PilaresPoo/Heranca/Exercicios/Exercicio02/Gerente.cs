
namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public float Bonus;

        public override float CalcularSalario()
        {
            return SalarioBase += Bonus;
        }
    }
}