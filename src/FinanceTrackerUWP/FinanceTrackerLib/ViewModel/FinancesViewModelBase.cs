using FinanceTrackerLib.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FinanceTrackerLib.ViewModel
{
    public abstract class FinancesViewModelBase : ViewModelBase
    {
        private FinanceAccount _currentAccount;

        public FinanceAccount CurrentAccount
        {
            get { return _currentAccount; }
            set
            {
                _currentAccount = value;
                NotifyPropertyChanged();
            }
        }

        private IEnumerable<Transaction> _recentTransactions;

        public IEnumerable<Transaction> RecentTransactions
        {
            get { return _recentTransactions; }
            set
            {
                _recentTransactions = value;
                NotifyPropertyChanged();
            }
        }

    }
}
