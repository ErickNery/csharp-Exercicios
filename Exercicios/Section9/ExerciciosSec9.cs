using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios.Section9.Exercicio1;

namespace Exercicios.Section9
{
    class ExerciciosSec9
    {
        /*Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
        do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo
        (próxima página).*/
        public void exercicio1()
        {
            Worker worker;
            Departament departament;
            string WorkerName;
            WorkerLevel workerLevel;
            double baseSalary;
            int numberOfContracts = 0;

            DateTime contractDate;
            double valuePerHour;
            int contractDuration;

            Console.WriteLine("*************************");
            Console.WriteLine("Enter department's name");
            departament = new Departament(Console.ReadLine());

            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            WorkerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            switch (Console.ReadLine().ToUpper())
            {
                case "JUNIOR":
                    workerLevel = WorkerLevel.JUNIOR;
                    break;
                case "MIDLEVEL":
                    workerLevel = WorkerLevel.MID_LEVEL;
                    break;
                case "SENIOR":
                    workerLevel = WorkerLevel.SENIOR;
                    break;
                default:
                    workerLevel = WorkerLevel.JUNIOR;
                    break;
            }
            Console.Write("Base salary: ");
            baseSalary = double.Parse(Console.ReadLine());

            worker = new Worker(WorkerName, workerLevel, baseSalary, departament);

            Console.Write("How many contracts to this worker? ");
            numberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfContracts; i++)
            {
                Console.WriteLine("Enter #{0} contract data", i);
                Console.Write("Date (DD/MM/YYYY): ");
                contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                contractDuration = int.Parse(Console.ReadLine());

                worker.HourContracts.Add(new HourContract(contractDate, valuePerHour, contractDuration));
            }


            Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
            DateTime dateToSearch = DateTime.Parse(Console.ReadLine());
            double income = worker.BaseSalary;

            foreach (HourContract contract in worker.HourContracts)
            {
                if (contract.Date.Month == dateToSearch.Month && contract.Date.Year == dateToSearch.Year)
                {
                    income += contract.totalValue();
                }
            }
            Console.Write("Name: ");
            Console.WriteLine(worker.Name);
            Console.Write("Department: ");
            Console.WriteLine(worker.WorkerDepartament);
            Console.Write("Income for 08/2018: ");
            Console.WriteLine(income);
        }
    }
}
