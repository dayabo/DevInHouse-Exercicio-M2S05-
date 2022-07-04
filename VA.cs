namespace AtividadeJaimeM2S5Exer2
{
  public class VA : Cartao
  {
    public VA(){}
    public VA(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    {
    }
    public VA(string bandeira, double saldo) : base(bandeira, saldo)
    {
    }
    public override double VerificarValorTaxaCartaoPolimorfismo(double saldo)
    {
      return saldo * 0.06;
    }
  }
}