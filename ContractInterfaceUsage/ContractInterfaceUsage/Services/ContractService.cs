using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ContractInterfaceUsage.Entities;
using ContractInterfaceUsage.Interfaces;

namespace ContractInterfaceUsage.Services
{
    class ContractService
    {
        public ContractService()
        {
        }

        public void process(Contract contract, Itax tax)
        {
            double installmentBaseValue = contract.value / contract.installments;
            string installmentDate;
            double finalInstallmentValue;

            for(int i=1; i<=contract.installments; i++)
            {
                installmentDate = contract.date.AddMonths(i).ToString("d");
                finalInstallmentValue = tax.applyTax(installmentBaseValue, i);

                Console.WriteLine( installmentDate + " : " + finalInstallmentValue.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
