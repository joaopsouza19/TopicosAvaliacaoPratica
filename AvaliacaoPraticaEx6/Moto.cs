// ./Moto.cs
public class Moto : Veiculo {
    public int CilindradaMoto { get; set; }
    public Moto(string marca, string modelo, int ano, int cilindradaMoto) : base(marca, modelo, ano) {
        CilindradaMoto = cilindradaMoto;
    }
}