using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class Book
    {
        public Book()
        {
            BookGenre = new HashSet<BookGenre>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Isbn { get; set; }
        public string Title { get; set; }
        public byte? Stock { get; set; }
        public decimal? Price { get; set; }
        public String Picture { get; set; }
        public int? PageCount { get; set; }
        public string Language { get; set; }

        public virtual ICollection<BookGenre> BookGenre { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
