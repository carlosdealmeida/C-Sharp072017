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
        private List<Conta> contas;
        public Form1()
        {
            InitializeComponent();
        }

        public int ProximaConta()
        {
            return contas.Count + 1;
        }

        public void AdicionaConta(Conta c)
        {
            contas.Add(c);
            comboContas.Items.Add(c);
            comboBox1.Items.Add(c);
            MessageBox.Show("Conta adicionada com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();
        }
        
        private void botaoSaque_Click_1(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            
            try
            {
                selecionada.Saca(valorOperacao);
                textoSaldo.Text = selecionada.Saldo.ToString();
                MessageBox.Show("Saque realizado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo Insuficiente!");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {

            Conta selecionada = (Conta)comboContas.SelectedItem;
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            selecionada.Deposita(valorOperacao);
            textoSaldo.Text = selecionada.Saldo.ToString();
            MessageBox.Show("Depósito realizado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoNumero.Text = selecionada.Numero.ToString();
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = selecionada.Saldo.ToString();
        }

        private void botaoTransfere_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            indice = comboBox1.SelectedIndex;
            Conta destino = this.contas[indice];
            double valorTransferencia = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valorTransferencia);
            destino.Deposita(valorTransferencia);
            MessageBox.Show("Transferência efetuada com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form = new FormCadastroConta(this);
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Acumula(conta);
            MessageBox.Show("Total: " + totalizador.Total);
            totalizador.Acumula(sv);
            MessageBox.Show("Total: " + totalizador.Total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var tipo = "ContaCorrente";
            //Type contaTipo = typeof(tipo);
           // var conta = Activator.CreateInstance(contaTipo);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            var titularTexto = textoTitularBusca.Text;
            var buscaTitular = contas.Where(c => c.Titular.Nome == titularTexto);
            
            if (buscaTitular.ToList().Count > 0) {
                foreach (Conta conta in buscaTitular)
                {
                    textoTitular.Text = conta.Titular.Nome;
                    textoNumero.Text = conta.Numero.ToString();
                    textoSaldo.Text = conta.Saldo.ToString();
                }
            }
            else
            {
                MessageBox.Show("Titular não encontrado");
            }
        }
    }
}
