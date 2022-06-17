using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woody_Cashflowmanager
{
    internal class Invoice : IPayable
    {
        private string PartNumber;
        private int Quantity;
        private string PartDescription;
        private decimal Price;
        private decimal Earnings;

        public Invoice(string _PN, int _QTY, string _PTD, decimal _PRC)
        {
            Earnings = _QTY * _PRC;
            PartNumber = _PN;
            PartDescription = _PTD;
            Price = _PRC;
            Quantity = _QTY;
        }

        public decimal Payable
        {
            get { return Earnings; }
        }

        public Ledger.LedgerType LedgerType
        {
            get { return Ledger.LedgerType.Invoice; }
        }

        public override string ToString()
        {
            return "\nInvoice number: " + PartNumber + "\nQuantity: " + Quantity + "\nPart Description: " + PartDescription + "\nUnit Price: $" + Price + "\nExtended Price: $" + Earnings;
        }
    }
}