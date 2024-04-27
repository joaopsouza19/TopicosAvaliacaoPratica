// ./Gerente.cs
using System;

public class Gerente : FuncionarioEx1 {
    public string Departamento { get; set; }

    public Gerente(string nome, string sobrenome, double salario, string departamento) : base(nome, sobrenome, salario){
        Departamento = departamento;
    }

    public void GerenciarEquipe(){
        Console.WriteLine("O gerente está gerenciando sua equipe.");
    }

    public override void Trabalhar(){
        Console.WriteLine("O gerente está coordenando o trabalho da equipe.");
    }
}
