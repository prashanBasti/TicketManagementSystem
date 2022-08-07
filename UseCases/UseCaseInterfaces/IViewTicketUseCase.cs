using CoreBusiness;

namespace UseCases.TicketsUseCases
{
    public interface IViewTicketUseCase
    {
        IEnumerable<Ticket> Execute();
    }
}