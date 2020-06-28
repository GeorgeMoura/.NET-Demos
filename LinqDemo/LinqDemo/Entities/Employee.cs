using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LinqDemo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public double Salario { get; set; }
        public string email { get; set; }

        public Employee()
        {

        }

        public Employee(string name, double salario, string email)
        {
            this.Name = name;
            this.Salario = salario;
            this.email = email;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.Salario.ToString("F2", CultureInfo.InvariantCulture) + ", " + this.email; 
        }
    }
}
