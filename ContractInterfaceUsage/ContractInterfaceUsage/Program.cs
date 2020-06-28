using System;
using System.Globalization;
using ContractInterfaceUsage.Entities;
using ContractInterfaceUsage.Interfaces;
using ContractInterfaceUsage.Services;

namespace ContractInterfaceUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter the contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value, installments);

            ContractService contractService = new ContractService();

            Console.WriteLine("Installments: ");
            contractService.process(contract, new DefaultTax());
        }
    }
}
