// ./Program.cs
using System;

// EXERCICIO 5
// Para criar o sistema de locadora de filmes, obtive ajuda do GPT com o seguinte prompt:
// "Implement a movie rental system in C#. Create a class 'Movie' with the following attributes: Title, Genre, Duration, Available (indicating whether the movie is available for rental). Implement methods to register the rental of a movie, register the return of a movie, and check if a movie is available for rental. There is no need to implement database routines."

Filme filme = new Filme("Velozes e Furiosos 10", "Ação", 221);

Console.WriteLine($"O filme " + filme.Titulo + " está disponível para locação? " + filme.EstaDisponivel());
filme.AlugarFilme();

Console.WriteLine();

Console.WriteLine($"O filme " + filme.Titulo + " está disponível para locação? " + filme.EstaDisponivel());
filme.AlugarFilme();

Console.WriteLine();

filme.DevolverFilme();
Console.WriteLine($"O filme " + filme.Titulo + " está disponível para locação? " + filme.EstaDisponivel());