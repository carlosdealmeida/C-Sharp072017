class TotalizadorDeTributos
{
    public double Total { get; private set; }

    public void Acumula(ITributavel t)
    {
        Total += t.CalculaTributo();
    }
}