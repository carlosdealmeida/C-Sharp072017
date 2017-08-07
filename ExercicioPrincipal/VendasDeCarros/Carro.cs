using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasDeCarros
{
    public class Carro
    {
        public String Cor { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2}) / {3} - {4}", Modelo, Cor, Marca, Ano, Preco);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (!(obj is Carro)))
            {
                return false;
            }
            Carro outra = (Carro)obj;
            return ((this.Cor == outra.Cor) && (this.Modelo == outra.Modelo) && (this.Marca == outra.Marca) && (this.Ano == outra.Ano));
        }

        public override int GetHashCode()
        {
            var hashCor = Cor.GetHashCode();
            var hashModelo = Modelo.GetHashCode();
            var hashMarca = Marca.GetHashCode();
            var hashAno = Ano.GetHashCode();
            var hashMaster = (hashCor + hashModelo) - (hashMarca + hashAno);
            return hashMaster;
        }
    }
}
