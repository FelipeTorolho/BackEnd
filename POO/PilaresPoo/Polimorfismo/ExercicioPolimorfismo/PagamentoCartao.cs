namespace ExercicioPolimorfismo
{
    
    public class PagamentoCartao : Pagamento
    {
        private float acrescimo = 5.38f;
        public float ValorCompra; 

        // Devolve o valor com o acrescimo calculado
        public override float CalcularTotal()
        {
            float valorAcrescimo = ValorCompra / 100 * acrescimo;//qto paga a mais
            
            return ValorCompra = ValorCompra + valorAcrescimo;
        }

    }
}