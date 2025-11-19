// See https://aka.ms/new-console-template for more information

// Criar um objeto da classe Carro
using Exemplos;
Console.Clear();

// Carro nissan = new Carro("Vermelho", "Nissan", "kicks", 2026);
// nissan.ExibirInfo();

// Moto bmw = new Moto("Branco", "BMW", "R1250GS", 2025);
// bmw.ExibirInfo();

//criar uma interfaxe chamada IControle com as seguintes regras/métodos:
   //Ligar, Desligar, AumentarVolume, DiminuirVolume

//Criar uma Classe ControleRemoto Que Implemente a Interface IControle
//Também deve ter as propriedades NivelVolume e VolumeMaximo

ControleRemoto controleTV = new ControleRemoto();
controleTV.AumentarVolume();
controleTV.DiminuirVolume();