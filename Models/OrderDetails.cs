using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class OrderDetails
    {
        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Key]
        [Column("ISBN")]
        public int Isbn { get; set; }
        [Key]
        public int NumberOfProducts { get; set; }

        [ForeignKey(nameof(Isbn))]
        [InverseProperty(nameof(Book.OrderDetails))]
        public virtual Book IsbnNavigation { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderDetails")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty(nameof(User.OrderDetails))]
        public virtual User OrderNavigation { get; set; }
    }
}
