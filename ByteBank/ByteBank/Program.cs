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
            primeiraContaCorrente.Titular = new Cliente();
            segundaContaCorrente.Titular = new Cliente();         

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Transferir\n");
            opcao = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da 1° conta: ");
            primeiraContaCorrente.Titular.Nome = Console.ReadLine();

            Console.Write($"Digite o valor do saldo da conta de {primeiraContaCorrente.Titular.Nome}: ");
            primeiraContaCorrente.Saldo = double.Parse(Console.ReadLine());
            Console.WriteLine();

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
                    segundaContaCorrente.Titular.Nome = Console.ReadLine();

                    Console.Write($"Digite o valor do saldo da conta de {segundaContaCorrente.Titular.Nome}: ");
                    segundaContaCorrente.Saldo = double.Parse(Console.ReadLine());

                    Console.Write("Quanto deseja transferir? ");
                    double valorTransferencia = double.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Confirme seu CPF sem pontos: ");
                    segundaContaCorrente.Titular.CPF = Console.ReadLine();

                    if (segundaContaCorrente.Titular.CPF.Length == 11 || segundaContaCorrente.Titular.CPF.Length == 14)
                        primeiraContaCorrente.Transferir(valorTransferencia,segundaContaCorrente);

                    else 
                    { 
                        Console.WriteLine("CPF inválido. Impossível realizar a transferência!");
                    }
                    break;
                    
            }   
            Console.WriteLine("\nJoaosan \u00a9");
            Console.ReadLine();
        }
    }
}