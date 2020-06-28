using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestProject
{
    class Conta
    {
        private int numeroConta { get; set; }
        private string titularConta { get; set; }
        
        private double saldo = 0;
        private static int taxaSaque = 5;

        public Conta(int numeroConta, string titularConta)
        {
            this.numeroConta = numeroConta;
            this.titularConta = titularConta;
        }

        public Conta(int numeroConta, string titularConta, double depositoInicial)
        {
            this.numeroConta = numeroConta;
            this.titularConta = titularConta;
            this.saldo = depositoInicial;
        }

        public double deposito(double deposito)
        {
            this.saldo += deposito;
            return this.saldo;
        }

        public double saque(double quantia)
        {
            this.saldo -= (quantia + taxaSaque);
            return this.saldo;
        }

        public override string ToString()
        {
            return "Conta: "
                + this.numeroConta
                + ", Titular conta: "
                + this.titularConta
                + ", Saldo: $ "
                + this.saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
