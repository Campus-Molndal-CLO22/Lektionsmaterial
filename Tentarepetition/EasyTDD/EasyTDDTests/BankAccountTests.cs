using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyTDD;

namespace EasyTDD.Tests;

[TestClass()]
public class BankAccountTests
{
    [TestMethod()]
    public void BankAccountTest()
    {
        var acc = new BankAccount(100);
        Assert.AreEqual(100, acc.Balance);
    }

    [TestMethod()]
    public void DepositTest()
    {
        var acc = new BankAccount(100);
        acc.Deposit(50);
        Assert.AreEqual(150, acc.Balance);
    }

    [TestMethod()]
    public void DepositTest_negative()
    {
        var acc = new BankAccount(100);
        acc.Deposit(-50);
        Assert.AreEqual(100, acc.Balance);
    }
    
    [TestMethod()]
    [DataRow(100, 50, 50)] // Normalt
    [DataRow(100, 100, 0)] // gränsfallsvärde
    [DataRow(100, 150, 100)] // edge case = gränsfallsvärde
    [DataRow(100, -150, 100)] // edge case = gränsfallsvärde
    public void WithdrawTest(int initial, int amount, int expected)
    {
        var acc = new BankAccount(initial);
        acc.Withdraw(amount);
        Assert.AreEqual(expected, acc.Balance);
    }

}