
namespace AtividadeHeranca.Contas;

public class ContaPoupanca : ContaCorrente
{
    public decimal TaxaDeJuros = 0.005M;

    // Método de depósito que aplica juros de 0,5% ao saldo após o depósito
    public override void Depositar(decimal valor)
    {
        base.Depositar(valor);       
        AplicarJuros();
    }
    //Método que calcula taxa de juros e aplica ao saldo
    private void AplicarJuros()
    {
         Saldo += Saldo * TaxaDeJuros;
    }

    // Método para exibir o saldo da conta poupança
    public override void ExibirSaldo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Saldo da Conta Poupança: {Saldo.ToString("C")}\n");
        Console.ResetColor();
    }
}
