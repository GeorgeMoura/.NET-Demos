using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHerançaPolimorfismo
{
    class Employee
    {
        //esses atributos são PROPRIEDADES, implementações do C# pra facilitar gets e sets na hora de chamar esses métodos, aqui tou usando AUTO PROPERTIES
        public string nome { get; set; }
        public double horasTrabalhadas { get; set; }
        public double valorPorHora { get; set; }

        public Employee(string nome, double horasTrabalhadas, double valorPorHora)
        {
            this.nome = nome;
            this.horasTrabalhadas = horasTrabalhadas;
            this.valorPorHora = valorPorHora;
        }

        public virtual string show()
        {
            return this.nome + " : " + this.horasTrabalhadas * this.valorPorHora;
        }
    }
}
