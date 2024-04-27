// ./IReserva.cs
using System;

public interface IReserva {
    public void ReservarVoo(string numeroVoo, string data, int numeroAssento);

    public void CancelarReserva(string numeroVoo, string data, int numeroAssento);

    public string VerificarStatusReserva(string numeroVoo, string data, int numeroAssento);
}