using FluentAssertions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BankManager.Tests
{
    #region #5 Fakes

    //public class AccountRepositoryTests
    //{


    //    [Fact]
    //    public void GetBallance_WithNoTransactions_Returns0Balance()
    //    {
    //        //Arrange
    //        var sut = AccountRepositoryFactory();

    //        //Act
    //        var accountBallance = sut.GetBalance();

    //        //Assert
    //        const int expectedBallance = 0;
    //        accountBallance.Should().Be(expectedBallance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_FirstTransaction_StoredTransactionsContainOnlyThatOneTransaction()
    //    {
    //        //Arrange            
    //        var sut = AccountRepositoryFactory();
    //        const int depositAmount = 10;

    //        //Act
    //        sut.ProcessTransaction(depositAmount);

    //        //Assert
    //        sut.GetTransactions().Count.Should().Be(1);
    //        depositAmount.Should().Be(sut.GetTransactions().Single());
    //    }

    //    private AccountRepository AccountRepositoryFactory()
    //    {
    //        return new AccountRepository();
    //    }


    //}

    #endregion

    #region #6.3 Logging --> Abstract Infrastructure Test pattern

    //public class AccountRepositoryTests: BaseTest
    //{
    //    [Fact]
    //    public void GetBallance_WithNoTransactions_Returns0Balance()
    //    {
    //        //Arrange
    //        var sut = AccountRepositoryFactory();

    //        //Act
    //        var accountBallance = sut.GetBalance();

    //        //Assert
    //        const int expectedBallance = 0;
    //        accountBallance.Should().Be(expectedBallance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_FirstTransaction_StoredTransactionsContainOnlyThatOneTransaction()
    //    {
    //        //Arrange            
    //        var sut = AccountRepositoryFactory();
    //        const int depositAmount = 10;

    //        //Act
    //        sut.ProcessTransaction(depositAmount);

    //        //Assert
    //        sut.GetTransactions().Count.Should().Be(1);
    //        depositAmount.Should().Be(sut.GetTransactions().Single());
    //    }

    //    private AccountRepository AccountRepositoryFactory()
    //    {
    //        return new AccountRepository();
    //    }

    //    public AccountRepositoryTests()
    //    {
    //        base.SetUpLogger();
    //    }
    //}

    #endregion

    #region #7 Global Infrastructure

    //[Collection("Logging collection")]
    //public class AccountRepositoryTests
    //{
    //    [Fact]
    //    public void GetBallance_WithNoTransactions_Returns0Balance()
    //    {
    //        //Arrange
    //        var sut = AccountRepositoryFactory();

    //        //Act
    //        var accountBallance = sut.GetBalance();

    //        //Assert
    //        const int expectedBallance = 0;
    //        accountBallance.Should().Be(expectedBallance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_FirstTransaction_StoredTransactionsContainOnlyThatOneTransaction()
    //    {
    //        //Arrange            
    //        var sut = AccountRepositoryFactory();
    //        const int depositAmount = 10;

    //        //Act
    //        sut.ProcessTransaction(depositAmount);

    //        //Assert
    //        sut.GetTransactions().Count.Should().Be(1);
    //        depositAmount.Should().Be(sut.GetTransactions().Single());
    //    }

    //    private AccountRepository AccountRepositoryFactory()
    //    {
    //        return new AccountRepository();
    //    }       
    //}

    #endregion

    #region #8 Abstract Driver - Transaction

    //public class AccountRepositoryTests
    //{
    //    [Fact]
    //    public void GetBallance_WithNoTransactions_ReturnsZeroBalance()
    //    {
    //        //Arrange
    //        var sut = AccountRepositoryFactory();

    //        //Act
    //        var accountBallance = sut.GetBalance();

    //        //Assert
    //        const int expectedBallance = 0;
    //        accountBallance.Should().Be(expectedBallance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_FirstTransaction_StoredTransactionsContainOnlyThatOneTransaction()
    //    {
    //        //Arrange            
    //        var sut = AccountRepositoryFactory();
    //        var transaction = new SimpleTransaction(10);

    //        //Act
    //        sut.ProcessTransaction(transaction);

    //        //Assert
    //        sut.GetTransactions().Count.Should().Be(1);
    //        transaction.Should().Be(sut.GetTransactions().Single());
    //    }

    //    private AccountRepository AccountRepositoryFactory()
    //    {
    //        return new AccountRepository();
    //    }
    //}

    #endregion

    #region #9.1 Parametrized Tests - Constants

    //public class AccountRepositoryTests
    //{
    //    [Fact]
    //    public void GetBallance_WithNoTransactions_ReturnsZeroBalance()
    //    {
    //        //Arrange
    //        var sut = AccountRepositoryFactory();

    //        //Act
    //        var accountBallance = sut.GetBalance();

    //        //Assert
    //        const int expectedBallance = 0;
    //        accountBallance.Should().Be(expectedBallance);
    //    }

    //    [Theory]
    //    [InlineData(10)]
    //    [InlineData(0)]
    //    [InlineData(-5)]
    //    public void ProcessTransaction_FirstTransaction_StoredTransactionsContainOnlyThatOneTransaction(int transactionAmount)
    //    {
    //        //Arrange            
    //        var sut = AccountRepositoryFactory();
    //        var transaction = new SimpleTransaction(transactionAmount);

    //        //Act
    //        sut.ProcessTransaction(transaction);

    //        //Assert
    //        sut.GetTransactions().Count.Should().Be(1);
    //        transaction.Should().Be(sut.GetTransactions().Single());
    //    }

    //    private AccountRepository AccountRepositoryFactory()
    //    {
    //        return new AccountRepository();
    //    }
    //}

    #endregion

    #region #9.2 Parametrized Tests - Test case source

    public class AccountRepositoryTests
    {
        [Fact]
        public void GetBallance_WithNoTransactions_ReturnsZeroBalance()
        {
            //Arrange
            var sut = AccountRepositoryFactory();

            //Act
            var accountBallance = sut.GetBalance();

            //Assert
            const int expectedBallance = 0;
            accountBallance.Should().Be(expectedBallance);
        }

        [Theory]
        [MemberData(nameof(Transactions))]
        public void ProcessTransaction_FirstTransaction_StoredTransactionsContainOnlyThatOneTransaction(Transaction transaction)
        {
            //Arrange            
            var sut = AccountRepositoryFactory();           

            //Act
            sut.ProcessTransaction(transaction);

            //Assert
            sut.GetTransactions().Count.Should().Be(1);
            transaction.Should().Be(sut.GetTransactions().Single());
        }

        private AccountRepository AccountRepositoryFactory()
        {
            return new AccountRepository();
        }

        public static IEnumerable<object[]> Transactions
        {
            get
            {
                yield return new object[] { (new SimpleTransaction(10)) };
                yield return new object[] { (new SimpleTransaction(0)) };
                yield return new object[] { (new SimpleTransaction(-1)) };
                yield return new object[] { (new FeeTransaction(10, 2)) };
            }
        }
    }

    #endregion
}
