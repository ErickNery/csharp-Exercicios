using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Section9
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament WorkerDepartament { get; set; }
        public List<HourContract> HourContracts;

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            WorkerDepartament = departament;
            HourContracts = new List<HourContract>();
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament, List<HourContract> Contracts)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            WorkerDepartament = departament;
            HourContracts = Contracts;
        }

        public void addContract(HourContract hourContract)
        {
            HourContracts.Add(hourContract);
        }

        public bool removeContract(HourContract hourContract)
        {
           return HourContracts.Remove(hourContract);
        }

        public double income(int year, int month)
        {
            double workerIncome = BaseSalary;
            foreach (HourContract contract in HourContracts)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                    workerIncome += contract.totalValue();
            }
            return workerIncome;
        }

    }
}
