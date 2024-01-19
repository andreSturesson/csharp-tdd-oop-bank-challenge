﻿using System.Text;

namespace Boolean.CSharp.Main;

public interface IAccount
{
    List<Transaction> Transactions {get; }
    Branch Branch {get; }
    Signature Signature {get; }

    Guid Id {get; }

    Transaction Deposit(int amount);
    Transaction Withdrawl(int amount);
    StringBuilder PrintReceipt();
}
