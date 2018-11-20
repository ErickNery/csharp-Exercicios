using System;
using System.Globalization;
using System.Collections;


namespace ExerciciosIntroducaoPOO {
    class Main {

        static void Main(string[] args) {

            //Exercicio1();
            //Exercicio2();
            Exercicio3();

            Console.ReadKey();
        }

        static void Exercicio1() {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Informe a altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Informe a largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine().Trim());
            Console.WriteLine();
            Console.WriteLine(retangulo);
        }

        static void Exercicio2() {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine().Trim();
            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine().Trim());
            Console.Write("Desconto: ");
            funcionario.Desconto = double.Parse(Console.ReadLine().Trim());

            Console.WriteLine();
            Console.WriteLine(funcionario);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salario em qual porcentagem: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine().Trim()));
            Console.WriteLine();
            Console.WriteLine(funcionario);
        }

        static void Exercicio3() {

            string[] notas;
            Aluno aluno = new Aluno();
            aluno.Notas = new double[3];

            Console.Write("Informe o nome do aluno: ");
            aluno.Nome = Console.ReadLine().Trim();
            Console.Write("Informe a 3 notas do aluno separadas por espaco: ");
            notas = Console.ReadLine().Split(' ');
            

            for (int i = 0; i < notas.Length; i++) {
                aluno.Notas[i] = double.Parse(notas[i]);
            }

            Console.WriteLine();
            aluno.cauculaMedia();
        }
    }
}