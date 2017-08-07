using System;

public abstract class Conta : Object
{
    public int Numero { get; set; }
    public double Saldo { get; protected set; }
    public Cliente Titular { get; set; }

    public abstract bool Saca(double valorOperacao);
    public abstract void Deposita(double valorOperacao);

    public static int numeroDeContas;

    public Conta(Cliente titular)
    {
        Titular = titular;
    }

    public Conta()
    {
    //    Conta.numeroDeContas++;
    //    this.Numero = Conta.numeroDeContas;
    }

    //public static int ProximaConta()
    //{
    //   return Conta.numeroDeContas + 1;
    //}

    public override string ToString()
    {
        return string.Format("N.:{0};Titular:{1};Saldo:{2}", Numero, Titular.Nome, Saldo);
    }

    public override bool Equals(object obj)
    {
        if((obj == null) || (!(obj is Conta)))
        {
            return false;
        }
        Conta outra = (Conta) obj;
        return (this.Numero == outra.Numero);
    }

    public override int GetHashCode()
    {
        return Numero;
    }
}
