// ./Program.cs
using System;

// EXERCICIO 1
// A herança em orientação a objetos é um conceito que permite que uma classe herde características (atributos e métodos) de outra classe, chamada de classe base ou superclasse. A classe que herda é chamada de classe derivada ou subclasse. Em C#, a herança é implementada utilizando o operador de dois pontos (:).

Gerente gerente = new Gerente("João Pedro", "Souza Silva", 5000, "TI");
        
Console.WriteLine("Nome: " + gerente.Nome + " " + gerente.Sobrenome);
Console.WriteLine("Departamento: " + gerente.Departamento);
Console.WriteLine("Salário: " + gerente.Salario);
gerente.Trabalhar(); 
gerente.GerenciarEquipe();

// Os prompts utilizados para gerar o código do EXERCICIO 1 foram:

// "Explain what inheritance is in object-oriented programming and how it is implemented in C#. Give a practical example of how inheritance can be used in an employee management system."
// "Explain what inheritance is in object-oriented programming and how it is implemented in C#. Give a practical example of how inheritance can be used in an employee management system in C#."
// "In object-oriented programming, what is inheritance and how is it implemented in C#? Provide a practical example of how inheritance can be used in an employee management system."
// "In object-oriented programming, what is inheritance and how is it implemented in C#? Provide a practical example of how inheritance can be used in an employee management system using C#."
   