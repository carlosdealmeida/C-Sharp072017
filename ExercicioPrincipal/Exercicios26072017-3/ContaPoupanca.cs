using System;

class ContaPoupanca : Conta, ITributavel
{
    public override void Deposita(double valorOperacao)
    {
        this.Saldo += valorOperacao;
    }

    public override bool Saca(double valorOperacao)
    {
        if (Saldo >= valorOperacao)
        {
            Saldo -= valorOperacao + 0.10;
            return true;
        }
        return false;
    }

    public double CalculaTributo()
    {
        return this.Saldo * 0.02;
    }
}
