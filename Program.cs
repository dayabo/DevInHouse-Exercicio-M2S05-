namespace AtividadeJaimeM2S5Exer2
{
  internal class Program
  {
    static void Main(string[] args)
    {
           Console.WriteLine();
           VA valeAlimentacao = new VA("Alelo", 400.00,5);
           Console.WriteLine($@"
           Cartão Alimentação { valeAlimentacao.Bandeira};
           Saldo: {valeAlimentacao.Saldo.ToString("c")};
           Taxa de {valeAlimentacao.ValorTaxa}");
        Console.WriteLine("-----------------------------------------");

        Console.WriteLine();
           VR valeRefeicao = new VR("Vb Refeição",100.00,2);
           Console.WriteLine($@"
           Cartão Refeição {valeRefeicao.Bandeira};
           Saldo: {valeRefeicao.Saldo.ToString("c")};
           Taxa de {valeRefeicao.ValorTaxa}");
        Console.WriteLine("-----------------------------------------");

      Console.WriteLine();
      VT valeTranspote = new VT("CT", 200.00, 3);
      Console.WriteLine($@"
           Cartão Vale Transporte {valeTranspote.Bandeira};
           Saldo: {valeTranspote.Saldo.ToString("c")};
           Taxa de {valeTranspote.ValorTaxa}");
      Console.WriteLine("-----------------------------------------");

      Console.WriteLine();
      VA upCastingEx1 = new VA();
      Cartao novoCartao = upCastingEx1;
      Console.WriteLine($@"
            Exemplo upCasting
  Tipo Cartao novoCartao = Tipo VA upCastingEx1;
               {novoCartao == upCastingEx1}");
      Console.WriteLine("-----------------------------------------");

      Console.WriteLine();
      Cartao downCastingEx1 = new VR();
      VR cartaoDown = (VR) downCastingEx1;
      Console.WriteLine($@"
            Exemplo downCasting
Tipo VR cartaoDown = (VR) Tipo Cartao downCastingEx1;
               {cartaoDown  == downCastingEx1}");
      Console.WriteLine("-----------------------------------------");

      Console.WriteLine();
      Console.WriteLine("Exercico 4 Polimorfismo");
      VA va = new VA("Alelo", 1000);
      VR vr = new VR("Vb Refeição", 500);
      VT vt = new VT("CT", 350);
      Console.WriteLine($@"
  Vale Aimentação :{va.Bandeira},Saldo: {va.Saldo}, Taxa:{va.ValorTaxa}
  Vale  Refeição :{vr.Bandeira},Saldo: {vr.Saldo}, Taxa:{vr.ValorTaxa}
  Vale Transporte :{vt.Bandeira},Saldo: {vt.Saldo}, Taxa:{vt.ValorTaxa}");




    }
    }
    }