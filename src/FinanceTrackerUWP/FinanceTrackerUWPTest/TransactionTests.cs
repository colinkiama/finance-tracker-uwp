
using System;
using FinanceTrackerLib.Enums;
using FinanceTrackerLib.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinanceTrackerUWPTest
{
    [TestClass]
    public class TransactionTests
    {
        [TestMethod]
        public void CalculateBalanceAfterTransaction()
        {
            string reason = "Poorly written test";
            double amount = 20.00;
            DateTime date = DateTime.UtcNow;
            TransactionType transactionType = TransactionType.Expense;
            double balanceBeforeTransaction = 50.00;

            Transaction transaction = new Transaction(reason, date, amount,
                transactionType, balanceBeforeTransaction);


            double expectedBalanceAfterTransaction = balanceBeforeTransaction - amount;

           

            double actualBalanceAfterTransaction = transaction.BalanceAfterTransaction;

            Assert.IsTrue(actualBalanceAfterTransaction == expectedBalanceAfterTransaction);
        }
    }
}
