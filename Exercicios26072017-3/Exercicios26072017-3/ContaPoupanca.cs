class ContaPoupanca : Conta
{
    public override bool Saca(double valorOperacao)
    {
        return base.Saca(valorOperacao + 0.10);
    }
}
