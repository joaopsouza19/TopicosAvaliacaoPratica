// ./VooUpgrade.cs
using System;

public class VooUpgrade : IReserva {
    public void ReservarVoo(string numeroVoo, string data, int numeroAssento){
        Console.WriteLine("Reserva de voo com upgrade de classe, para o voo " + numeroVoo +", na data " + data + ", no assento " + numeroAssento + " concluida com sucesso!");
    }

    public void CancelarReserva(string numeroVoo, string data, int numeroAssento){
        Console.WriteLine("O cancelamento da reserva do voo com upgrade de classe, do voo " + numeroVoo + ", da data " + data + ", do assento " + numeroAssento + " foi realizado com sucesso!");
    }

    public string VerificarStatusReserva(string numeroVoo, string data, int numeroAssento){
        return "O status da reserva do voo com upgrade de classe " + numeroVoo + ", da data " + data + ", do assento " + numeroAssento + ": Está confirmada";
    }
}