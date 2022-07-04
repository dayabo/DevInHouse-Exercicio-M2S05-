namespace AtividadeJaimeM2S5Exer2
{
  public class VT : Cartao
  {
    public VT(string bandeira, double saldo) : base(bandeira, saldo)
    {
    }
    public VT(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    {
    }
    public override double VerificarValorTaxaCartaoPolimorfismo(double saldo)
    {
      return saldo * 0.02;
    }
  }
}