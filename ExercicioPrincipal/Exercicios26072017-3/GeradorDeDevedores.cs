using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

class GeradorDeDevedores
{
    public ICollection<string> GeraList()
    {
        var nomes = new HashSet<string>();
        for (int i = 0; i < 30000; i++)
        {
            nomes.Add("devedor " + i);
        }
        return nomes;
    }
}
