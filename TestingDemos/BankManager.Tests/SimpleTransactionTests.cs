using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankManager.Tests
{
    #region #8.1 Abstract Driver - Transaction

    //public class SimpleTransactionTests
    //{
    //    [Fact]
    //    public void CalculateTotalTransaction_AmountProvided_ReturnsSameAmount()
    //    {
    //        //Arrange
    //        const int baseAmount = 100;
    //        var sut = new SimpleTransaction(baseAmount);

    //        //Act
    //        var totalTransaction = sut.CalculateTotalTransaction();

    //        //Assert
    //        totalTransaction.Should().Be(baseAmount);            
    //    }
    //}

    #endregion

    #region #8.2 Abstract Driver - Transaction - test abstraction with abstraction

    public class SimpleTransactionTests : TransactionTests
    {
        public override Transaction GetTransactionWith(int baseAmount)
        {
            return new SimpleTransaction(baseAmount);
        }

        [Fact]
        public void CalculateTotalTransaction_AmountProvided_ReturnsSameAmount()
        {
            //Arrange
            const int baseAmount = 100;
            var sut = new SimpleTransaction(baseAmount);

            //Act
            var totalTransaction = sut.CalculateTotalTransaction();

            //Assert
            totalTransaction.Should().Be(baseAmount);
        }
    }

    #endregion
}
