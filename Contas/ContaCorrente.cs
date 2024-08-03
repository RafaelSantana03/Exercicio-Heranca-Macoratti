
namespace AtividadeHeranca.Contas;

public class ContaCorrente
{
    public decimal Saldo { get; protected set; }
    public int NumeroDaConta { get; set; }
    public string? NomeDoCliente { get; set; }


    public ContaCorrente()
    {       
        Saldo = 0;
    }

    public virtual void Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Você fez um deposito de {valor.ToString("C")}");
    }

    // Método para sacar um valor da conta, desde que haja saldo suficiente
    public virtual void Sacar(decimal valor)
    {
        if (valor > 0 && Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Você realizou um saque no valor {valor.ToString("C")}\n");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Saldo insuficiente para saque\n");
            Console.ResetColor();
        }
    }
    public virtual void ExibirSaldo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Saldo atual da Conta Corrente: {Saldo.ToString("C")}\n");
        Console.ResetColor();
    }
}
