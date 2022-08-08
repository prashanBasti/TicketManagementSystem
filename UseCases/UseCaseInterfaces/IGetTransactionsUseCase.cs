using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string ticketStatus);
    }
}