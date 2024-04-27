// Arquivo: Program.cs
using System;

Calculadora calculadora = new Calculadora();
int resultadoInt = calculadora.Somar(5, 3);
double resultadoDouble = calculadora.Somar(2.5, 3.7);

Console.WriteLine("Resultado da soma (int): " + resultadoInt);
Console.WriteLine("Resultado da soma (double): " + resultadoDouble);

Console.WriteLine();

Animal animal = new Animal();
animal.emitirSom();

Cachorro cachorro = new Cachorro();
cachorro.emitirSom();

