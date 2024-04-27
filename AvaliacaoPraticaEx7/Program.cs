// ./Program.cs
using System;

// Para criar as classes e o programa usei ajuda do GPT, de acordo com ele usou o conhecimento base em C# combinado com o contexto fornecido. "Não utilizei um prompt específico para essa tarefa."

ContaCorrente contaCorrente = new ContaCorrente("123123", 10.0);
Console.WriteLine("Conta Corrente");
contaCorrente.Depositar(1000);
contaCorrente.DeduzirTaxaM();
contaCorrente.Sacar(500);
contaCorrente.MostrarInformacoes();

Console.WriteLine();

ContaPoupanca contaPoupanca = new ContaPoupanca("371237", 0.05);
Console.WriteLine("Conta Poupanca");
contaPoupanca.Depositar(2000);
contaPoupanca.CalcularJuros();
contaPoupanca.MostrarInformacoes();

Console.WriteLine();

ContaEmpresarial contaEmpresarial = new ContaEmpresarial("123213", 1000);
Console.WriteLine("Conta Empresarial");
contaEmpresarial.Depositar(1500);
contaEmpresarial.Sacar(200);
contaEmpresarial.VerificarSaldoMinimo();
contaEmpresarial.MostrarInformacoes();

