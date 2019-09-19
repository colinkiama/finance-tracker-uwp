using FinanceTrackerLib.Enums;
using FinanceTrackerLib.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTrackerUWP.ViewModel
{
    public class TransactionViewModel : TransactionViewModelBase
    {
        public void NavigatedTo(TransactionType transactionType)
        {
            _transactionType = transactionType;
        }
    }
}
