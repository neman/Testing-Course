using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankManager.Tests
{
    public abstract class TransactionTests
    {
        public abstract Transaction GetTransactionWith(int baseAmount);

        [Fact]
        public void BaseAmount_AmountPassedToConstructor_ReturnsSameAmount()
        {
            //Arrange
            const int nonZeroAmount = 5;

            //Act
            var transaction = GetTransactionWith(nonZeroAmount);

            transaction.BaseAmount.Should().Be(nonZeroAmount,
                because: "The base amount of a transaction should be the same as the amount passed into the constructor.");
            
        }
    }
}
