class ContaInvestimento : Conta, ITributavel
{
    public double CalculaTributo()
    {
        return this.Saldo * 0.03;
    }

    public override bool Saca(double valorOperacao)
    {
        if (Saldo >= valorOperacao)
        {
            Saldo -= valorOperacao;
            return true;
        }
        return false;
    }

    public override void Deposita(double valorOperacao)
    {
        this.Saldo += valorOperacao;
    }

}
