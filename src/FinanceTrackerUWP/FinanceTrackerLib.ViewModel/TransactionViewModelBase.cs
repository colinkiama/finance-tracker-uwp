using FinanceTrackerLib.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTrackerLib.ViewModel
{
    public abstract class TransactionViewModelBase : ViewModelBase
    {
        private TransactionType _transactionType;

        public TransactionViewModelBase(TransactionType transactionType)
        {
            _transactionType = transactionType;
        }

    }
}
