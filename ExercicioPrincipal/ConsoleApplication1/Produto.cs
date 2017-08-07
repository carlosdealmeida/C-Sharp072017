using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos1
{
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public double PrecoUnitario { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}: R$ {3}", Id, Descricao, Categoria, PrecoUnitario);
        }
    }
}
