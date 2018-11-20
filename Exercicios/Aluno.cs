using System;

namespace ExerciciosIntroducaoPOO {
    class Aluno {

        public string Nome { get; set; }
        public double[] Notas { get; set; }
        public const double MINIMO = 60;

        public void cauculaMedia() {
            double media = Notas[0] + Notas[1] + Notas[2];


            Console.WriteLine("NOTA FINAL: {0}", media);
            if (media > MINIMO) Console.WriteLine("APROVADO");
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", MINIMO - media);
            }
        }
    }
}
