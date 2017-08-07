using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios25072017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaVictor = new Conta();
            contaVictor.titular.nome = "victor";
            contaVictor.numero = 1;
            contaVictor.saldo = 100.0;

            MessageBox.Show(contaVictor.titular.nome);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta contaVictor = new Conta();
            contaVictor.titular.nome = "victor";
            contaVictor.numero = 1;
            contaVictor.Deposita(100.0);
            MessageBox.Show("Saldo: " + contaVictor.saldo);
            contaVictor.Saca(50.0);
            MessageBox.Show("Saldo: " + contaVictor.saldo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular.nome = "Mauricio";
            mauricio.saldo = 100.0;

            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            mauricio2.titular.nome = "Mauricio";
            mauricio2.saldo = 100.0;

            if (mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular = new Cliente();
            mauricio.titular.nome = "Mauricio";
            mauricio.saldo = 300.0;
            mauricio.titular.idade = 19;

            var SaqueOk = mauricio.Saca(201.0) ? "Saque realizado" : "Saque não realizado";

            MessageBox.Show(SaqueOk.ToString());
            
        }
    }
}
