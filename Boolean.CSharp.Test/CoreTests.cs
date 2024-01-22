using Boolean.CSharp.Main;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

	    [Test]
        public void TestQuestion1()
        {
	        Customer Man1 = new Customer("Eddy", "Oslo");
            Man1.SetAccount(new Account());

            Assert.That(Man1.mAccount, Is.InstanceOf(typeof(Account)));
        }

        [Test]
        public void TestQuestion2()
        {
	        Customer Man1 = new Customer("Eddy", "Oslo");
	        Man1.SetAccount(new SavingsAccount());

	        Assert.That(Man1.mAccount, Is.InstanceOf(typeof(SavingsAccount)));
        }

        [Test]
        public void TestQuestion3()
        {
	        Customer Man1 = new Customer("Eddy", "Oslo");
	        Man1.SetAccount(new Account());

	        Man1.mAccount.MakeTransaction(new BankTransfer(TransactionType.Credit, 1000));
	        Man1.mAccount.MakeTransaction(new BankTransfer(TransactionType.Debit, 250));

	        Assert.That(750, Is.EqualTo(Man1.mAccount.AccountTransactions.Last().NewBalance));
        }

		[Test]
        public void TestQuestion4()
        {
	        Customer Man1 = new Customer("Eddy", "Oslo");
	        Man1.SetAccount(new Account());

	        Man1.mAccount.MakeTransaction(new BankTransfer(TransactionType.Credit, 1000));
            bool result = Man1.mAccount.GenerateStatement();

	        Assert.IsTrue(result);
        }

	}
}