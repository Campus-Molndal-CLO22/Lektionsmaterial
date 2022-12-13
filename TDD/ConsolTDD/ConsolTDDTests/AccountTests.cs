namespace ConsolTDDTests;
using ConsolTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class AccountTests
{
    [TestMethod]
    [DataRow(100, 100)]
    [DataRow(-100, 0)]
    public void MultiDepositTest(double amount, double expected)
    {
        // Arrange
        Account account = new();
        // Act
        account.Deposit(amount);
        // Assert
        Assert.AreEqual(expected, account.Balance);
    }

    [TestMethod]
    [DataRow(100, 50, 50)] // Normal
    [DataRow(100, 100, 0)] // Ta ut allt
    [DataRow(100, 150, 100)] // Ta ut för mycket
    [DataRow(100,-500, 100)] // Olovlig uttag
    
    public void MultiWithdraw(double amountIn, double amountOut, double expected)
    {
        // Arrange
        Account account = new();
        // Act
        account.Deposit(amountIn);
        account.Withdraw(amountOut);
        // Assert
        var actual = account.Balance;
        Assert.AreEqual(expected,actual);
    }




    [TestMethod()]
    public void DepositTest()
    {
        // Arrange
        var sut = new Account();
        var extected = 100.0;
        // Act
        sut.Deposit(100);

        // Assert
        Assert.AreEqual(extected, sut.Balance);
    }

    [TestMethod()]
    public void WithdrawTest()
    {
        // Arrange
        var sut = new Account();
        var extected = 0;
        // Act
        sut.Withdraw(100);

        // Assert
        Assert.AreEqual(extected, sut.Balance);
    }
    [TestMethod()]
    public void WithdrawTest2()
    {
        // Arrange
        var sut = new Account();
        var extected = 0;
        // Act
        sut.Deposit(100);
        sut.Withdraw(100);

        // Assert
        Assert.AreEqual(extected, sut.Balance);
    }

    [TestMethod()]
    public void WithdrawTest3()
    {
        // Arrange
        var sut = new Account();
        var extected = 50;
        // Act
        sut.Deposit(100);
        sut.Withdraw(50);

        // Assert
        Assert.AreEqual(extected, sut.Balance);
    }

    [TestMethod()]
    public void WithdrawTest4()
    {
        // Arrange
        var sut = new Account();
        var extected = 50;
        // Act
        sut.Withdraw(-50);

        // Assert
        Assert.AreEqual(extected, sut.Balance);
    }

    [TestMethod()]
    public void DepositNegative()
    {
        // Arrange
        var sut = new Account();
        var extected = 0;
        // Act
        sut.Deposit(-50);

        // Assert
        Assert.AreEqual(extected, sut.Balance);
    }
}