// ./Carro.cs
public class Carro : Veiculo {
    public int NumeroPortas { get; set; }
    public Carro(string marca, string modelo, int ano, int numeroPortas) : base(marca, modelo, ano) {
        NumeroPortas = numeroPortas;
    }
}
