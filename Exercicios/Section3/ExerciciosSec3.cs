using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicios.Section3 {
    class ExerciciosSec3 {

        public void exercicio1() {
            try {
                Console.WriteLine("informe numero1");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe numero2");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("soma = {0}", n1 + n2);
            }
            catch (FormatException) {
                Console.WriteLine("Numero invalido");
            }
        }

        public void exercicio2() {

            //area = pi * raio²
            Console.WriteLine("Informe o raio:");
            int raio = int.Parse(Console.ReadLine());
            Console.WriteLine("A={0}", (Math.PI * (Math.Pow(raio, 2))).ToString("F4"));

        }

        public void exercicio3() {
            //pegar a b c d
            //calcular (a*b)-(//c*d)
            int[] variaveis = new int[4];
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Informe o numero:");
                string leitura = Console.ReadLine();
                variaveis[i] = int.Parse(leitura);
            }
            Console.WriteLine("Resultado = {0}", (
                (variaveis[0] * variaveis[1]) - (variaveis[2] * variaveis[3])
                ));
        }
        public void exercicio4() {
            //receber numero horas e valor hora entregar salario
            string numeroEmpregado;
            int horas;
            double valorHora;
            Console.WriteLine("Informe o numero do empregado:");
            numeroEmpregado = Console.ReadLine();
            Console.WriteLine("Informe o horas:");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valorHora:");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorHora *= horas;
            Console.WriteLine("NUMBER: {0}", numeroEmpregado);
            Console.WriteLine("SALARY: {0}", valorHora.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}
