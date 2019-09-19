using FinanceTrackerLib.Enums;
using FinanceTrackerLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTrackerLib.ViewModel
{
    public abstract class TransactionViewModelBase : ViewModelBase
    {
        protected TransactionType _transactionType;

        public TransactionViewModelBase()
        {

        }

        public TransactionViewModelBase(TransactionType transactionType)
        {
            _transactionType = transactionType;
        }

        public Transaction CreateTransaction(string reason, DateTime date, double amount, double balanceBeforeTransaction)
        {
            Transaction createdTransaction = new Transaction(reason, date, amount, _transactionType, balanceBeforeTransaction);
            return createdTransaction;
        }

    }
}
