using AtividadeHeranca.Contas;

namespace AtividadeHeranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("##  Conta Corrente  ##");
            Console.ResetColor();
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.NomeDoCliente = "Rafael";
            contaCorrente.NumeroDaConta = 12345;
            Console.WriteLine($"Cliente: {contaCorrente.NomeDoCliente}, Conta: {contaCorrente.NumeroDaConta}");
            //Chamando o método para exibir o saldo e informar os dados
            contaCorrente.ExibirSaldo();
            //Efetuando um depósito na conta e exibindo o saldo novamente
            contaCorrente.Depositar(1000M);
            contaCorrente.ExibirSaldo();
            //Efetuando um saque na conta 
            contaCorrente.Sacar(100M);
            contaCorrente.ExibirSaldo();

            //Conta Poupança
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("##  Conta Poupança  ##");
            Console.ResetColor();
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            contaPoupanca.Depositar(1000M);
            contaPoupanca.ExibirSaldo();
            contaPoupanca.Sacar(100M);
            contaPoupanca.ExibirSaldo();

            //Conta de investimento
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("##  Conta de Investimentos ##");
            Console.ResetColor();
            ContaDeInvestimento contaDeInvestimento = new ContaDeInvestimento();
            contaDeInvestimento.Depositar(1000M);
            contaDeInvestimento.ExibirSaldo();
            contaDeInvestimento.Sacar(900);
            contaDeInvestimento.ExibirSaldo();

        }
    }
}
