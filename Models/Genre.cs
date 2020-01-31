using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class Genre
    {
        public Genre()
        {
            AuthorGenre = new HashSet<AuthorGenre>();
            BookGenre = new HashSet<BookGenre>();
        }

        [Key]
        [Column("GenreID")]
        public int GenreId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }

        [InverseProperty("Genre")]
        public virtual ICollection<AuthorGenre> AuthorGenre { get; set; }
        [InverseProperty("Genre")]
        public virtual ICollection<BookGenre> BookGenre { get; set; }
    }
}
