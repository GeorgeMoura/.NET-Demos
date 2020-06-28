using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHerançaPolimorfismo
{
    class OutsourcedEmployee : Employee
    {
        public double taxaExtra { get; private set; }

        public OutsourcedEmployee(string nome, double horasTrabalhadas, double valorPorHora, double taxaExtra) : base(nome, horasTrabalhadas, valorPorHora)
        {
            this.taxaExtra = taxaExtra;
        }

        public override string show()
        {
            return base.nome + " : " + ((base.horasTrabalhadas * base.valorPorHora) + (this.taxaExtra * 1.1));
        }
    }
}

