using System;

class SaldoInsuficienteException:Exception
{
    public double SaldoAtual { get; private set; }

    public SaldoInsuficienteException(double saldo)
    {
        SaldoAtual = saldo;
    }
}