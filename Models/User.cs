using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class User
    {
        public User()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(20)]
        public string Login { get; set; }
        [Column(TypeName = "text")]
        public string Password { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        [Column("OrderID")]
        [StringLength(10)]
        public string OrderId { get; set; }

        [InverseProperty("OrderNavigation")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
