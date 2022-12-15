namespace MoqDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBankAccount
{
    double Balance { get; }
    void Deposit(double amount);
    void Withdraw(double amount);
    
}
