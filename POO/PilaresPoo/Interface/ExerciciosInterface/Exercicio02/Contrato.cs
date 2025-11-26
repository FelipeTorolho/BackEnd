namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausulas;
        
        public Contrato(string NomeDoCliente, string ClausulasDoContrato)
        {
            Nome = NomeDoCliente;
            TextoClausulas = ClausulasDoContrato;
        }
        public void Imprimir()
        {
            Console.WriteLine($@"
            Contratante: {Nome}
            Cláusulas: {TextoClausulas}
            ");
        }

    }
}