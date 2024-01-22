// See https://aka.ms/new-console-template for more information

using Boolean.CSharp.Main;

Console.WriteLine("Hello, World!");

Account account = new Account();

account.MakeTransaction(new BankTransfer(TransactionType.Credit, 2000));
account.MakeTransaction(new BankTransfer(TransactionType.Credit, 1000));
account.MakeTransaction(new BankTransfer(TransactionType.Debit, 500));
account.MakeTransaction(new BankTransfer(TransactionType.Debit, 100));

account.GenerateStatement();