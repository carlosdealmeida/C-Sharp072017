using System;

class Conta
{
    public int Numero { get; set; }
    public double Saldo { get; private set; }
    public Cliente Titular { get; set; }

    public void Deposita(double valorOperacao)
    {
        this.Saldo += valorOperacao;
    }

    public virtual bool Saca(double valorOperacao)
    {
        if (Saldo >= valorOperacao)
        {
            Saldo -= valorOperacao;
            return true;
        }
        return false;
    }

}
