// ./Program.cs
using System;
        
IMetodoPagamento metodoPagamento;

metodoPagamento = new cartaoCredito();
metodoPagamento.processarPagamento(100);

Console.WriteLine();

metodoPagamento = new cartaoDebito();
metodoPagamento.processarPagamento(50);

Console.WriteLine();

metodoPagamento = new PayPal();
metodoPagamento.processarPagamento(200);

