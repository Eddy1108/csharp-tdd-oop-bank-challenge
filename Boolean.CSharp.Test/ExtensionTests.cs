using Boolean.CSharp.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private Extension _extension;
        public ExtensionTests()
        {
            _extension = new Extension();
        }

        [Test]
        public void TestQuestion1()
        {
            Customer Man1 = new Customer("Eddy", "Oslo");
            Man1.SetAccount(new Account());

            Man1.mAccount.MakeTransaction(new BankTransfer(TransactionType.Credit, 1000));
            Man1.mAccount.MakeTransaction(new BankTransfer(TransactionType.Debit, 250));
            Man1.mAccount.MakeTransaction(new BankTransfer(TransactionType.Credit, 400));


            Assert.That(1150, Is.EqualTo(Man1.mAccount.GetCalculatedBalance()));
        }
        [Test]
        public void TestQuestion2()
        {
            Customer Man1 = new Customer("Eddy", "Oslo");
            Man1.SetAccount(new Account(AccountBranch.London));

            Assert.That(AccountBranch.London, Is.EqualTo(Man1.mAccount.Branch));
        }
    }
}
