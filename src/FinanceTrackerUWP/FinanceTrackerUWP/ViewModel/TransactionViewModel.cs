using FinanceTrackerLib.Enums;
using FinanceTrackerLib.Model;
using FinanceTrackerLib.ViewModel;
using FinanceTrackerUWP.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTrackerUWP.ViewModel
{
    public class TransactionViewModel : TransactionViewModelBase
    {
        double _balanceBeforeTransaction = 0.00;
        public void NavigatedTo(TransactionType transactionType, double balanceBeforeTransaction)
        {
            _transactionType = transactionType;
            _balanceBeforeTransaction = balanceBeforeTransaction;
        }

        private DateTime _transactionDate;

        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set
            {
                _transactionDate = value;
                NotifyPropertyChanged();
            }
        }

        private string reason;

        public string Reason
        {
            get { return reason; }
            set
            {
                reason = value;
                NotifyPropertyChanged();
            }
        }

        private double amountEntered;

        public double AmountEntered
        {
            get { return amountEntered; }
            set
            {
                amountEntered = value;
                NotifyPropertyChanged();
            }
        }

        private RelayCommand _doneCommand;

        public RelayCommand DoneCommand
        {
            get { return _doneCommand; }
            set
            {
                _doneCommand = value;
                NotifyPropertyChanged();
            }
        }

        public TransactionViewModel()
        {
            TransactionDate = DateTime.Now;
            AmountEntered = 0.00;
            DoneCommand = new RelayCommand(FinishAddingTransaction, CheckIfAmountHasBeenEntered);
        }

        private void FinishAddingTransaction()
        {
            Transaction createdTransaction = CreateTransaction(Reason, TransactionDate, AmountEntered, _balanceBeforeTransaction);
            // Do something with this e.g put it in a cache/holding service/class.
        }

        private bool CheckIfAmountHasBeenEntered()
        {
            return AmountEntered > 0.00;
        }
    }
}
