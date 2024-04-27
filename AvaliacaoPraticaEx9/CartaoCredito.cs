// ./CartaoCredito.cs
using System;

public class CartaoCredito : IMetodoPagamento {
    public void RealizarPagamento(double valor){
        Console.WriteLine("O pagamento de R$" + valor + " foi realizado via cartão de crédito!");
    }
    public string VerificarStatusPagamento(){
        return "Pagamento aprovado via Cartão de Crédito.";
    }
}