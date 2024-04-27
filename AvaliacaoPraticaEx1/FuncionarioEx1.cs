// ./FuncionarioEx1.cs
using System;

public class FuncionarioEx1 {
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public double Salario { get; set; }

    public FuncionarioEx1(string nome, string sobrenome, double salario){
        Nome = nome;
        Sobrenome = sobrenome;
        Salario = salario;
    }

    public virtual void Trabalhar(){
        Console.WriteLine("O funcionário está trabalhando.");
    }
}
