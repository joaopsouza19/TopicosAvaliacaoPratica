// ./Bicicleta.cs
public class Bicicleta : Veiculo {
    public int NumeroMarchas { get; set; }
    public Bicicleta(string marca, string modelo, int ano, int numeroMarchas) : base(marca, modelo, ano) {
        NumeroMarchas = numeroMarchas;
    }
}