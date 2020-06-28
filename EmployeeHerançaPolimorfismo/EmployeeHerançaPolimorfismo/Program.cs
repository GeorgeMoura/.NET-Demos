using System;
using System.Collections.Generic;

namespace EmployeeHerançaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("George", 12.00, 100.00);
            Employee employee2 = new Employee("Nunes", 12.00, 100.00);
            Employee tercEmployee = new OutsourcedEmployee("Moura", 12.00, 100.00, 200.00);

            List<Employee> listaFuncionarios = new List<Employee>();

            listaFuncionarios.Add(employee1);
            listaFuncionarios.Add(employee2);
            listaFuncionarios.Add(tercEmployee);

            foreach(Employee e in listaFuncionarios)
            {
                Console.WriteLine(e.show());
            }
        }
    }
}
