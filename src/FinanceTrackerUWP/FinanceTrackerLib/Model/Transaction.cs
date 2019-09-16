using FinanceTrackerLib.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FinanceTrackerLib.Model
{
    public class Transaction
    {
        public string Reason { get; set;}
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public TransactionType CurrentTransactionType { get; set; }
        private double BalanceBeforeTransaction;


        public Transaction()
        {

        }

        public Transaction(string reason, DateTime date, double amount, 
            TransactionType currentTransactionType, double balanceBeforeTransaction)
        {
            Reason = reason;
            Date = date;
            Amount = amount;
            CurrentTransactionType = currentTransactionType;
            BalanceBeforeTransaction = balanceBeforeTransaction;
        }
    }
}
