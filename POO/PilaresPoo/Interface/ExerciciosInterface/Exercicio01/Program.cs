using Exercicio01;
Console.Clear();

Console.WriteLine($"--Bem vindo ao programa de Geometria--");
Console.WriteLine();

Console.WriteLine($"Vamos calcular a área do retângulo");

Console.WriteLine($"Informe a altura: ");
double Altura = double.Parse(Console.ReadLine());
Console.WriteLine($"Informe a largura: ");
double Largura= double.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo(Largura, Altura);
Console.WriteLine();

Console.WriteLine($"Agora vamos calcular a área do círculo");
Console.WriteLine($"Informe o rao do círculo");
double raio = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = raio;

retangulo.CalcularArea();
circulo.CalcularArea();