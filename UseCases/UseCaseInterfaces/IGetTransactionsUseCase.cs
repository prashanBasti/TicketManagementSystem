using System.Transactions;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string ticketStatus);
    }
}