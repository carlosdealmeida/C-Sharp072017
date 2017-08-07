using System;

class Conta
{
    public double saldo;
    public Cliente titular;
    public int numero;
    
    public void Deposita(double valor)
    {
        saldo += valor;
    }	

    public bool Saca(double valor)
    {
        if((titular.EhMaiorDeIdade() || (valor <= 200)) && (saldo >= valor))
        {
            saldo -= valor;
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
