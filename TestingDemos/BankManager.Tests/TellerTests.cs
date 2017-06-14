using FluentAssertions;
using Moq;
using System;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace BankManager.Tests
{
    #region #2

    //public class TellerTests
    //{
    //    [Fact]
    //    public void CheckBalance_WithNoTransactions_Returns0Balance()
    //    {
    //        //Arrange
    //        var teller = new Teller();

    //        //Act
    //        var accountBallance = teller.CheckBalance();

    //        //Assert
    //        const int expectedBallance = 0;
    //        Assert.Equal(expectedBallance, accountBallance);
    //    }
    //}

    #endregion

    #region #3

    //public class TellerTests
    //{
    //    [Fact]
    //    public void CheckBalance_WithNoTransactions_Returns0Balance()
    //    {
    //        //Arrange
    //        var teller = new Teller();

    //        //Act
    //        var accountBallance = teller.CheckBalance();

    //        //Assert
    //        const int expectedBallance = 0;
    //        accountBallance.Should().Be(expectedBallance);

    //    }
    //}
    #endregion

    #region #4

    //public class TellerTests
    //{

    //    [Fact]
    //    public void CheckBalance_WithNoTransactions_Returns0Balance()
    //    {
    //        //Arrange
    //        var sut = new Teller();

    //        //Act
    //        var accountBallance = sut.CheckBalance();

    //        //Assert
    //        const int expectedBallance = 0;
    //        accountBallance.Should().Be(expectedBallance);
    //    }

    //    [Fact]
    //    public void ProcessTransactions_FirstTransaction_ReturnsCurrentBallanceSameAsTransaction()
    //    {
    //        //Arrange
    //        var sut = new Teller();
    //        const int depositAmount = 10;

    //        //Act
    //        var accountBallance = sut.ProcessTransaction(depositAmount);

    //        //Assert
    //        accountBallance.Should().Be(depositAmount);
    //    }

    //    private Teller TellerFactory()
    //    {
    //        return new Teller();
    //    }
    //}

    #endregion

    #region #5 Fakes   

    //public class TellerTests
    //{

    //    private AccountRepository _accountRepository;
    //    [Fact]
    //    public void CheckBalance_RequestsTheAccountBalanceFromTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int nonZeroBalance = 1;
    //        Mock.Get(_accountRepository).Setup(x => x.GetBalance()).Returns(nonZeroBalance);

    //        //Act
    //        var balanceFromRepository = sut.CheckBalance();

    //        //Assert
    //        balanceFromRepository.Should().Be(nonZeroBalance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_TransactionValueGiven_TellerSubmitsGivenTransactionToTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int depositAmount = 10;

    //        //Act
    //        sut.ProcessTransaction(depositAmount);
    //        Mock.Get(_accountRepository).Verify(x => x.ProcessTransaction(depositAmount), Times.Once(),
    //           "The teller should forward the process transaction request to the repository.");

    //    }

    //    private Teller TellerFactory()
    //    {
    //        _accountRepository = Mock.Of<AccountRepository>();
    //        return new Teller(_accountRepository);
    //    }
    //}

    #endregion

    #region #6.1 Same as before, just to run and show failing tests   

    //public class TellerTests
    //{

    //    private AccountRepository _accountRepository;
    //    [Fact]
    //    public void CheckBalance_RequestsTheAccountBalanceFromTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int nonZeroBalance = 1;
    //        Mock.Get(_accountRepository).Setup(x => x.GetBalance()).Returns(nonZeroBalance);

    //        //Act
    //        var balanceFromRepository = sut.CheckBalance();

    //        //Assert
    //        balanceFromRepository.Should().Be(nonZeroBalance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_TransactionValueGiven_TellerSubmitsGivenTransactionToTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int depositAmount = 10;

    //        //Act
    //        sut.ProcessTransaction(depositAmount);
    //        Mock.Get(_accountRepository).Verify(x => x.ProcessTransaction(depositAmount), Times.Once(),
    //           "The teller should forward the process transaction request to the repository.");

    //    }

    //    private Teller TellerFactory()
    //    {
    //        _accountRepository = Mock.Of<AccountRepository>();
    //        return new Teller(_accountRepository);
    //    }
    //}

    #endregion

    #region #6.2 Fake Logging         

    //public class TellerTests
    //{

    //    private AccountRepository _accountRepository;
    //    [Fact]
    //    public void CheckBalance_RequestsTheAccountBalanceFromTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int nonZeroBalance = 1;
    //        Mock.Get(_accountRepository).Setup(x => x.GetBalance()).Returns(nonZeroBalance);

    //        //Act
    //        var balanceFromRepository = sut.CheckBalance();

    //        //Assert
    //        balanceFromRepository.Should().Be(nonZeroBalance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_TransactionValueGiven_TellerSubmitsGivenTransactionToTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int depositAmount = 10;

    //        //Act
    //        sut.ProcessTransaction(depositAmount);
    //        Mock.Get(_accountRepository).Verify(x => x.ProcessTransaction(depositAmount), Times.Once(),
    //           "The teller should forward the process transaction request to the repository.");

    //    }

    //    private Teller TellerFactory()
    //    {
    //        _accountRepository = Mock.Of<AccountRepository>();
    //        Logging.Logger = Mock.Of<ILogger>();
    //        return new Teller(_accountRepository);

    //        #region write output
    //        //var logger = Mock.Of<ILogger>();
    //        //---1
    //        //Mock.Get(logger).Setup(x => x.WriteLine(It.IsAny<string>())).Callback<string>(Console.WriteLine);
    //        //---2
    //        //Mock.Get(logger).Setup(x => x.WriteLine(It.IsAny<string>())).Callback<string>((msg) => Debug.WriteLine(msg));
    //        //---3
    //        //Mock.Get(logger).Setup(x => x.WriteLine(It.IsAny<string>())).Callback<string>((msg) => output.WriteLine(msg));

    //        //Logging.Logger = logger;
    //        //return new Teller(_accountRepository);
    //        #endregion
    //    }

    //    private readonly ITestOutputHelper output;

    //    public TellerTests(ITestOutputHelper output)
    //    {
    //        this.output = output;
    //    }
    //}

    #endregion

    #region #6.3 Logging --> Abstract Infrastructure Test pattern

    //public class TellerTests:BaseTest
    //{
    //    private AccountRepository _accountRepository;
    //    [Fact]
    //    public void CheckBalance_RequestsTheAccountBalanceFromTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int nonZeroBalance = 1;
    //        Mock.Get(_accountRepository).Setup(x => x.GetBalance()).Returns(nonZeroBalance);

    //        //Act
    //        var balanceFromRepository = sut.CheckBalance();

    //        //Assert
    //        balanceFromRepository.Should().Be(nonZeroBalance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_TransactionValueGiven_TellerSubmitsGivenTransactionToTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int depositAmount = 10;

    //        //Act
    //        sut.ProcessTransaction(depositAmount);
    //        Mock.Get(_accountRepository).Verify(x => x.ProcessTransaction(depositAmount), Times.Once(),
    //           "The teller should forward the process transaction request to the repository.");

    //    }

    //    private Teller TellerFactory()
    //    {
    //        base.SetUpLogger();
    //        _accountRepository = Mock.Of<AccountRepository>();
    //        return new Teller(_accountRepository);

    //        #region write output
    //        //var logger = Mock.Of<ILogger>();
    //        //---1
    //        //Mock.Get(logger).Setup(x => x.WriteLine(It.IsAny<string>())).Callback<string>(Console.WriteLine);
    //        //---2
    //        //Mock.Get(logger).Setup(x => x.WriteLine(It.IsAny<string>())).Callback<string>((msg) => Debug.WriteLine(msg));
    //        //---3
    //        //Mock.Get(logger).Setup(x => x.WriteLine(It.IsAny<string>())).Callback<string>((msg) => output.WriteLine(msg));

    //        //Logging.Logger = logger;
    //        //return new Teller(_accountRepository);
    //        #endregion
    //    }

    //    private readonly ITestOutputHelper output;

    //    public TellerTests(ITestOutputHelper output)
    //    {
    //        this.output = output;
    //    }
    //}

    #endregion

    #region #7 Global Infrastructure

    //[Collection("Logging collection")]
    //public class TellerTest
    //{
    //    private AccountRepository _accountRepository;
    //    [Fact]
    //    public void CheckBalance_RequestsTheAccountBalanceFromTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int nonZeroBalance = 1;
    //        Mock.Get(_accountRepository).Setup(x => x.GetBalance()).Returns(nonZeroBalance);

    //        //Act
    //        var balanceFromRepository = sut.CheckBalance();

    //        //Assert
    //        balanceFromRepository.Should().Be(nonZeroBalance);
    //    }

    //    [Fact]
    //    public void ProcessTransaction_TransactionValueGiven_TellerSubmitsGivenTransactionToTheRepository()
    //    {
    //        //Arrange
    //        var sut = TellerFactory();
    //        const int depositAmount = 10;

    //        //Act
    //        sut.ProcessTransaction(depositAmount);
    //        Mock.Get(_accountRepository).Verify(x => x.ProcessTransaction(depositAmount), Times.Once(),
    //           "The teller should forward the process transaction request to the repository.");
    //    }

    //    private Teller TellerFactory()
    //    {
    //        _accountRepository = Mock.Of<AccountRepository>();
    //        return new Teller(_accountRepository);            
    //    }

    //    LoggingFixture _fixture;
    //    public TellerTest(LoggingFixture fixture)
    //    {
    //        _fixture = fixture;            
    //    }

    //}

    #endregion

    #region #8 Abstract Driver - Transaction

    [Collection("Logging collection")]
    public class TellerTest
    {
        private AccountRepository _accountRepository;
        [Fact]
        public void CheckBalance_RequestsTheAccountBalanceFromTheRepository()
        {
            //Arrange
            var sut = TellerFactory();
            const int nonZeroBalance = 1;
            Mock.Get(_accountRepository).Setup(x => x.GetBalance()).Returns(nonZeroBalance);

            //Act
            var balanceFromRepository = sut.CheckBalance();

            //Assert
            balanceFromRepository.Should().Be(nonZeroBalance);
        }

        [Fact]
        public void ProcessTransaction_TransactionValueGiven_TellerSubmitsGivenTransactionToTheRepository()
        {
            //Arrange
            var sut = TellerFactory();
            var transaction = new SimpleTransaction(10);

            //Act
            sut.ProcessTransaction(transaction);
            Mock.Get(_accountRepository).Verify(x => x.ProcessTransaction(transaction), Times.Once(),
               "The teller should forward the process transaction request to the repository.");
        }

        private Teller TellerFactory()
        {
            _accountRepository = Mock.Of<AccountRepository>();
            return new Teller(_accountRepository);
        }

        LoggingFixture _fixture;
        public TellerTest(LoggingFixture fixture)
        {
            _fixture = fixture;
        }

    }

    #endregion


}
