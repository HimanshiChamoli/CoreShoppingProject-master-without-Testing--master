﻿using System;
using System.Collections.Generic;

namespace EcommerceUserPanel.Models
{
    public partial class Feedbacks
    {
        public int FeedbackId { get; set; }
        public long PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string Comment { get; set; }
        public int CustomerId { get; set; }

        public Customers Customer { get; set; }
    }
}
