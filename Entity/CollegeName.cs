﻿using System;
using System.Collections.Generic;

namespace coolege_management.Entity
{
    public partial class CollegeName
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModefiedDate { get; set; }
    }
}
