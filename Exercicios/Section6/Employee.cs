using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Section6 {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void raiseSalary(double percentage) {
            Salary *= (percentage/100+1);
        }

        override
        public string ToString() {
            return String.Format("{0}, {1}, {2}", Id
                ,Name, Salary);
        }
    }
}
