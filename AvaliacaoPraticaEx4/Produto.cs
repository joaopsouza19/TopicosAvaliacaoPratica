// ./Produto.cs
using System;
public class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEmEstoque { get; private set; }
    
    public Produto (string nome, double preco, int quantidadeEmEstoque){
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void adicionarEstoque(int quantidade){
        QuantidadeEmEstoque += quantidade;
    }

    public void removerEstoque(int quantidade){
        if(quantidade <= QuantidadeEmEstoque){
            QuantidadeEmEstoque -= quantidade;
        } else {
            Console.WriteLine("Não é possível remover, a quantidade solicitada excede o que tem disponível em estoque.");
        }
    }

    public double CalcularValorTotalEstoque(){
        return Preco * QuantidadeEmEstoque;
    }
}