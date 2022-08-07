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
    public class ViewTicketUseCase : IViewTicketUseCase
    {
        private readonly ITicketRepository ticketRepository;

        public ViewTicketUseCase(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }
        public IEnumerable<Ticket> Execute()
        {
            return ticketRepository.GetTickets();

        }
    }
}
