using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasDeCarros
{
    class CarroComparer: IComparer<Carro>
    {
        public int Compare(Carro x, Carro y)
        {
            return x.Ano.CompareTo(y.Ano);
        }

    }

}
