using System;
using Contribuintes.Entidades;
using System.Collections.Generic;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lista = new List<Contribuinte>();

            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte nº {i}:");
                Console.Write("Pessoa ou empresa (p/e): ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda: $");
                double renda = double.Parse(Console.ReadLine());
                if (resp == 'p' || resp == 'P')
                {
                    Console.Write("Gastos em saúde: $");
                    double gasto = double.Parse(Console.ReadLine());
                    lista.Add(new Fisica(nome, renda, gasto));
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    int nFunc = int.Parse(Console.ReadLine());
                    lista.Add(new Juridica(nome, renda, nFunc));
                }
            }

            double soma = 0;
            Console.WriteLine("IMPOSTOS PAGOS:");
            foreach (Contribuinte imposto in lista)
            {
                Console.WriteLine($"{imposto.Nome}: ${imposto.Imposto():F2}");
                soma += imposto.Imposto();
            }
            
            Console.Write("TOTAL DE IMPOSTO: $" + soma.ToString("F2"));
        }
    }
}
