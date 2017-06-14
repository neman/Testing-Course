using System;
using System.Collections.Generic;
using System.Linq;

namespace BankManager
{

    #region #5 Fakes

    //public class AccountRepository
    //{
    //    private readonly List<int> _transactions = new List<int>();

    //    public virtual int GetBalance()
    //    {
    //        return _transactions.Sum();
    //    }

    //    public virtual void ProcessTransaction(int amount)
    //    {
    //        _transactions.Add(amount);
    //    }

    //    public List<int> GetTransactions()
    //    {
    //        return _transactions;
    //    }
    //}

    #endregion

    #region #6.3 Logging --> Abstract Infrastructure Test pattern

    //public class AccountRepository
    //{
    //    private readonly List<int> _transactions = new List<int>();

    //    public virtual int GetBalance()
    //    {
    //        Logging.WriteLine("Getting Ballance");
    //        return _transactions.Sum();
    //    }

    //    public virtual void ProcessTransaction(int amount)
    //    {
    //        Logging.WriteLine("Processing transaction");
    //        _transactions.Add(amount);
    //    }

    //    public List<int> GetTransactions()
    //    {
    //        return _transactions;
    //    }
    //}

    #endregion

    #region #8 Abstract Driver - Transaction

    public class AccountRepository
    {
        private readonly List<Transaction> _transactions = new List<Transaction>();

        public virtual int GetBalance()
        {
            return _transactions.Sum(t => t.CalculateTotalTransaction());
        }

        public virtual void ProcessTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public List<Transaction> GetTransactions()
        {
            return _transactions.Select(t => t).ToList();
        }
    }

    #endregion
}