using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos1
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new List<Produto>
            {
                new Produto { Id = 1, Descricao = "Laranja", Categoria = "Hortifruti", PrecoUnitario = 0.99 },
                new Produto { Id = 2, Descricao = "Banana", Categoria = "Hortifruti", PrecoUnitario = 1.99 },
                new Produto { Id = 3, Descricao = "Maçã", Categoria = "Hortifruti", PrecoUnitario = 2.99 },
                new Produto { Id = 4, Descricao = "Abacaxi", Categoria = "Hortifruti", PrecoUnitario = 3.99 },
                new Produto { Id = 5, Descricao = "Morango", Categoria = "Hortifruti", PrecoUnitario = 4.99 },
                new Produto { Id = 6, Descricao = "Detergente", Categoria = "Limpeza", PrecoUnitario = 5.99 },
                new Produto { Id = 7, Descricao = "Água Sanitária", Categoria = "Limpeza", PrecoUnitario = 6.99 },
                new Produto { Id = 8, Descricao = "Detergente", Categoria = "Limpeza", PrecoUnitario = 7.99 },
                new Produto { Id = 9, Descricao = "Presunto", Categoria = "Frios", PrecoUnitario = 8.99 },
                new Produto { Id = 10, Descricao = "Mortadela", Categoria = "Frios", PrecoUnitario = 9.99 },
                new Produto { Id = 11, Descricao = "Muzzarela", Categoria = "Frios", PrecoUnitario = 10.99 },
                new Produto { Id = 12, Descricao = "Picanha", Categoria = "Carnes", PrecoUnitario = 11.99 },
                new Produto { Id = 13, Descricao = "Patinho", Categoria = "Carnes", PrecoUnitario = 12.99 },
                new Produto { Id = 14, Descricao = "Frango", Categoria = "Carnes", PrecoUnitario = 13.99 },
                new Produto { Id = 15, Descricao = "Calabresa", Categoria = "Carnes", PrecoUnitario = 14.99 },
                new Produto { Id = 16, Descricao = "Peixe", Categoria = "Carnes", PrecoUnitario = 15.99 },
            };

            Console.WriteLine("Questão número 4:");
            Console.WriteLine();
            Console.WriteLine();

            var resultado4 = produtos.Where(p => p.Categoria == "Frios" && p.PrecoUnitario < 10);

            foreach (Produto produto in resultado4)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Questão número 5:");
            Console.WriteLine();
            Console.WriteLine();

            var resultado5 = produtos.Where(p => p.Categoria == "Carnes").OrderBy(p => p.Descricao);

            foreach (Produto produto in resultado5)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Questão número 6:");
            Console.WriteLine();
            Console.WriteLine();

            var resultado6 = produtos.Where(p => p.Categoria == "Hortifruti").Sum(p => p.PrecoUnitario);

            Console.WriteLine("O total dos produtos do Hortifruti: " + resultado6);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Questão número 7:");
            Console.WriteLine();
            Console.WriteLine();

            var resultado7 = produtos.Where(p => (p.Id % 2) == 0).OrderByDescending(p => p.PrecoUnitario);

            foreach (Produto produto in resultado7)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Questão número 8:");
            Console.WriteLine();
            Console.WriteLine();

            var resultado8 = produtos.GroupBy(p => p.Categoria);

            foreach (var produto5 in resultado8)
            {
                Console.WriteLine("Categoria = {0}", produto5.Key);
                foreach (var descricao in produto5)
                {
                    Console.Write("Produto: {0} ", descricao);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Questão número 9:");
            Console.WriteLine();
            Console.WriteLine();

            var resultado9 = produtos.GroupBy(p => p.Categoria).OrderBy(p => p.Key);

            foreach (var produto6 in resultado9)
            {
                Console.WriteLine("Categoria = {0}", produto6.Key);
                foreach (var descricao in produto6)
                {
                    Console.Write("Produto: {0} ", descricao);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Questão número 10:");
            Console.WriteLine();
            Console.WriteLine();

            var resultado10 = produtos.GroupBy(p => p.Categoria);

            foreach (var produto6 in resultado9)
            {
                Console.WriteLine("Categoria = {0}", produto6.Key);
                foreach (var descricao in produto6)
                {
                    Console.WriteLine("Produto: {0} ", descricao);
                }
                Console.WriteLine("Total da Categoria: " + produto6.Sum(p => p.PrecoUnitario));
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
