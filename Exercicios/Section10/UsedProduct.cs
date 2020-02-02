using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Section10
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override void PriceTag()
        {
            Console.WriteLine("{0} (used) $ {1} (Manufacture date: {2})", Name, Price.ToString("F2", CultureInfo.InvariantCulture), ManufactureDate.ToString("dd/MM/yyyy"));
        }

    }
}
