using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
	public class Account
	{
		public List<IBankTransaction> AccountTransactions { get; set; }

        public AccountBranch Branch { get; set; }

		public Account(AccountBranch branch = AccountBranch.None)
		{
			AccountTransactions = new List<IBankTransaction>();
			Branch = branch;
		}

		public bool GenerateStatement()
		{
			Console.WriteLine("date \t\t\t||credit \t||debit \t||balance");
			foreach (var entry in AccountTransactions)
			{
				switch (entry.Type)
				{
					case (TransactionType.Credit):
						Console.WriteLine($"{entry.Created} \t||{entry.Amount} \t\t|| \t\t||{entry.NewBalance}");
						break;
					case (TransactionType.Debit):
						Console.WriteLine($"{entry.Created} \t|| \t\t||{entry.Amount} \t\t||{entry.NewBalance}");
						break;
					default:
						return false;
				}
				
			}

			return true;
		}

		public void MakeTransaction(IBankTransaction entry)
		{
			if (entry.Type == TransactionType.Credit)
			{
				if (AccountTransactions.Count > 0)
				{
					entry.OldBalance = AccountTransactions.Last().NewBalance;
					entry.NewBalance = entry.OldBalance + entry.Amount;
				}
				else
				{
					entry.OldBalance = 0;
					entry.NewBalance = entry.OldBalance + entry.Amount;
				}
			} 
			else if (entry.Type == TransactionType.Debit)
			{
				if (AccountTransactions.Count > 0)
				{
					entry.OldBalance = AccountTransactions.Last().NewBalance;
					entry.NewBalance = entry.OldBalance - entry.Amount;
				}
				else
				{
					entry.OldBalance = 0;
					entry.NewBalance = entry.OldBalance - entry.Amount;
				}
			}

			AccountTransactions.Add(entry);
		}

        public decimal GetCalculatedBalance()
        {
            decimal totalSum = 0;

            foreach (var transaction in AccountTransactions)
            {
                if (transaction.Type == TransactionType.Credit) { totalSum += transaction.Amount; }
				else if (transaction.Type == TransactionType.Debit) { totalSum -= transaction.Amount; }
            }

			return totalSum;
        }
    }
}
