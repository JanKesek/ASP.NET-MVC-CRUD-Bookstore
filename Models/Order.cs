using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
