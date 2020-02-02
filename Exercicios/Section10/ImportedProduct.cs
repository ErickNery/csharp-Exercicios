using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Section10
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee )
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override void PriceTag()
        {
            Console.WriteLine("{0} $ {1} (Customs fee: $ {2})", Name, TotalPrice().ToString("F2", CultureInfo.InvariantCulture), CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
