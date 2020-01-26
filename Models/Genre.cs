using System;
using System.Collections.Generic;

namespace BookstoreCRUD.Models
{
    public partial class Genre
    {
        public Genre()
        {
            AuthorGenre = new HashSet<AuthorGenre>();
            BookGenre = new HashSet<BookGenre>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AuthorGenre> AuthorGenre { get; set; }
        public virtual ICollection<BookGenre> BookGenre { get; set; }
    }
}
