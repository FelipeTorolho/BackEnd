using Encapsulamento;

// ContaBancaria contaFelipe = new ContaBancaria();
// ContaBancaria contaArthur = new ContaBancaria(1500);

// contaFelipe.Depositar(-100);
// contaFelipe.Depositar(20);
// contaFelipe.Sacar(-200);
// contaArthur.Sacar(300);

// Console.WriteLine();

// Console.WriteLine($"Saldo atual: R${contaFelipe.GetSaldo()}");
// Console.WriteLine($"Saldo atual: R${contaArthur.GetSaldo()}");


Carro carro = new Carro();

carro.DefinirMarca("Toyota");
carro.DefinirModelo("Corolla");

carro.Acelerar(30);
carro.Acelerar(20);
carro.Frear(10);
carro.Frear(50); 


Console.WriteLine($"Marca: {carro.ObterMarca()}");
Console.WriteLine($"Modelo:  {carro.ObterModelo()}");
Console.WriteLine($"Velocidade Atual:  {carro.ObterVelocidade()}km/h");
