﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterInfo.ViewModels
{
    public class CompleteInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Removed { get; set; }
    }
}