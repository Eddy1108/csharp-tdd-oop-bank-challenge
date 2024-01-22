using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
	public class BankTransfer : IBankTransaction
	{
		public BankTransfer(TransactionType type, decimal amount)
		{
			Id++;
			Type = type;
			Status = TransactionStatus.Pending;
			Created = DateTime.Now;
			Amount = amount;

			NewBalance = 0;
			OldBalance = 0;
		}
		public static int Id { get; set; }
		public TransactionType Type { get; set; }
		public TransactionStatus Status { get; set; }
		public DateTime Created { get; set; }
		public decimal Amount { get; set; }
		public decimal NewBalance { get; set; }
		public decimal OldBalance { get; set; }
	}
}
