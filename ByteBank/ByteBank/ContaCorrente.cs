using System;

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

    public void Depositar(double valorDeposito)
    {
        this.saldo += valorDeposito;
        Console.WriteLine($"O saldo atual de {titular} é de R$ {this.saldo}");
    }

    public bool Sacar(double valorSaque)
    {
        if (this.saldo < valorSaque) 
        {
            return false;
        }

        this.saldo -= valorSaque;
        Console.WriteLine($"O saldo atual de {titular} é de R$ {this.saldo}");
        return true;
    }

    public bool Transferir(double valorTransferencia, ContaCorrente contaDestino)
    {
        if (this.saldo < valorTransferencia)
        {
            return false;
        }

        this.saldo -= valorTransferencia;
        contaDestino.Depositar(valorTransferencia);        
        Console.WriteLine($"O saldo atual de {contaDestino.titular} é de R$ {this.saldo}");
        return true;
    }
    
}

