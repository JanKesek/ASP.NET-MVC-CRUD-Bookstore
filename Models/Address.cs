using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class Address
    {
        public Address()
        {
            Customer = new HashSet<Customer>();
            Order = new HashSet<Order>();
        }

        [Key]
        [Column("AddressID")]
        public int AddressId { get; set; }
        [Column("CustomerID")]
        public int? CustomerId { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        public int? Number { get; set; }
        [StringLength(15)]
        public string Street { get; set; }
        public byte? ApartmentNumber { get; set; }
        public int? Zip { get; set; }

        [InverseProperty("Address")]
        public virtual ICollection<Customer> Customer { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
