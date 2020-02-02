using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Section10
{
    class ExerciciosSec10
    {
        /*
         Fazer um programa para ler os dados de N
         produtos (N fornecido pelo usuário). Ao final,
         mostrar a etiqueta de preço de cada produto na
         mesma ordem em que foram digitados.
         Todo produto possui nome e preço. Produtos
         importados possuem uma taxa de alfândega, e
         produtos usados possuem data de fabricação.
         Estes dados específicos devem ser
         acrescentados na etiqueta de preço conforme
         exemplo (próxima página). Para produtos
         importados, a taxa e alfândega deve ser
         acrescentada ao preço final do produto
        */
        public void Exercicio1()
        {
            //double dataTeste = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write(dataTeste.ToString("F2", CultureInfo.InvariantCulture));

            int produtcsQtd;
            List<Product> produtos = new List<Product>();
            char productType;
            string name;
            double price;
            double customFee = 0;
            DateTime manufactureDate = DateTime.Today;

            Console.Write("Enter the number of products: ");
            produtcsQtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= produtcsQtd; i++)
            {
                Console.WriteLine("Product #{0} data: ", i);
                Console.Write("Common, used or imported (c/u/i)? ");
                productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufactureDate = DateTime.Parse(Console.ReadLine());
                }

                switch (productType)
                {
                    case 'c':
                        produtos.Add(new Product(name, price));
                        break;
                    case 'i':
                        produtos.Add(new ImportedProduct(name, price, customFee));
                        break;
                    case 'u':
                        produtos.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    default:
                        produtos.Add(new Product(name, price));
                        break;
                }
            }

            foreach (Product produto in produtos)
            {
                produto.PriceTag();
            }  
        }

        public void Exercicio2()
        {
            int qdtPayers;
            TaxPayer pagador;
            List<TaxPayer> pagadores = new List<TaxPayer>();
            char taxPayerType;
            string name;
            double anualIncome;
            double healthExpenditure;
            int qdtEmpoyees;
            double totalTaxas = 0;
            double taxa;

            Console.Write("Enter the number of tax payers: ");
            qdtPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qdtPayers; i++)
            {
                Console.Write("Tax payer #{0} data: ", i);
                Console.Write("Individual or company (i/c)? ");
                taxPayerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Anual income: ");
                anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (taxPayerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pagador = new Individual(name, anualIncome, healthExpenditure);
                }
                else
                {
                   Console.Write("Number of employees: ");
                   qdtEmpoyees = int.Parse(Console.ReadLine());
                   pagador = new Company(name, anualIncome, qdtEmpoyees);
                }
                pagadores.Add(pagador);
            }

            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer umPagador in pagadores)
            {
                umPagador.Tax();
            }
        }
    }
}
