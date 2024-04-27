// ./ContaPoupanca.cs
using System;

public class ContaPoupanca : ContaBancaria {
    public double TaxaJ { get; set; }

    public ContaPoupanca(string numeroConta, double taxaJ) : base(numeroConta){
        TaxaJ = taxaJ;
    }

    public void CalcularJuros(){
        double juros = Saldo * TaxaJ;
        Saldo += juros;
        Console.WriteLine("Juros de " + juros + " calculados e adicionados. Novo saldo: " + Saldo);
    }

    public override void MostrarInformacoes(){
        base.MostrarInformacoes();
        Console.WriteLine("Taxa de juros: " + TaxaJ + "%");
    }
}
