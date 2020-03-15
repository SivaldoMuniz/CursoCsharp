using System;
using System.Collections.Generic;
using System.Globalization;
using projeto04.Entities;

namespace projeto04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Entre com o numero de Contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Contribuinte #{i} data: ");
                Console.Write("Individual ou Comapany (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Nome; ");
                String nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Gastos Saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(nome, renda, gastoSaude));
                }
                else
                {
                    Console.Write("Numero de Funcionários: ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new Company(nome, renda, numeroDeFuncionarios));
                }
            }

                double sum = 0.0;

                Console.WriteLine();
                Console.WriteLine("Imposto a Pagar: ");
                foreach ( TaxPayer tp in list)
                {
                    double tax = tp.Tax();
                Console.WriteLine(tp.Nome + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;

               
                }
            Console.WriteLine();
            Console.WriteLine("TOTAL IMPOSTOS: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));



        }


        }
    }

