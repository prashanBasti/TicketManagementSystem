﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Company
    {
        public int CompanyId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Any(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
