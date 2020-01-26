using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string OrderId { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }
    }
}
