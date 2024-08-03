using System.ComponentModel.Design;

namespace AtividadeHeranca.Contas;

public class ContaDeInvestimento : ContaCorrente
{
    public decimal TaxaDeRemuneração = 0.009M;

    // Método de depósito que aplica uma taxa de 0,9% ao saldo após o depósito
    public override void Depositar(decimal valor)
    {
        Console.WriteLine("Efetuando depósito para Investimento...");
        base.Depositar(valor);
        AplicarTaxa();
    }
    // Método que calcula e aplica a taxa de remuneração ao saldo
    private void AplicarTaxa()
    {
        Saldo += Saldo * TaxaDeRemuneração;
    }
    // Método de saque que aplica uma taxa de 0,1% e impede saldo negativo
    public override void Sacar(decimal valor)
    {
        if (Saldo >= valor + (Saldo * 0.001M))
        {
            base.Sacar(valor);
            Saldo -= Saldo * 0.001M;
            Console.WriteLine("Taxa de 0,1% foi aplicada no valor do saque!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Saldo insuficiente para saque\n");
            Console.ResetColor();
        }

    }

    //Exibir saldo da Conta de investimento
    public override void ExibirSaldo()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Saldo da Conta de investimento{Saldo.ToString("C")}\n");
        Console.ResetColor();
    }

}
