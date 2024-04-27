// ./VooGrupoG.cs
using System;

public class VooGrupoG : IReserva {
    public void ReservarVoo(string numeroVoo, string data, int numeroAssento){
        Console.WriteLine("Reserva de voo para grupo grande, para o voo " + numeroVoo + ", na data " + data + ", no assento " + numeroAssento + " concluida com sucesso!");
    }

    public void CancelarReserva(string numeroVoo, string data, int numeroAssento){
        Console.WriteLine("O cancelamento da reserva do voo para grupo grande, do voo " + numeroVoo + ", da data " + data + ", do assento " + numeroAssento + " foi realizado com sucesso!");
    }

    public string VerificarStatusReserva(string numeroVoo, string data, int numeroAssento){
        return "O status da reserva do voo para grupo grande " + numeroVoo + ", da data " + data + ", do assento " + numeroAssento + ": Está confirmada";
    }
}
