using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios26072017_3
{
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c = new ContaPoupanca();
            c.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            c.Titular = cliente;
            c.Titular.Cpf = "11122233344";
           

            textoTitular.Text = c.Titular.Nome.ToString();
            textoNumero.Text = c.Numero.ToString();
            textoSaldo.Text = c.Saldo.ToString();
        }
        

        private void botaoSaque_Click(object sender, EventArgs e)
        {
 
        }

        private void botaoSaque_Click_1(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Saca(valorOperacao);
            textoSaldo.Text = this.c.Saldo.ToString();
            MessageBox.Show("Saque realizado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c.Deposita(valorOperacao);
            textoSaldo.Text = this.c.Saldo.ToString();
            MessageBox.Show("Depósito realizado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
