using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ContractInterfaceUsage.Entities
{
    class Contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double value { get; set; }
        public int installments { get; set; }

        public Contract(int number, DateTime date, double value, int installments)
        {
            this.number = number;
            this.date = date;
            this.value = value;
            this.installments = installments;
        }
    }
}
