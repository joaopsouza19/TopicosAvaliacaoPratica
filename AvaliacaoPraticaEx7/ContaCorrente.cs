// ./ContaCorrente.cs
using System;

public class ContaCorrente : ContaBancaria {
    public double TaxaM { get; set; }

    public ContaCorrente(string numeroConta, double taxaM) : base(numeroConta) {
        TaxaM = taxaM;
    }

    public void DeduzirTaxaM(){
        Saldo -= TaxaM;
        Console.WriteLine("Taxa de manutenção de " + TaxaM + " deduzida. Novo saldo: " + Saldo);
    }

    public override void MostrarInformacoes(){
        base.MostrarInformacoes();
        Console.WriteLine("Taxa de manutenção: " + TaxaM);
    }
}
