using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendasDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Em Vetor:");
            Carro[] carros = new Carro[]
            {
                new Carro { Cor="Preto", Modelo = "Fusca", Marca = "VW", Ano = 1970, Preco = 230.34 },
                new Carro { Cor = "Azul", Modelo = "Fusca", Marca = "VW", Ano = 1981, Preco = 534.12 },
                new Carro { Cor="Preta", Modelo = "Sandero", Marca = "Renault", Ano = 2010, Preco = 1230.34 },
                new Carro { Cor = "Azul", Modelo = "Duster", Marca = "Renault", Ano = 2017, Preco = 4534.12 },
                new Carro { Cor = "Branco", Modelo = "Duster", Marca = "Renault", Ano = 2017, Preco = 4534.12 },
                new Carro { Cor = "Prata", Modelo = "Duster", Marca = "Renault", Ano = 2017, Preco = 4534.12 },
                new Carro { Cor="Vermelha", Modelo = "Fusca", Marca = "VW", Ano = 1964, Preco = 30.34 },
                new Carro { Cor = "Amarela", Modelo = "Fusca", Marca = "VW", Ano = 1973, Preco = 434.12 },
                new Carro { Cor="Preto", Modelo = "Fusca", Marca = "VW", Ano = 1970, Preco = 230.34 },
                new Carro { Cor="Preto", Modelo = "Fusca", Marca = "VW", Ano = 1970, Preco = 230.34 },
                new Carro { Cor = "Azul", Modelo = "Fusca", Marca = "VW", Ano = 1981, Preco = 534.12 }
            };
            for (var i = 0; i < carros.Length - 1; i++)
            {
                Console.WriteLine(carros[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ordenando Em Vetor:");

            Array.Sort(carros, new CarroComparer());

            for(var i = 0; i < carros.Length - 1; i++)
            {
                Console.WriteLine(carros[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ordenando Em Vetor Filtrado em LINQ QUERY:");

            var carros2 = from c in carros where c.Marca == "VW" orderby c.Ano, c.Preco select c;

            foreach(var carro in carros2)
            {
                Console.WriteLine(carro);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ordenando Em Vetor Filtrado com LINQ METHOD:");

            var carros3 = carros.Where(c => c.Marca == "Renault").OrderBy(c => c.Ano).Take(2).Select(c=>new { c.Ano, c.Modelo } );
            foreach (var carro in carros3)
            {
                Console.WriteLine(carro);
            }

            Console.ReadKey();
        }
    }
}
