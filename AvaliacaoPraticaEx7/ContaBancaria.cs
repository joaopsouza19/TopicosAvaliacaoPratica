// ./ContaBancaria.cs
using System;

public class ContaBancaria {
    public string NumeroConta { get; set; }
    public double Saldo { get; protected set; }

    public ContaBancaria(string numeroConta){
        NumeroConta = numeroConta;
        Saldo = 0;
    }

    public virtual void Depositar(double valor){
        Saldo += valor;
        Console.WriteLine("Depósito de " + valor + " realizado com sucesso. Novo saldo: " + Saldo);
    }

    public virtual void Sacar(double valor){
        if (valor > Saldo){
            Console.WriteLine("Saldo insuficiente para saque.");
        } else {
            Saldo -= valor;
            Console.WriteLine("Saque de " + valor + " realizado com sucesso. Novo saldo: " + Saldo);
        }
    }

    public virtual void MostrarInformacoes(){
        Console.WriteLine($"Conta: " + NumeroConta + ", Saldo: " + Saldo);
    }
}
