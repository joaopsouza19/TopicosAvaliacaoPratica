// ./CartaoCredito.cs
using System;

public class cartaoCredito : IMetodoPagamento {
    public void processarPagamento(double valor){
        Console.WriteLine($"Pagamento de R$" + valor + " processado com cartão de crédito.");
    }
}
