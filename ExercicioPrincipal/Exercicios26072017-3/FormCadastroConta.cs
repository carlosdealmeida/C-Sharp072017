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
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        private ICollection<string> devedores;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            string titularTexto = textoTitular.Text;

            bool ehdevedor = this.devedores.Contains(titularTexto);

            if (!ehdevedor)
            {
                Cliente titular = new Cliente(textoTitular.Text);
                Conta conta = new ContaCorrente();
                conta.Titular = titular;
                conta.Numero = Convert.ToInt32(textoNumero.Text);
                formPrincipal.AdicionaConta(conta);
                textoTitular.Text = "";
                int proxima = formPrincipal.ProximaConta();
                textoNumero.Text = proxima.ToString();
            }
            else
            {
                MessageBox.Show("CALOTEIRO!!!");
            }

        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            int proxima = formPrincipal.ProximaConta();
            textoNumero.Text = proxima.ToString();


        }
    }
}
