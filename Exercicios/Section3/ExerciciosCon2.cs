using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Section3 {
    //Exercicios 2 Estrutura condicional
    class ExerciciosCon2 {

        public void exercicio1() {
            Console.Write("Informe numero: ");
            if (int.Parse(Console.ReadLine()) < 0)
                Console.WriteLine("NEGATIVO");
            else Console.WriteLine("NAO NEGATIVO");
        }
        public void exercicio2() {
            Console.Write("Informe numero: ");
            if (int.Parse(Console.ReadLine()) % 2 == 0)
                Console.WriteLine("PAR");
            else Console.WriteLine("IMPAR");
        }
        public void exercicio3() {
            int a, b;
            Console.Write("Informe numero1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe numero2: ");
            b = int.Parse(Console.ReadLine());
            if (a % b == 0 || b % a == 0)
                Console.WriteLine("Sao Multiplos");
            else Console.WriteLine("Nao Sao Multiplos");
        }
        public void exercicio4() {
            int a, b;
            Console.Write("Informe numero1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe numero2: ");
            b = int.Parse(Console.ReadLine());
            if (a >= b) {
                a = 24 - a;
                a += b;
            }
            else {
                a = b - a;
            }
            Console.Write("O jogo durou {0} horas", a);
        }
        public void exercicio5() {
            //menu
            //Item 1 - R$ 4.00
            //Item 2 - R$ 4.50
            //Item 3 - R$ 5.00
            //Item 4 - R$ 2.00
            //Item 5 - R$ 1.50
            //Receber quantidade de item e tipo do item, devolver valor total
            double[] produtos = { 4, 4.5, 5, 2, 1.5 };
            int qtdItem, tipoItem;
            Console.Write("Informe item: ");
            tipoItem = int.Parse(Console.ReadLine());
            Console.Write("Informe qtdItem: ");
            qtdItem = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor total é {0}", qtdItem * produtos[tipoItem - 1]);
        }
        public void exercicio6() {
            double numero;
            Console.Write("Informe numero: ");
            numero = double.Parse(Console.ReadLine());
            if (numero >= 0 && numero <= 25) Console.WriteLine("Intervalo [0,25]");
            else if (numero > 25 && numero <= 50) Console.WriteLine("Intervalo [25,50]");
            else if (numero > 50 && numero <= 75) Console.WriteLine("Intervalo [50,75]");
            else if (numero > 75 && numero <= 100) Console.WriteLine("Intervalo [75,100]");
            else Console.WriteLine("Fora de intervalo");
        }
        public void exercicio7() {
            double x, y;
            Console.Write("Informe cordenada x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Informe cordenada y: ");
            y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0) Console.Write("Q1");
            else if (x < 0 && y > 0) Console.Write("Q2");
            else if (x < 0 && y < 0) Console.Write("Q3");
            else if (x > 0 && y < 0) Console.Write("Q4");
            else Console.WriteLine("Origem");
        }
        public void exercicio8() {
            double salario;
            //salario limite das faixas
            double faixa1 = 2000, faixa2 = 3000, faixa3 = 4500;
            double taxFax1 = 0.08, taxFax2 = 0.18, taxFax3 = 0.28;
            double maxFaixa2 = (faixa3 - faixa2) * taxFax2;
            double maxFaixa1 = (faixa2 - faixa1) * taxFax1;

            double resultadoTaxa = 0;
            Console.WriteLine("Informe salario");
            salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(salario <= faixa1) {
                //Se abaixo da faixa mas baixa, insencao total
                Console.WriteLine("Insento");
            } else if(salario > faixa1 && salario <= faixa2) {
                //Nesse caso paga o que exceder a faixa insenta
                Console.WriteLine("R$ {0}", (salario - faixa1) * taxFax1);
            }
            else if (salario > faixa2 && salario <= faixa3) {
                //Paga o que exceder a faixa de cima, mais o maximo da intermediaria
                Console.WriteLine("R$ {0}",
                    (salario - faixa2)* taxFax2 + maxFaixa1
                    );
            }
            else {
                Console.WriteLine("R$ {0}",
                    //Paga o que exceder a faixa de cima, mais o maximo que pode ser pago nas outras faixas
                    (salario - faixa3)* taxFax3 + maxFaixa2 + maxFaixa1
                    );
            }

        }
    }
}