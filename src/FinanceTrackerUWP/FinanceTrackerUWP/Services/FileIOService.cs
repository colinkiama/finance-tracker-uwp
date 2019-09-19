using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceTrackerLib.Model;
using FinanceTrackerLib.Services;
using Microsoft.Toolkit.Uwp.Helpers;

namespace FinanceTrackerUWP.Services
{
    internal class FileIOService : IFileIOService
    {
        LocalObjectStorageHelper _objectHelper = new LocalObjectStorageHelper();

        // .fta = Finance Tracker Account
        // .ftt = Finance Tracker Transaction

        const string AccountsFileName = "accounts.fta";
        const string AccountTransactionExtension = ".ftt";


        public async Task<IEnumerable<FinanceAccount>> LoadFinanceAccountsAsync()
        {
            IEnumerable<FinanceAccount> accountsToReturn = null;
            bool fileExists = await _objectHelper.FileExistsAsync(AccountsFileName);
            if (fileExists)
            {
                accountsToReturn = await _objectHelper.ReadFileAsync(AccountsFileName, default(IEnumerable<FinanceAccount>));
            }
            return accountsToReturn;
        }

        public async Task<IEnumerable<Transaction>> LoadTransactionsAsync(FinanceAccount accountToLoadFrom)
        {
            IEnumerable<Transaction> transactionsToReturn = null;
            bool fileExists = await _objectHelper.FileExistsAsync($"{accountToLoadFrom.Name}{AccountTransactionExtension}");
            if (fileExists)
            {
                transactionsToReturn = await _objectHelper.ReadFileAsync(AccountsFileName, default(IEnumerable<Transaction>));
            }
            return transactionsToReturn;
        }

        public async Task SaveTransactionsAsync(IEnumerable<FinanceAccount> accountsToSave, IDictionary<string, IEnumerable<Transaction>> accountTransactions)
        {
            // Saves each list of transactions in parallel
            // to speed up things up. The transaction saving operations are mutually exclusive.
            Parallel.ForEach(accountsToSave, async (account) =>
            {
                string accountName = account.Name;
                IEnumerable<Transaction> transactionsToSave = accountTransactions[accountName];
                await _objectHelper.SaveFileAsync($"{accountName}{AccountTransactionExtension}", transactionsToSave);
            });

            await _objectHelper.SaveFileAsync(AccountsFileName, accountsToSave);

        }
    }
}
