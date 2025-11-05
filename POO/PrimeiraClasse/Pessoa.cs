namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string nome;
        public int idade = 0;
        public int altura;

        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou {nome} e tenho {idade} anos!");
        }
        public void Dormir()
        {
            Console.WriteLine("zzzzzz...");
        }
        
        public void Envelhecer(int _id = 0)
        {
            if (_id > 0)
            {//adiciona a idade que foi recebida
                idade += _id;
            }
            else
            {//adiciona apenes 1 ano na idade
            
                idade++;
            }
        }
    }
}