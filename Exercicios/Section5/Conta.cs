using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Section5 {
    class Conta {

        public Conta(int numero, string nomeTitular){
            Numero = numero;
            Titular = nomeTitular;
        }

        public Conta(int numero, string nomeTitular, double saldo) : this(numero, nomeTitular) {
            setSaldo(saldo);
        }

        public double _saldo;
        public int Numero { get; }
        public string Titular { get; set; }

        public double realizarDeposito(double valor) {
            setSaldo(getSaldo() + valor);
            return getSaldo();
        }
        public double realizarSaque(double valor) {
            setSaldo (_saldo-valor-5);
            return getSaldo();
        }
        public double getSaldo() {
            return _saldo;
        }
        private void setSaldo(double value) {
            _saldo = value;
        }

        override
        public string ToString() {
            return "Conta: "+Numero+" , Titular: "+Titular+" , Saldo: $"+getSaldo();
        }
    }
}
