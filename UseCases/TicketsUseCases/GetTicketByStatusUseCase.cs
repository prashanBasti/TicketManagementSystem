using CoreBusiness;
using Plugins.DataStore.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.UseCaseInterfaces;

namespace UseCases.TicketsUseCases
{
    public class GetTicketByStatusUseCase : IGetTicketByStatusUseCase
    {
        private readonly ITicketRepository ticketRepository;

        public GetTicketByStatusUseCase(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }
        public IEnumerable<Ticket> Execute(string ticketStatus)
        {
            return ticketRepository.Get(ticketStatus);
        }
    }
}
