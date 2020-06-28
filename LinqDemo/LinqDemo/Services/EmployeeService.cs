using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using LinqDemo.Controllers;
using LinqDemo.Entities;
using LinqDemo.Models;

namespace LinqDemo.Services
{
    class EmployeeService
    {
        ReadController readController;

        public EmployeeService()
        {
            readController = new ReadController();
        }

        public List<Employee> loadEmployees(IRead readObject)
        {
            List<string[]> readedEmployees = readController.read(readObject);
            List<Employee> employees = new List<Employee>();

            foreach(string[] s in readedEmployees)
            {
                employees.Add(new Employee(s[0], double.Parse(s[2], CultureInfo.InvariantCulture), s[1]));
            }
            return employees;
        }
    }
}
