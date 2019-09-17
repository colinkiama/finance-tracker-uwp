using FinanceTrackerLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTrackerLib.ViewModel
{
    public abstract class HistoryViewModelBase : ViewModelBase
    {
        private IEnumerable<Transaction> _transactions;

        public IEnumerable<Transaction> Transactions
        {
            get { return _transactions; }
            set
            {
                _transactions = value;
                NotifyPropertyChanged();
            }
        }

    }
}
