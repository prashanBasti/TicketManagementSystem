using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class User
    {

        public int UserId { get; set; }
        [Required]
        public int? ProjectId { get; set; }
        [Required]
        public string Name { get; set; }
       

    }
}
