using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woody_Cashflowmanager
{
    internal class Employee : IPayable
    {
        private string _FirstName;
        private string _LastName;
        private string _SSN;
        private Ledger.LedgerType _LedgerType;
        private decimal _Payable;

        public Employee(string FirstName, string LastName, string SSN)
        {
            _FirstName = FirstName;
            _LastName = LastName;
            _SSN = SSN;
        }

        public string ReturnFirstName
        {
            get { return _FirstName; }
        }

        public string ReturnLastName
        {
            get { return _LastName; }
        }

        public string ReturnSSN
        {
            get { return _SSN; }
        }

        public Ledger.LedgerType setLedgerType(Ledger.LedgerType _LT)
        {
            _LedgerType = _LT;
            return _LedgerType;
        }

        public Ledger.LedgerType LedgerType
        {
            get { return _LedgerType; }
        }

        public decimal setPayable(decimal _PAY)
        {
            _Payable = _PAY;
            return _Payable;
        }

        public decimal Payable
        {
            get { return _Payable; }
        }
    }
}