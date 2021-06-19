﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }

        [StringLength(1)]
        public string AdminRole { get; set; }
    }
}
