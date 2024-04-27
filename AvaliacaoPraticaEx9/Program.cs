// ./Program.cs
using System;

IMetodoPagamento pagamentoViaCartao = new CartaoCredito();
pagamentoViaCartao.RealizarPagamento(450.99);
Console.WriteLine(pagamentoViaCartao.VerificarStatusPagamento());

Console.WriteLine();

IMetodoPagamento pagamentoViaBoleto = new Boleto();
pagamentoViaBoleto.RealizarPagamento(500.99);
Console.WriteLine(pagamentoViaBoleto.VerificarStatusPagamento());

Console.WriteLine();

IMetodoPagamento pagamentoViaTransferenciaB = new TransferenciaBancaria();
pagamentoViaTransferenciaB.RealizarPagamento(1199.99);
Console.WriteLine(pagamentoViaTransferenciaB.VerificarStatusPagamento());