using System;

namespace ExerciciosIntroducaoPOO {
    class Funcionario {

        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Desconto { get; set; }


        public double SalarioLiquido() {
            return this.SalarioBruto - this.Desconto;
        }

        public void AumentarSalario(double porcentagem) {
            porcentagem = 1 + (porcentagem / 100);

            SalarioBruto *= porcentagem;
        }

        public override string ToString() {
            return string.Format("Dados do funcionario: {0}, R$ {1}", Nome, SalarioLiquido());
        }
    }
}
