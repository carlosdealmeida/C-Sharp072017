using System;
class Calculadora
{

    public int Soma (int n1, int n2, int n3 = 0, int n4 = 0)
    {
        return n1 + n2 + n3 + n4;
    }
    public int Multiplicacao(int n1, int n2, int n3 = 1, int n4 = 1)
    {
        return n1 * n2 * n3 * n4;
    }
    public double Potencia(double n1, double n2 = 2)
    {
        return Math.Pow(n1,n2);
    }
}
