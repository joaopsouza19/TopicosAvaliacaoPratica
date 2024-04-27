// ./Program.cs
using System;

Carro carro = new Carro("Mercedes", "E63", 2024, 4);

Moto moto = new Moto("Ninja", "H2R", 2024, 998);

Bicicleta bicicleta = new Bicicleta("YT Industries", "Core 2", 2023, 21);

Console.WriteLine("Carro");
Console.WriteLine("Marca: " + carro.Marca + ", Modelo: " + carro.Modelo + ", Ano: " + carro.Ano + ", Número de Portas: " + carro.NumeroPortas);

Console.WriteLine();

Console.WriteLine("Moto");
Console.WriteLine("Marca: " + moto.Marca + ", Modelo: " + moto.Modelo + ", Ano: " + moto.Ano + ", Cilindrada: " + moto.CilindradaMoto);

Console.WriteLine();

Console.WriteLine("Bicicleta");
Console.WriteLine("Marca: " + bicicleta.Marca + ", Modelo: " + bicicleta.Modelo + ", Ano: " + bicicleta.Ano + ", Número de Marchas: " + bicicleta.NumeroMarchas);