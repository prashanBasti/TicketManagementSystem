﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class TicketInMemoryRepository : ITicketInMemoryRepository
    {
        private List<Ticket> tickets;
        public TicketInMemoryRepository()
        {
            //Init with some default values
            tickets = new List<Ticket>()
           {
               new Ticket {TicketId = 1, UserId = 1, Name = "Deployment to UAT"},
               new Ticket {TicketId = 2, UserId = 2, Name = "User Training"}
           };
        }

        public IEnumerable<Ticket> GetTickets()
        {
            return tickets;
        }

        public void AddTicket(Ticket ticket)
        {
            if (tickets.Any(x => x.Name.Equals(ticket.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (tickets != null && tickets.Count > 0)
            {
                var maxId = tickets.Max(x => x.UserId);
                ticket.TicketId = maxId + 1;
            }
            else
            {
                ticket.TicketId = 1;
            }

            tickets.Add(ticket);
        }

        public Ticket GetTicketById(int ticketId)
        {
            return tickets.FirstOrDefault(x => x.TicketId == ticketId);
        }

        public void UpdateTicket(Ticket ticket)
        {
            var ticketToUpdate = GetTicketById(ticket.TicketId);
            if (ticketToUpdate != null)
            {
                ticketToUpdate.Name = ticket.Name;
                ticketToUpdate.UserId = ticket.UserId;
            }
        }

        public void DeleteTicket(int ticketId)
        {
            var ticketToDelete = GetTicketById(ticketId);
            if (ticketId != null) tickets.Remove(ticketToDelete);
        }
    }
}
