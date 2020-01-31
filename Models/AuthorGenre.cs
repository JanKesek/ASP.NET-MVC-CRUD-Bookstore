using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreCRUD.Models
{
    public partial class AuthorGenre
    {
        [Key]
        [Column("GenreID")]
        public int GenreId { get; set; }
        [Key]
        [Column("AuthorID")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("AuthorGenre")]
        public virtual Author Author { get; set; }
        [ForeignKey(nameof(GenreId))]
        [InverseProperty("AuthorGenre")]
        public virtual Genre Genre { get; set; }
    }
}
