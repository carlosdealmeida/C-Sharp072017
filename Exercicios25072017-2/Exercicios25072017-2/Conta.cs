using System;

class Conta
{
    public double Saldo { get; private set;}
    public Cliente titular;
    public int Numero { get; set; }

    public void Deposita(double valor)
    {
        Saldo += valor;
    }

    public bool Saca(double valor)
    {
        if (Saldo >= valor)
        {
            if ((valor > 200) && (titular.EhMaiorDeIdade()))
            {
                Saldo -= valor;
                return true;
            }
            else if ((valor >= 200) && (!titular.EhMaiorDeIdade()))
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }

        }
        return false;
    }

    public void Transfere(Conta destino, double valor)
    {
        if (this.Saca(valor))
        {
            destino.Deposita(valor);
        }
    }
}
