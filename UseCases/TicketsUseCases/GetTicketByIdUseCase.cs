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
    public class GetTicketByIdUseCase : IGetTicketByIdUseCase
    {
        private readonly ITicketRepository ticketRepository;

        public GetTicketByIdUseCase(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }
        public Ticket Execute(int ticketId)
        {
            return ticketRepository.GetTicketById(ticketId);

        }
    }
}
