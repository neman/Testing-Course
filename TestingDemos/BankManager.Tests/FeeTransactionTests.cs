using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankManager.Tests
{

    #region #8.1 Abstract Driver - Transaction

    //public class FeeTransactionTests
    //{
      
    //    [Fact]
    //    public void CalculateTotalTransaction_AmountAndFeeProvided_ReturnsAmountMinusFee()
    //    {
    //        //Arrange
    //        const int baseAmount = 100;
    //        const int fee = 5;
    //        var sut = new FeeTransaction(baseAmount, fee);

    //        //Act
    //        var totalTransaction = sut.CalculateTotalTransaction();

    //        //Assert
    //        const int expectedTotalTransaction = baseAmount - fee;
    //        totalTransaction.Should().Be(expectedTotalTransaction, because: "Calculated transaction should equal the base amount minus the fee.");            
    //    }
    //}

    #endregion

    #region #8.2 Abstract Driver - Transaction - test abstraction with abstraction

    public class FeeTransactionTests : TransactionTests
    {
        public override Transaction GetTransactionWith(int baseAmount)
        {
            return GetTransactionWith(baseAmount, 0);
        }

        public Transaction GetTransactionWith(int baseAmount, int fee)
        {
            return new FeeTransaction(baseAmount, fee);
        }

        [Fact]
        public void CalculateTotalTransaction_AmountAndFeeProvided_ReturnsAmountMinusFee()
        {
            //Arrange
            const int baseAmount = 100;
            const int fee = 5;
            var sut = new FeeTransaction(baseAmount, fee);

            //Act
            var totalTransaction = sut.CalculateTotalTransaction();

            //Assert
            const int expectedTotalTransaction = baseAmount - fee;
            //Uncomment to show beacause message parameter
            //const int expectedTotalTransaction = baseAmount - fee - 1;
            totalTransaction.Should().Be(expectedTotalTransaction, 
                because: "calculated transaction should be equal to the base amount minus the fee");
        }
    }

    #endregion
}
