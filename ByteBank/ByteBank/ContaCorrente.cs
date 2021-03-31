using System;

public class ContaCorrente
{
    public Cliente Titular { get; set; }
    public int Agencia { get; set; }
    public int Numero { get; set; }
    private double _saldo { get; set; }

    public double Saldo
    {
        get
        {
            return _saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            }

            _saldo = value;
        }
    }

    public void Depositar(double valorDeposito)
    {
        _saldo += valorDeposito;
        Console.WriteLine($"O saldo atual de {Titular.Nome} é de R$ {_saldo}!");
    }

    public bool Sacar(double valorSaque)
    {
        if (_saldo < valorSaque) 
        {
            Console.WriteLine();
            Console.WriteLine("ERROR!!");
            Console.WriteLine($"O valor do saque é maior do que o seu saldo atual!");
            return false;
        }

        _saldo -= valorSaque;
        Console.WriteLine($"O saldo atual de {Titular.Nome} é de R$ {_saldo}!");
        return true;
    }

    public bool Transferir(double valorTransferencia, ContaCorrente contaDestino)
    {
        if (_saldo < valorTransferencia)
        {
            Console.WriteLine();
            Console.WriteLine("ERROR!!");
            Console.WriteLine($"O valor da transferência é maior do que o saldo atual de {Titular.Nome}!");
            return false;
        }

        _saldo -= valorTransferencia;
        contaDestino.Depositar(valorTransferencia);        
        Console.WriteLine($"O saldo atual de {Titular.Nome} é de R$ {_saldo}!");
        return true;
    }
    
}