using System;


namespace ExerciciosIntroducaoPOO {
    class Retangulo {

        public double Altura { get; set; }
        public double Largura { get; set; }

        public double area() {

            return this.Altura * this.Largura;
        }
        public double perimetro() {
            return 2 * (this.Altura + this.Largura);
        }
        public double diagonal() {
            return Math.Sqrt(
                    (Math.Pow(this.Altura, 2) + Math.Pow(this.Largura, 2))
                );
        }

        public override string ToString() {
            return string.Format("AREA: {0}\nPERIMETRO: {1}\nDIAGONAL: {2}", area(), perimetro(), diagonal());
        }
    }
}
