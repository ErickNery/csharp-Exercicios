using System;
using System.Threading;
using System.Globalization;
using System.Collections;
using Exercicios.Section3;
using Exercicios.Section5;
using Exercicios.Section6;
using Exercicios.Section9;
using Exercicios.Section10;
using Exercicios.Section11;

namespace ExerciciosIntroducaoPOO {
    class Program {

        private static ExerciciosSeq1 exercicios1 = new ExerciciosSeq1();
        private static ExerciciosCon2 exercicios2 = new ExerciciosCon2();
        private static ExerciciosSec6 exercicios6 = new ExerciciosSec6();
        private static ExerciciosSec9 exercicios9 = new ExerciciosSec9();
        private static ExerciciosSec10 exercicios10 = new ExerciciosSec10();
        private static ExerciciosSec11 exercicios11 = new ExerciciosSec11();

        static void Main(string[] args) {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            exercicios11.Exercicio1();
            Console.ReadKey();
        }
    }
}