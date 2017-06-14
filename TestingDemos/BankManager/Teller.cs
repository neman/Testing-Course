using System;
using System.Collections.Generic;
using System.Linq;

namespace BankManager
{

    #region #2, #3

    //public class Teller
    //{
    //    public object CheckBalance()
    //    {
    //        return 0;
    //    }
    //}

    #endregion

    #region #4

    //public class Teller
    //{
    //    private readonly List<int> _transactions = new List<int>();

    //    public int CheckBalance()
    //    {
    //        return _transactions.Sum();
    //    }

    //    public int ProcessTransaction(int amount)
    //    {
    //        _transactions.Add(amount);
    //        return CheckBalance();
    //    }
    //}

    #endregion

    #region #5 Fakes

    //public class Teller
    //{
    //    private readonly AccountRepository _accountRepository;
    //    public Teller(AccountRepository accountRepository)
    //    {
    //        _accountRepository = accountRepository ?? throw new ArgumentNullException("accountRepository");
    //    }

    //    public int CheckBalance()
    //    {
    //        return _accountRepository.GetBalance();
    //    }

    //    public int ProcessTransaction(int amount)
    //    {
    //        _accountRepository.ProcessTransaction(amount);
    //        return CheckBalance();
    //    }
    //}

    #endregion

    #region #6 Abstract Test infrastructure

    //public class Teller
    //{
    //    private readonly AccountRepository _accountRepository;
    //    public Teller(AccountRepository accountRepository)
    //    {
    //        _accountRepository = accountRepository ?? throw new ArgumentNullException("accountRepository");
    //    }

    //    public int CheckBalance()
    //    {
    //        Logging.WriteLine("Checking the user's balance.");
    //        return _accountRepository.GetBalance();
    //    }

    //    public int ProcessTransaction(int amount)
    //    {
    //        Logging.WriteLine($"Processing a transaction of $ {amount}");
    //        _accountRepository.ProcessTransaction(amount);
    //        return CheckBalance();
    //    }
    //}    

    #endregion

    #region #8 Abstract Driver - Transaction

    public class Teller
    {
        private readonly AccountRepository _accountRepository;
        public Teller(AccountRepository accountRepository)
        {
            _accountRepository = accountRepository ?? throw new ArgumentNullException("accountRepository");
        }

        public int CheckBalance()
        {
            Logging.WriteLine("Checking the user's balance.");
            return _accountRepository.GetBalance();
        }

        public int ProcessTransaction(Transaction transaction)
        {
            Logging.WriteLine($"Processing a transaction of $ {transaction.CalculateTotalTransaction()}");
            _accountRepository.ProcessTransaction(transaction);
            return CheckBalance();
        }
    }

    #endregion
}
