// Arquivo CursoConcluido.cs
using System;

 public class CursoConcluido : CursoIdioma {
    public CursoConcluido(string nome, int duracaoHoras, string idioma) : base(nome, duracaoHoras, idioma){
    }

    public void GerarCertificado(string aluno){
        Console.WriteLine("Certificado de conclusão do curso de " + Nome + " para " + aluno);
    }
}