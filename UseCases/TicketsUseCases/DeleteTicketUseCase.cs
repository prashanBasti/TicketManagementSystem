using Plugins.DataStore.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.TicketsUseCases
{
    public class DeleteTicketUseCase : IDeleteTicketUseCase
    {
        private readonly ITicketRepository ticketRepository;

        public DeleteTicketUseCase(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public void Execute(int ticketId)
        {
            ticketRepository.DeleteTicket(ticketId);
        }
    }
}
