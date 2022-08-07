using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetTicketByIdUseCase
    {
        Ticket Execute(int ticketId);
    }
}