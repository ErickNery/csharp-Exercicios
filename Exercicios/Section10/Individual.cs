using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Section10
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        private const double faixa1 = 0.15;
        private const double faixa2 = 0.25;
        private const double limiteFaixa = 20000;


        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override void Tax()
        {
            double taxa = 0;
            if (AnualIncome < limiteFaixa) taxa = AnualIncome*faixa1;
            else taxa = AnualIncome*faixa2;

            taxa -= (HealthExpenditures / 2);

            Console.WriteLine("{0}: $ {1}", Name, taxa.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}
