using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Section10
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        private const double faixaDesconto = 0.14;
        private const double faixa = 0.16;
        private const int qtdEmpregadosFaixa = 10;

        public Company (string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override void Tax()
        {
            double taxa = 0;
            if (NumberOfEmployees < qtdEmpregadosFaixa) taxa = AnualIncome * faixa;
            else taxa = AnualIncome * faixaDesconto;

            Console.WriteLine("{0}: $ {1}", Name, taxa.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
