namespace MoqDemo;

using MoqDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount : IBankAccount
{
    public double Balance { get; }

    public void Deposit(double amount)
    {
        throw new NotImplementedException();
    }

    public void Withdraw(double amount)
    {
        throw new NotImplementedException();
    }
}
