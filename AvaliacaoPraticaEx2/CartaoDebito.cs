// ./CartaoDebito.cs
using System;

public class cartaoDebito : IMetodoPagamento {
    public void processarPagamento(double valor){
        Console.WriteLine($"Pagamento de R$" + valor + " processado com cartão de débito.");
    }
}
