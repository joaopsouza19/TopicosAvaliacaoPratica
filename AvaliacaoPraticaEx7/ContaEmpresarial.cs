// ./ContaEmpresarial.cs
using System;

public class ContaEmpresarial : ContaBancaria {
    public double SaldoMinimo { get; set; }

    public ContaEmpresarial(string numeroConta, double saldoMinimo) : base(numeroConta){
        SaldoMinimo = saldoMinimo;
    }

    public void VerificarSaldoMinimo(){
        if (Saldo < SaldoMinimo){
            Console.WriteLine("Saldo abaixo do mínimo permitido.");
        } else{
            Console.WriteLine("Saldo dentro do limite.");
        }
    }

    public override void MostrarInformacoes(){
        base.MostrarInformacoes();
        Console.WriteLine("Saldo mínimo permitido: " + SaldoMinimo);
    }
}
