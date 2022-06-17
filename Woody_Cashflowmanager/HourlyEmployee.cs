using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woody_Cashflowmanager
{
    internal class HourlyEmployee : Employee
    {
        private decimal _HourlyWage;
        private int _HoursWorked;
        private decimal Earnings;
        private int Overtime;

        public HourlyEmployee(string _FN, string _LN, string _SN, decimal _HLW, int _HRW, int _OT) : base (_FN, _LN, _SN) 
        {
            _HourlyWage = _HLW;
            _HoursWorked = _HRW + _OT;
            Overtime = _OT;
            Earnings = _HourlyWage * _HoursWorked + Overtime * (_HourlyWage * 1.5m);
            base.setPayable(Earnings);
            base.setLedgerType(Ledger.LedgerType.Hourly);
        }

        public override string ToString()
        {
            return "\nHourly Employee: " + ReturnFirstName + " " + ReturnLastName + "\nSSN: " + ReturnSSN + "\nHourly Wage Salary: $" + _HourlyWage + "\nHours Worked: " + _HoursWorked + "\nEarned: $" + Earnings;
        }

    }
} 

//"Gotta watch out for those pesky doubles"