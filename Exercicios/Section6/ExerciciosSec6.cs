using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace Exercicios.Section6 {
    class ExerciciosSec6 {
        public void main() {
            /*
            programa cadastra os empregados
            empregado tem id, nome e salario
            empregado tem uma funcao de aumentar salario com base numa porcentagem
            programa pergunta quantidade de empregados a ser cadastrados
            apos cadastro, programa pergunta qual é o id do empregado a ser aumentado e a porcentagem do aumento
            se não encontrar o id programa avisa, senão incrementa o salario e então printa na tela
            */

            int qtdEmployees, idToIncrease;
            List<Employee> EmployeeList = new List<Employee>();


            Console.Write("How many employees will be registered? ");
            qtdEmployees = int.Parse(Console.ReadLine());

            Employee anEmployee;
            for (int i = 0; i < qtdEmployees; i++) {
                anEmployee = new Employee();
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                anEmployee.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                anEmployee.Name = Console.ReadLine();
                Console.Write("Salary: ");
                anEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                EmployeeList.Add(anEmployee);
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            idToIncrease = int.Parse(Console.ReadLine());
            anEmployee = EmployeeList.Find(x => x.Id == idToIncrease);
            if (anEmployee == null) Console.WriteLine("This id does not exist!");
            else {
                Console.Write("Enter the percentage: ");
                anEmployee.raiseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            foreach (Employee item in EmployeeList) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
