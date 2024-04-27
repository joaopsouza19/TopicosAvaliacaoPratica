// Arquivo Curso.cs
using System;

public class Curso {
    public string Nome { get; set; }
    public int DuracaoHoras { get; set; }

    public Curso(string nome, int duracaoHoras){
        Nome = nome;
        DuracaoHoras = duracaoHoras;
    }

    public virtual void MostrarDetalhes(){
        Console.WriteLine($"Curso: " + Nome + ", Duração: " + DuracaoHoras + " horas");
    }
}