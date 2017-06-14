using System;
using System.Collections.Generic;
using System.Text;

namespace BankManager
{
    #region #8 Abstract Driver
    
    public abstract class Transaction
    {
        public int BaseAmount { get; private set; }

        protected Transaction(int baseAmount)
        {
            BaseAmount = baseAmount;
        }

        public abstract int CalculateTotalTransaction();
    }
    
    #endregion
}
