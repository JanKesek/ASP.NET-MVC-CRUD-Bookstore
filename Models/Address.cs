using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class Address
    {
        public Address()
        {
            Customer = new HashSet<Customer>();
            Order = new HashSet<Order>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int AddressId { get; set; }
        public int? CustomerId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Number { get; set; }
        public string Street { get; set; }
        public byte? ApartmentNumber { get; set; }
        public int? Zip { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
