using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicios.Section3 {
    class ExerciciosSec3 {

        private struct ProdutoExercicio5 {
            public int codigoProduto, qtdProduto;
            public double valorProduto;
        }

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
       public void exercicio5() {
            //ler codigo produto, qtd e valor, entregar valor total
            ProdutoExercicio5[] produtos = new ProdutoExercicio5[2];
            
            for(int i = 0; i < 2; i++) {
                ProdutoExercicio5 produto = new ProdutoExercicio5();
                Console.Write("Informe codProduto: ");
                produto.codigoProduto = int.Parse(Console.ReadLine());
                Console.Write("Informe qtdProdutos: ");
                produto.qtdProduto = int.Parse(Console.ReadLine());
                Console.Write("Informe vlrProduto: ");
                produto.valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                produtos[i] = produto;
            }

            double total = 0;
            foreach(ProdutoExercicio5 produto in produtos){
                total += produto.qtdProduto * produto.valorProduto;
            }

            Console.WriteLine("VALOR A PAGAR: {0}", total.ToString("F2",CultureInfo.InvariantCulture));
        }
        public void exercicio6() {
            //Ler valores double A, B, C, devolver:
            //TRIANGULO: A*C/2
            //CIRCULO: PI*C²
            //TRAPEZIO: ((A+B)*C)/2
            //QUADRADO: B²
            //RETANGULO: A*B
            double[] variaveis = new Double[3];
            String[] leitura;

            Console.Write("Informe separado por espaco, A, B, e C: ");
            leitura = Console.ReadLine().Split();
            for (int i = 0; i < 3; i++) {
                variaveis[i] = double.Parse(leitura[i], CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            Console.WriteLine("TRIANGULO: {0}", (variaveis[0]* variaveis[2]/2).ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: {0}", (3.14159*Math.Pow(variaveis[2],2)).ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: {0}", ((variaveis[0]+variaveis[1])*variaveis[2]/2).ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", Math.Pow(variaveis[1],2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: {0}", (variaveis[0]* variaveis[1]).ToString("F3", CultureInfo.InvariantCulture));
        }
    }

}
