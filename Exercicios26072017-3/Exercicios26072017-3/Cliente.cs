class Cliente
{
    private string v;

    public Cliente(string v)
    {
        this.Nome = v;
    }

    public string Nome { get; set; }
    public string Cpf { get; set; }
    public int Idade { get; set; }
    public object documentos { get; internal set; }
}
