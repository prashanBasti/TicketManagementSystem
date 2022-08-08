using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;

namespace Plugins.DataStore.InMemory
{
    public class TransactionInMemoryRepository/* : ITransactionRepository*/
    {
        private List<Transaction> transactions;

        public TransactionInMemoryRepository()
        {
            transactions = new List<Transaction>();

        }

        public IEnumerable<Transaction> Get(string ticketStatus)
        {
            if (string.IsNullOrEmpty(ticketStatus))
                return transactions;
            else
                return transactions.Where(x => string.Equals(x.TicketStatus, ticketStatus, StringComparison.OrdinalIgnoreCase));
        }

        public void Save(string ticketStatus, string ticketName, int userId, string userName)
        {
            int transactionId = 0;
            if (transactionId != null && transactions.Count > 0)
            {
                int maxId = transactions.Max(x => x.TransactionId);
                transactionId = maxId + 1;
            }
            else
                transactionId = 1;
        }

        public IEnumerable<Transaction> Search(string ticketStatus)
        {
            return transactions;
        }

    }
}
