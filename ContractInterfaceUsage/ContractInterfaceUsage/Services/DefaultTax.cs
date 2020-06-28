using System;
using System.Collections.Generic;
using System.Text;
using ContractInterfaceUsage.Interfaces;

namespace ContractInterfaceUsage.Services
{
    class DefaultTax : Itax
    {
        public double taxaMes { get; private set; }
        public double taxaTotal { get; private set; }

        public DefaultTax()
        {
            this.taxaMes = 0.01;
            this.taxaTotal = 0.02;
        }
            
        public double applyTax(double installmentValue, int installmentNumber)
        {
            double monthApply = (installmentValue + (this.taxaMes * installmentValue * installmentNumber));
            double totalApply = (monthApply * this.taxaTotal);

            return monthApply + totalApply;
        }
    }
}
