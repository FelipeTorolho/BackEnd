namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string NomeResponsavel;
        public string TextoRelatorio;

        public Relatorio(string NomeRelatorio, string RelatorioDoDia)
        {
            NomeResponsavel = NomeRelatorio;
            TextoRelatorio = RelatorioDoDia;
        }
        
        public void Imprimir()
        {
            Console.WriteLine($@"
            Responsável: {NomeResponsavel}:
            Relatorio: {TextoRelatorio}
            ");
        }
    }
}