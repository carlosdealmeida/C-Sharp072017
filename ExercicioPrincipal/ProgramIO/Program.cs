using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramIO
{
    class Program
    {
        static void Main(string[] args)
        {
            MostraConteudo("C:/Users/fn7024/Desktop/produtos.csv");
        }

        static void MostraConteudo(string nomeArquivo)
        {
            try
            {
                using (Stream arquivo = File.OpenRead(nomeArquivo))
                using (StreamReader leitor = new StreamReader(arquivo))
                {
                    string linha = leitor.ReadLine();

                    while (linha != null)
                    {
                        Console.WriteLine(linha);
                        linha = leitor.ReadLine();
                    }
                }
                
                Console.ReadKey();
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
