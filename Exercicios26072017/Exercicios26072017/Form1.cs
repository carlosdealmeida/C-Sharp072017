using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios26072017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Funcionario("Daniel","22234-5", new DateTime(2007, 1, 1));
            f1.Cpf = "11111111111";
            f1.Salario = 8000;

            var f2 = new Funcionario("12345-5", new DateTime(1997, 1, 1), "Leandro");
            f2.Cpf = "11122233344";
            f2.Salario = 5000;

            MessageBox.Show(f1.RelatorioBonificacoes());
        }
    }
}
