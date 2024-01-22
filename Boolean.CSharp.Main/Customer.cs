using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
	public class Customer
	{
		private string _name;
		private string _address;
		private bool _isManager;
		public Customer(string name, string address)
		{
			_name = name;
			_address = address;
			_isManager = false;
		}

		public void SetAccount(Account acc)
		{
			mAccount = acc;
		}
		public Account mAccount { get; set; }
	}
}
