using CoreBusiness;
using Plugins.DataStore.InMemory;
using UseCases.UseCaseInterfaces;

namespace UseCases.TicketsUseCases
{
    public class AddTicketUseCase : IAddTicketUseCase
    {
        private readonly ITicketRepository ticketRepository;

        public AddTicketUseCase(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public void Execute(Ticket ticket)
        {
            ticketRepository.AddTicket(ticket);
        }

    }
}
