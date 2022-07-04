namespace AtividadeJaimeM2S5Exer2
{
  public class VR : Cartao
  {
    public VR(){}

    public VR(string bandeira, double saldo) : base(bandeira, saldo)
    {
    }
    public VR(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    {

    }
    public override double VerificarValorTaxaCartaoPolimorfismo(double saldo)
    {
      return saldo * 0.01;
    }
  }
}