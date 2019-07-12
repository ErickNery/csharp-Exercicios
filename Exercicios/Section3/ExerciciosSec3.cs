using System;
using System.Collections.Generic;

namespace Exercicios.Section3 {
    class ExerciciosSec3 {

        public void exercicio1() {
            try {
                Console.WriteLine("informe numero1");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe numero2");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("soma = {0}", n1+n2);
            }
            catch(FormatException e) {
                Console.WriteLine("Numero invalido");
            }
        }

    }
}
