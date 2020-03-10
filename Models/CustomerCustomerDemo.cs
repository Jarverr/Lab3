using System;
using System.Collections.Generic;

namespace Lab3.Models
{
    public partial class CustomerCustomerDemo
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
