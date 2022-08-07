using CoreBusiness;

namespace Plugins.DataStore.InMemory
{
    public interface ITicketRepository
    {
        void AddTicket(Ticket ticket);
        void DeleteTicket(int ticketId);
        Ticket GetTicketById(int ticketId);
        IEnumerable<Ticket> GetTickets();
        void UpdateTicket(Ticket ticket);
    }
}