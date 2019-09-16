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
        Task<List<FinanceAccount>> LoadFinananceAccountsAsync();
        Task<List<Transaction>> LoadTransactionsAsync(FinanceAccount accountToLoadFrom);
        Task SaveTransactionsAsync(IEnumerable<FinanceAccount> accountsToSave, IDictionary<string, List<Transaction>> accountTransactions);
    }
}
