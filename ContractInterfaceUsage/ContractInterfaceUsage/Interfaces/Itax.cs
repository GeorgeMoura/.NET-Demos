using System;
using System.Collections.Generic;
using System.Text;

namespace ContractInterfaceUsage.Interfaces
{
    interface Itax
    {
        public double applyTax(double installmentValue, int installmentNumber);
    }
}
