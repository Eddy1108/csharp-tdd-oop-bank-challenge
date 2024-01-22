using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
	public enum TransactionType
	{
		Credit, //Adding money to account
		Debit	//Removing Money from account
	}

	public enum TransactionStatus
	{
		Pending,
		Approved,
		Rejected
	}

	public interface IBankTransaction
	{

		public static int Id { get; set; } = 0;

		public TransactionType Type { get; set; }

		public TransactionStatus Status { get; set; }
	
		public DateTime Created { get; set; }

		public decimal Amount { get; set; }

		public decimal NewBalance { get; set; }

		public decimal OldBalance { get; set; }
	}
}
