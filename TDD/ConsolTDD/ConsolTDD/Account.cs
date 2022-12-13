namespace ConsolTDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account
{
    public double Balance { get; private set; }

    public void Deposit(double amount)
    {
        if (amount < 0) return;
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0) return;
        if (amount <= Balance)
        {
            Balance -= amount;
        }
    }
}
