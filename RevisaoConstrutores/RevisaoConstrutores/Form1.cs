using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoConstrutores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            var n1 = 2;
            var n2 = 3;

            MessageBox.Show(calc.Soma(n1, n2).ToString());
            MessageBox.Show(calc.Multiplicacao(n1, n2).ToString());
            MessageBox.Show(calc.Potencia(n1, n2).ToString());
        }
    }
}
