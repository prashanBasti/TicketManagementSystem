using System.Transactions;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> Get(string ticketStatus);
        void Save(string ticketStatus, string ticketName, int userId, string userName);
        IEnumerable<Transaction> Search(string ticketStatus);
    }
}
