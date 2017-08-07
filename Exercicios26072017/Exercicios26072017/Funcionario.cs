using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios26072017
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public double Salario { get; set; }
        private string cpf;

        public Funcionario(string nome, string matricula, DateTime dataAdmissao)
        {
            Nome = nome;
            Matricula = matricula;
            DataAdmissao = dataAdmissao;
        }

        public Funcionario(string matricula, DateTime dataAdmissao, string nome)
        {
            Nome = nome;
            Matricula = matricula;
            DataAdmissao = dataAdmissao;
        }

        public string Cpf
        {
            get { return cpf; }
            set { if (ValidaCpf(value)) cpf = value; }
        }

        public bool ValidaCpf (string cpf)
        {
            return true;
        }

        public double RecebeAnuenio ()
        {
            return (Salario * 0.01) * AnosDeEmpresa();
        }

        public double RecebeBonusAnual ()
        {
            return (Salario * 0.1);
        }

        private int AnosDeEmpresa()
        {
            return DateTime.Now.Year - DataAdmissao.Year;
        }

        public string RelatorioBonificacoes()
        {
            var anuenio = RecebeAnuenio();
            var bonusAnual = RecebeBonusAnual();
            return "O salário é de " + Salario + ", seu Anuenio é de: " + anuenio + ", seu Bonus Anual é de: " + bonusAnual;
        }

    }
}
