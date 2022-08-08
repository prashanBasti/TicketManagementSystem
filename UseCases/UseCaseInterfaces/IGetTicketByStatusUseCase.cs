using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetTicketByStatusUseCase
    {
        IEnumerable<Ticket> Execute(string ticketStatus);
    }
}