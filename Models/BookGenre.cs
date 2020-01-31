using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class BookGenre
    {
        [Key]
        [Column("GenreID")]
        public int GenreId { get; set; }
        [Key]
        [Column("ISBN")]
        public int Isbn { get; set; }

        [ForeignKey(nameof(GenreId))]
        [InverseProperty("BookGenre")]
        public virtual Genre Genre { get; set; }
        [ForeignKey(nameof(Isbn))]
        [InverseProperty(nameof(Book.BookGenre))]
        public virtual Book IsbnNavigation { get; set; }
    }
}
