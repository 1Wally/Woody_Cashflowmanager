using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woody_Cashflowmanager
{
    internal class SalariedEmployee : Employee
    {
        private decimal Earnings;

        public SalariedEmployee(string _FN, string _LN, string _SN, decimal _WLS) : base(_FN, _LN, _SN)
        {
            Earnings = _WLS;
            base.setLedgerType(Ledger.LedgerType.Salaried);
            base.setPayable(Earnings);
        }

        public override string ToString()
        {
            return "\nSalaried Employee: " + ReturnFirstName + " " + ReturnLastName + "\nSSN: " + ReturnSSN + "\nWeekly Salary: $" + Earnings + "\nEarned: $" + Earnings;
        }
    }
}
