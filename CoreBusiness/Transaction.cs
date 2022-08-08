using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string TicketStatus { get; set; }

        public string TicketName { get; set; }

    }
}
