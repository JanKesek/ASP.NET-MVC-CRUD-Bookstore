using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class BookGenre
    {
        public int GenreId { get; set; }
        public int Isbn { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Book IsbnNavigation { get; set; }
    }
}
