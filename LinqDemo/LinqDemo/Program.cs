using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using LinqDemo.Entities;
using LinqDemo.Models;
using LinqDemo.Services;
using Microsoft.VisualBasic.CompilerServices;

namespace LinqDemo
{
    class Program
    {
        //"C:\\Users\\Pichau\\Documents\\Projetos\\Curso C#\\LinqDemo\\LinqDemo\\employees.txt"
        static void Main(string[] args)
        {

            string path = "C:\\Users\\Pichau\\Documents\\Projetos\\Curso C#\\LinqDemo\\LinqDemo\\employees.txt";

            Console.Write("Enter the threshold salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            EmployeeService employeeService = new EmployeeService();
            ReadTxt readTxt = new ReadTxt(path, ',');

            List<Employee> employees = employeeService.loadEmployees(readTxt);

            Console.WriteLine("Emails of people who salary is greater then " + salary);
            var emails = employees.Where(e => e.Salario > salary).Select(e => e.email).ToList();

            foreach(string s in emails)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Sum of salary of peaople who name starts with \'G\':");
            var soma = employees.Where(e => char.ToUpper(e.Name[0]) == 'G').Select(e => e.Salario).Sum();

            Console.WriteLine(soma);
        }
    }
}
