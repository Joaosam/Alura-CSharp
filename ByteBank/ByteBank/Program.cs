using System;

namespace ByteBank
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcao;

            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            ContaCorrente segundaContaCorrente = new ContaCorrente();

            Console.Write("Digite o nome do titular da 1° conta: ");
            primeiraContaCorrente.titular = Console.ReadLine();
            Console.Write($"Digite o valor do saldo da conta de {primeiraContaCorrente.titular}: ");
            primeiraContaCorrente.saldo = double.Parse(Console.ReadLine());
            Console.WriteLine();

            
            

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Transferir\n");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Quanto deseja depositar? ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    primeiraContaCorrente.Depositar(valorDeposito);
                    break;
                case 2:
                    Console.Write("Quanto deseja sacar? ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    primeiraContaCorrente.Sacar(valorSaque);
                    break;
                case 3:
                    Console.Write("Digite o nome do titular da 2° conta: ");
                    segundaContaCorrente.titular = Console.ReadLine();
                    Console.Write($"Digite o valor do saldo da conta de {segundaContaCorrente.titular}: ");
                    segundaContaCorrente.saldo = double.Parse(Console.ReadLine());
                    Console.Write("Quanto deseja transferir? ");
                    double valorTransferencia = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    primeiraContaCorrente.Transferir(valorTransferencia,segundaContaCorrente);
                    break;
                    
            }   
            Console.WriteLine("\nJoaosan \u00a9");
            Console.ReadLine();
        }
    }
}
