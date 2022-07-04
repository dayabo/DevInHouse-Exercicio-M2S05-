namespace AtividadeJaimeM2S5Exer2
{
  public class Cartao
  {
    public string  Bandeira;
    public double  Saldo;
    public double ValorTaxa;

    public Cartao(){}

    public Cartao(string bandeira, double saldo) {
      this.Bandeira = bandeira;
      this.Saldo = saldo;
      this.ValorTaxa = VerificarValorTaxaCartaoPolimorfismo(saldo);
     }
    public Cartao(string bandeira, double saldo, double valorTaxa)
    {
      this.Bandeira = bandeira;
      this.Saldo = saldo;
      this.ValorTaxa = VerificarValorTaxaCartao(saldo, valorTaxa);

    }

    public  double VerificarValorTaxaCartao(double saldo, double taxa)
    {
      var taxas = taxa/100;

      return saldo * taxas;
    }
    public virtual double VerificarValorTaxaCartaoPolimorfismo(double saldo)
    {
      var taxas = ValorTaxa / 100;

      return saldo * taxas;
    }

  }
}