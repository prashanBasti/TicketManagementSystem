using CoreBusiness;
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
    public class EditTicketUseCase : IEditTicketUseCase
    {
        private readonly ITicketRepository ticketRepository;

        public EditTicketUseCase(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }
        public void Execute(Ticket ticket)
        {
            ticketRepository.UpdateTicket(ticket);
        }
    }
}
