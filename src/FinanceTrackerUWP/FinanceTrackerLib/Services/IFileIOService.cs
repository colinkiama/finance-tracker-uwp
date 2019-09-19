using FinanceTrackerLib.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTrackerLib.Services
{
    public interface IFileIOService
    {
        Task<IEnumerable<FinanceAccount>> LoadFinanceAccountsAsync();
        Task<IEnumerable<Transaction>> LoadTransactionsAsync(FinanceAccount accountToLoadFrom);
        Task SaveTransactionsAsync(IEnumerable<FinanceAccount> accountsToSave, IDictionary<string, IEnumerable<Transaction>> accountTransactions);
    }
}
