using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios26072017_2
{
    class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(Cliente Titular, int numero, double saldo = 0.0)
        {
            this.Titular = Titular;
            this.Numero = numero;
            this.Saldo = saldo;
        }
        
    }
}
