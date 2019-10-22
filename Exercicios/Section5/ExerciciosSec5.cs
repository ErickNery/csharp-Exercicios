using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Section5 {
    class ExerciciosSec5 {



        public static void main() {
            string[] entrada;
            Conta c;
            double valor = 0;

            Console.WriteLine();

            Console.Write("Havera deposito inicial na conta? s/n:");
            if (Console.ReadLine() == "n") entrada = new string[2];
            else entrada = new string[3];

            Console.Write("Informe numero da conta: ");
            entrada[0] = Console.ReadLine();
            Console.Write("Informe titular da conta: ");
            entrada[1] = Console.ReadLine();
            if (entrada.Length == 3) {
                Console.Write("Informe o saldo inicial da conta: ");
                entrada[2] = Console.ReadLine();
            }

            if (entrada.Length == 2) {
                c = new Conta(int.Parse(entrada[0]), entrada[1]);
            }
            else {
                c = new Conta(int.Parse(entrada[0]), entrada[1], double.Parse(entrada[2]));
            }

            Console.WriteLine(c + "\n");
            Console.Write("Entre um valor para deposito: ");
            valor = double.Parse(Console.ReadLine());
            c.realizarDeposito(valor);

            Console.WriteLine("Dados da conta atualizados\n" + c + "\n");
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            c.realizarSaque(valor);

            Console.WriteLine("Dados da conta atualizados\n" + c + "\n");
        }
    }
}
