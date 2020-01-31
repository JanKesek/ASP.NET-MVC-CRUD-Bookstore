using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("CustomerID")]
        public int? CustomerId { get; set; }
        [Column("AddressID")]
        public int? AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Order")]
        public virtual Address Address { get; set; }
        [InverseProperty("Order")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
