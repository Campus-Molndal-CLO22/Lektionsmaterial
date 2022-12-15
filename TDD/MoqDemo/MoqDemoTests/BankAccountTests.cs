using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqDemo;
using MoqDemo.Interface;

namespace MoqDemo.Tests;

[TestClass()]
public class BankAccountTests
{
    IBankAccount? account = null;
    [TestInitialize]
    public void Init()
    {
        //account = new BankAccount();
        var moq = new Mock<IBankAccount>();
        moq.Setup(x => x.Balance).Returns(100);
        moq.Setup(x => x.Deposit(100));
        moq.Setup(x => x.Withdraw(100));
        account = moq.Object;
    }
    [TestMethod()]
    public void DepositTest()
    {
        // Arrange
        double expected = 100;
        // Act
        account.Deposit(100);

        // Assert
        Assert.AreEqual(expected, account.Balance);
    }

    [TestMethod()]
    public void WithdrawTest()
    {
        // Arrange
        account.Deposit(200);
        double expected = 100;
        account.Withdraw(100);

        // Assert
        Assert.AreEqual(expected, account.Balance);
    }
}