using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woody_Cashflowmanager
{
    internal interface IPayable
    {
        public decimal Payable { get; }

        public Ledger.LedgerType LedgerType { get; }
    }
}

//Ipayable array of ipayable items, because it connects everything together. "One ring to rule them all" LOTR reference
