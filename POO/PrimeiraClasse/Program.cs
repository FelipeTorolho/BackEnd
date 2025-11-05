using PrimeiraClasse;

 Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");
// Carro mclaren = new Carro();
// mclaren.marca = "Mclaren";
// mclaren.cor = "Laranja";
// mclaren.modelo = "750s";
// mclaren.potencia = 800;

// Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// mclaren.Ligar();
// Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// mclaren.Acelerar();

//Pessoa felipe = new Pessoa();
//felipe.nome = "Felipe Torolho";
//felipe.idade = 16;
//felipe.altura = 185;

//felipe.Falar();
//felipe.Dormir();

// Garrafa Tupperware = new Garrafa();
// Tupperware.Cor = "Vermelho";
// Tupperware.Capacidade = 500;
// Tupperware.Tamanho = 27;
// Tupperware.Formato = "Arredondada";
// Tupperware.Abrir();
// Tupperware.Beber();

// Garrafa Stanley = new Garrafa();
// Stanley.Cor = "Preta";
// Stanley.Capacidade = 500;
// Stanley.Formato = "Cilíndrico";
// Stanley.Tamanho = 20;
// Console.Write($"Abrindo a garrafa Stanley: ");
// Stanley.Abrir();

// Console.Write($"Bebendo água da garrafa: ");
// Stanley.Beber();

Console.Clear();
Pessoa felipe = new Pessoa();
felipe.nome = "Felipe Torolho";
felipe.Envelhecer();
felipe.altura = 185;

Console.WriteLine($"{felipe.nome} tem {felipe.idade} ano(s)");
felipe.Envelhecer(10);
Console.WriteLine($"{felipe.nome} tem {felipe.idade} ano(s)");

