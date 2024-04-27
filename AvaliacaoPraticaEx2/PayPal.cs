// ./PayPal.cs
using System;

public class PayPal : IMetodoPagamento {
    public void processarPagamento(double valor){
        Console.WriteLine($"Pagamento de R$ " + valor + " processado com PayPal.");
    }
}
