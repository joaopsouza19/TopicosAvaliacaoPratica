// ./Filme.cs
using System;
public class Filme {
    public string Titulo { get; private set; }
    public string Genero { get; private set; }
    public int Duracao { get; private set; }
    public bool Disponivel { get; private set; }

    public Filme(string titulo, string genero, int duracao){
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = true;
    }

    public void AlugarFilme(){
        if (Disponivel){
            Disponivel = false;
            Console.WriteLine("O filme " + Titulo + " foi alugado com sucesso.");
        } else {
            Console.WriteLine($"O filme " + Titulo + " não está disponível para locação.");
        }
    }

    public void DevolverFilme(){
        if (!Disponivel){
            Disponivel = true;
            Console.WriteLine($"O filme " + Titulo + " foi devolvido com sucesso.");
        } else{
            Console.WriteLine($"O filme " + Titulo + " já está disponível para locação.");
        }
    }

    public bool EstaDisponivel(){
        return Disponivel;
    }
}
