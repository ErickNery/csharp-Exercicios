using System;
using System.Globalization;
using System.Collections;
using Exercicios.Section3;
using Exercicios.Section5;
using Exercicios.Section6;


namespace ExerciciosIntroducaoPOO {
    class Program {

        private static ExerciciosSeq1 exercicios1 = new ExerciciosSeq1();
        private static ExerciciosCon2 exercicios2 = new ExerciciosCon2();
        private static ExerciciosSec6 exercicios6 = new ExerciciosSec6();

        static void Main(string[] args) {
            exercicios6.main();
            Console.ReadKey();
        }
    }
}