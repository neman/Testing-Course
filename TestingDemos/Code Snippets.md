#### 1
```csharp
public class TellerTests
{

}
```
#### 2 CheckBalance_WithNoTransactions_Returns0Balance

`TellerTest.cs`
```csharp
[Fact]
public void CheckBalance_WithNoTransactions_Returns0Balance()
{
    //Arrange
    var teller = new Teller();
    
    //Act
    var accountBallance = teller.CheckBalance();

    //Assert
    const int expectedBallance = 0;
    Assert.Equal(expectedBallance, accountBallance);
}
```
`Teller.cs`
```csharp
public class Teller
{
    public object CheckBalance()
    {
        return 0;
    }
}
```
#### 3 FluentAssertions
http://fluentassertions.com/

`TellerTest.cs`
```csharp
[Fact]
public void CheckBalance_WithNoTransactions_Returns0Balance()
{
    //Arrange
    var teller = new Teller();

    //Act
    var accountBallance = teller.CheckBalance();

    //Assert
    const int expectedBallance = 0;
    accountBallance.Should().Be(expectedBallance);
}
```
#### 4 TellerFactory (maybe base test class example)

```csharp
public class Teller
{
    private readonly List<int> _transactions = new List<int>();
    
    public int CheckBalance()
    {
        return _transactions.Sum();
    }

    public int ProcessTransaction(int amount)
    {
        _transactions.Add(amount);
        return CheckBalance();
    }
}
```
`TellerTest.cs`
```csharp 
[Fact]
public void CheckBalance_WithNoTransactions_Returns0Balance()
{
    //Arrange
    var sut = new Teller();

    //Act
    var accountBallance = sut.CheckBalance();

    //Assert
    const int expectedBallance = 0;
    accountBallance.Should().Be(expectedBallance);
}

[Fact]
public void ProcessTransactions_FirstTransaction_ReturnsCurrentBallanceSameAsTransaction()
{
    //Arrange
    var sut = new Teller();
    const int depositAmount = 10;

    //Act
    var accountBallance = sut.ProcessTransaction(depositAmount);

    //Assert
    accountBallance.Should().Be(depositAmount);
}

private Teller TellerFactory()
{
    return new Teller();
}
```
#### #5 Fakes --> AccountRepository, RepositoryTests, TellerTests
#### #6 Abstract Test infrastructure
