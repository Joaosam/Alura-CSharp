using System;

public class ContaCorrente
{
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo;

    public void Depositar(double valorDeposito)
    {
        this.saldo += valorDeposito;
        Console.WriteLine($"O saldo atual de {titular.nome} é de R$ {this.saldo}!");
    }

    public bool Sacar(double valorSaque)
    {
        if (this.saldo < valorSaque) 
        {
            Console.WriteLine();
            Console.WriteLine("ERROR!!");
            Console.WriteLine($"O valor do saque é maior do que o seu saldo atual!");
            return false;
        }

        this.saldo -= valorSaque;
        Console.WriteLine($"O saldo atual de {titular.nome} é de R$ {this.saldo}!");
        return true;
    }

    public bool Transferir(double valorTransferencia, ContaCorrente contaDestino)
    {
        if (this.saldo < valorTransferencia)
        {
            Console.WriteLine();
            Console.WriteLine("ERROR!!");
            Console.WriteLine($"O valor da transferência é maior do que o saldo atual de {titular.nome}!");
            return false;
        }

        this.saldo -= valorTransferencia;
        contaDestino.Depositar(valorTransferencia);        
        Console.WriteLine($"O saldo atual de {titular.nome} é de R$ {this.saldo}!");
        return true;
    }
    
}