// ./Program.cs
using System;

// Utilizei ajuda do GPT para corrigir alguns erros, "Não utilizei um prompt específico, mas levei em consideração as suas instruções e a lógica da aplicação."

Curso curso1 = new CursoIdioma("Inglês Básico", 45, "Inglês");
Curso curso2 = new CursoAvancado("Inglês Avançado", 95, "Inglês");
Curso curso3 = new CursoConcluido("Espanhol Intermediário", 75, "Espanhol");
Curso curso4 = new CursoAvancado("Francês Avançado", 135, "Francês");

curso1.MostrarDetalhes();
Console.WriteLine();

curso2.MostrarDetalhes();
if (curso2 is CursoAvancado){
        double[] notas = { 8.6, 9.2, 7.1 };
        ((CursoAvancado)curso2).CalcularMediaNotas(notas);
}
Console.WriteLine();

curso3.MostrarDetalhes();
if (curso3 is CursoConcluido){
        ((CursoConcluido)curso3).GerarCertificado("João Pedro Souza Silva");
}
Console.WriteLine();

curso4.MostrarDetalhes(); 
if (curso4 is CursoAvancado){
        double[] notas = { 7.3, 8.7, 9.1 };
        ((CursoAvancado)curso4).CalcularMediaNotas(notas);
}