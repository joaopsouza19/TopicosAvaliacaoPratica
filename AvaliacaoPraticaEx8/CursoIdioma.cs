// Arquivo CursoIdioma.cs
using System;

 public class CursoIdioma : Curso {
    public string Idioma { get; set; }

    public CursoIdioma(string nome, int duracaoHoras, string idioma) : base(nome, duracaoHoras)
    {
        Idioma = idioma;
    }

    public override void MostrarDetalhes()
    {
        base.MostrarDetalhes();
        Console.WriteLine("Idioma: " + Idioma);
    }
}