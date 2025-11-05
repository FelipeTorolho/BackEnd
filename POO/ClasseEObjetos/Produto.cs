namespace ClasseEObjetos
{
    public class Produto
    {
        public string nome = "";

        public double preco;

        public void AplicarDesconto(double percentual)
        {
            if (percentual > 0 && percentual <= 100)
            {
                double valorDesconto = preco * (percentual / 100);
                preco -= valorDesconto;
                Console.WriteLine($"Desconto de {percentual} foi aplicado, o preco atual agora eh {preco:C}");
            }
            else
            {
                Console.WriteLine($"Percentual de desconto invalido.");
            }
        }      
    }
}
