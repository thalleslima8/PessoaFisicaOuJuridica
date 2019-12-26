using PessoaFisicaOuJuridica.Entities;
using System;
using System.Collections.Generic;

namespace PessoaFisicaOuJuridica {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o numero de pagadores de impostos: ");
            int n = int.Parse(Console.ReadLine());
            List<Pessoa> List = new List<Pessoa> { };

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Pagador de imposto #{i}: ");
                Console.WriteLine("Pessoa Fisica ou Juridica (f/j)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());

                if(ch == 'f' || ch == 'F') {
                    Console.WriteLine("Informe valor gasto com saude: ");
                    double saude = double.Parse(Console.ReadLine());

                    List.Add(new Fisica(nome, renda, saude));
                } else {
                    Console.WriteLine("Digite Quantidade de funcionarios: ");
                    int func = int.Parse(Console.ReadLine());

                    List.Add(new Juridica(nome, renda, func));
                }
            }

            Console.WriteLine("\nTaxas Pagas: ");
            double soma = 0;
            foreach(Pessoa p in List) {
                Console.WriteLine("\n" + p.Nome + ": R$ " + p.CalculoImposto().ToString("F2"));
                soma += (p.CalculoImposto());
            }

            Console.WriteLine("\nTotal de Taxas Pagas: R$ " + soma);
        }
    }
}
