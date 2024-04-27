// ./IMetodoPagamento.cs
using System;
public interface IMetodoPagamento {
    public void RealizarPagamento(double valor);
    public string VerificarStatusPagamento();
}