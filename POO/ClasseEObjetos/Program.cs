using ClasseEObjetos;

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

// Console.Clear();
// Console.WriteLine($"== Agencia Bancária ==");
// Console.WriteLine();

// AgenciaBancaria contaDoFelipe = new AgenciaBancaria();

// contaDoFelipe.Titular = "Felipe Torolho";
// contaDoFelipe.Saldo = 1000.98f;

// contaDoFelipe.Depositar(500);

// contaDoFelipe.Sacar(1500);

Produto panela = new Produto();
panela.nome = "Panela de Pressao Tramontina";
panela.preco = 200;

Console.WriteLine($"{panela.nome} custa {panela.preco}");

panela.AplicarDesconto(20);