using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        public int? CompanyId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        
        //navigation prop for EF core
        public Company Company { get; set; }
    }
}
