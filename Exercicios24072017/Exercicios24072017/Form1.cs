using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios24072017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Curso de C# da Caelum";
            MessageBox.Show(mensagem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadeMarta = 30;
            int media = (idadeJoao + idadeMaria + idadeMarta) / 3;
            MessageBox.Show("A média das idades é de " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            MessageBox.Show("O valor de pi é: " + pi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if(saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo!");
            }
            else if(saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente.");
            }
            else
            {
                MessageBox.Show("Você é um milionário!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int idade = 15;
            bool brasileira = (idade > 16);

            if (brasileira)
            {
                MessageBox.Show("Você está apto a votar");
            }
            else
            {
                MessageBox.Show("Você não pode votar");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 3945.76;
            double imposto;
            if(valorDaNotaFiscal <= 999.0)
            {
                imposto = valorDaNotaFiscal * 0.02;
            }
            else if ((valorDaNotaFiscal >= 1000.0) && (valorDaNotaFiscal <= 2999.00))
            {
                imposto = valorDaNotaFiscal * 0.025;
            }
            else if ((valorDaNotaFiscal >= 3000.0) && (valorDaNotaFiscal <= 6999.0))
            {
                imposto = valorDaNotaFiscal * 0.028;
            }
            else
            {
                imposto = valorDaNotaFiscal * 0.03;
            }
            MessageBox.Show(string.Format("{0:0.00}",imposto).ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int valor = 5;
            string mensagem = "";
            mensagem = valor > 10 ? "Maior que dez" : "Menor que dez";
            MessageBox.Show(mensagem);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i++)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 1; i <= 1000; i++)
            {
                total = total + i;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string total = "";

            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    total = total + ", " + i.ToString();
                }
            }
            MessageBox.Show("Os números são: " + total);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    total = total + i;
                }
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string total = "";

            for (int i = 0; i <= 30; i++)
            {
                if ((i % 3 == 0) && (i % 4 == 0))
                {
                    total = total + ", " + i.ToString();
                }
            }
            MessageBox.Show("Os números são: " + total);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {

            }
        }
    }
}
