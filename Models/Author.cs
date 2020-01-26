using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class Author
    {
        public Author()
        {
            AuthorGenre = new HashSet<AuthorGenre>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<AuthorGenre> AuthorGenre { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
