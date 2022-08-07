using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Ticket
    {
        public int TicketId { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public int UserId { get; set; }
        
        
    }
}
