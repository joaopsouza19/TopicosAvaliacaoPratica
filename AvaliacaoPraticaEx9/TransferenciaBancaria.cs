// ./TransferenciaBancaria.cs
using System;

public class TransferenciaBancaria : IMetodoPagamento {
    public void RealizarPagamento(double valor){
        Console.WriteLine("O pagamento de R$" + valor + " foi realizado via transferência bancária!");
    }
    public string VerificarStatusPagamento(){
        return "Pagamento concluído via Transferência Bancária.";
    }
}