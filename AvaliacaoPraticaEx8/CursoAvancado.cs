// Arquivo CursoAvancado.cs
using System;

public class CursoAvancado : CursoIdioma {
    
    public CursoAvancado(string nome, int duracaoHoras, string idioma) : base(nome, duracaoHoras, idioma){
    }

    public void CalcularMediaNotas(double[] notas){
    double soma = 0;
    foreach (var nota in notas){
        soma += nota;
    }
    double media = soma / notas.Length;

    Console.WriteLine($"Média de notas do curso avançado: " + media);
    }
}
