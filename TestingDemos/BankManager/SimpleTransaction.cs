using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager
{
    public class SimpleTransaction : Transaction
    {
        public SimpleTransaction(int baseAmount) : base(baseAmount) { }

        public override int CalculateTotalTransaction() { return BaseAmount; }
    }
}
