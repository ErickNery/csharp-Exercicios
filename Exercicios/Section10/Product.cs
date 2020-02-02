using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Section10
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void PriceTag()
        {
            //Notebook $ 1100.00
            Console.WriteLine("{0} $ {1}", Name, Price.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
