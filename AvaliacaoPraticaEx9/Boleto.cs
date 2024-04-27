// ./Boleto.cs
using System;

public class Boleto : IMetodoPagamento {
    public void RealizarPagamento(double valor){
        Console.WriteLine("O pagamento de R$" + valor + " foi realizado via boleto!");
    }

    public string VerificarStatusPagamento(){
        return "Pagamento pendente via Boleto.";
    }
}
