using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class OrderDetails
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? Isbn { get; set; }
        public int? GenreId { get; set; }
        public int? AuthorId { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Author Author { get; set; }
        public virtual Book IsbnNavigation { get; set; }
        public virtual Order Order { get; set; }
        public virtual User OrderNavigation { get; set; }
    }
}
