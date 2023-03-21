using System;
namespace MySecondProject
{
    public interface IBank
    {
        void AddAccount(BankAccount account);
        bool WithdrawMoney(decimal amount);
        decimal balance { get; }
    }
}

