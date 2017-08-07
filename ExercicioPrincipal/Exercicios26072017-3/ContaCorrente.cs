using System;
class ContaCorrente : Conta, ITributavel
{
    public override bool Saca(double valorOperacao)
    {
        if (valorOperacao < 0)
        {
            throw new ArgumentException("Valor");
        }
        if (Saldo >= valorOperacao)
        {
            Saldo -= valorOperacao + 0.05;
            return true;
        }
        throw new SaldoInsuficienteException(Saldo);
    }

    public override void Deposita(double valorOperacao)
    {
        this.Saldo += valorOperacao;
    }

    public double CalculaTributo()
    {
        return this.Saldo * 0.05;
    }
}
