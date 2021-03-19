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
            primeiraContaCorrente.titular = new Cliente();
            segundaContaCorrente.titular = new Cliente();         

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Transferir\n");
            opcao = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da 1° conta: ");
            primeiraContaCorrente.titular.nome = Console.ReadLine();

            Console.Write($"Digite o valor do saldo da conta de {primeiraContaCorrente.titular.nome}: ");
            primeiraContaCorrente.saldo = double.Parse(Console.ReadLine());
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
                    segundaContaCorrente.titular.nome = Console.ReadLine();

                    Console.Write($"Digite o valor do saldo da conta de {segundaContaCorrente.titular.nome}: ");
                    segundaContaCorrente.saldo = double.Parse(Console.ReadLine());

                    Console.Write("Quanto deseja transferir? ");
                    double valorTransferencia = double.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Confirme seu CPF sem pontos: ");
                    segundaContaCorrente.titular.cpf = Console.ReadLine();

                    if (segundaContaCorrente.titular.cpf.Length == 11)
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